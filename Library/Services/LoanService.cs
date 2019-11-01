using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Services;


namespace Library.Services
{
    /// <summary>
    /// Contains the logic for situations regarding loans
    /// </summary>
    class LoanService : BaseService, IService
    {
        private LoanRepository loanRepository;
        private ReturnedLoanRepository returnedLoanRepository;
        private BookCopyRepository bookCopyRepository;
        private ReturnedLoanService _returnedLoanService;
        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        public LoanService(RepositoryFactory repFactory, ReturnedLoanService returnedLoanService)
        {
            loanRepository = repFactory.CreateLoanRepository();
            returnedLoanRepository = repFactory.CreateReturnedLoanRepository();
            bookCopyRepository = repFactory.CreateBookCopyRepository();
            _returnedLoanService = returnedLoanService;
        }

        protected virtual void OnUpdated(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        /// <summary>
        /// Adds a loan to the repository and raises the updated event.
        /// </summary>
        /// <param name="loan"></param>
        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Returns all the loans from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// The Edit method makes sure that the given Loan object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="l">The edited loan</param>
        public void Edit(Loan l)
        {
            if (IsObjectNotNull(l))
            {
                loanRepository.Edit(l);
                OnUpdated(this, eventArgs);
            }
            else
            {
                throw new ArgumentNullException("No loan selected");
            }
            
            
        }


        /// <summary>
        /// Removes a specific loan from the repository.
        /// </summary>
        /// <param name="loan">The loan to remove.</param>
        public void Remove(Loan loan)
        {
            loanRepository.Remove(loan);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Finds a specific loan.
        /// </summary>
        /// <param name="id">The id to search for loans for.</param>
        /// <returns>A loan</returns>
        public Loan Find(int id)
        {
            return loanRepository.Find(id);
        }

        /// <summary>
        /// Creates a loan object and calls the Add-function with the loan
        /// </summary>
        /// <param name="bookCopy">The Book Copy that is being loaned.</param>
        /// <param name="member">The member that loans the book.</param>
        public void MakeLoan(BookCopy bookCopy, Member member)
        {
            if (IsObjectNotNull(bookCopy, member))
            {
                Loan loan = new Loan()
                {
                    BookCopy = bookCopy,
                    Member = member,
                    TimeOfLoan = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(15),
                    TimeOfReturn = null
                };
                Add(loan);
            } else
            {
                throw new ArgumentNullException("No bookcopy or member selected");
            }
           
        }

        /// <summary>
        /// Finds all the Book Copies that is on loan
        /// </summary>
        /// <param name="bookCopies">A collection of book copies that may or may not be on loan.</param>
        /// <returns>A collection of book copies that is on loan</returns>
        public IEnumerable<BookCopy> FindBookCopiesOnLoan(IEnumerable<BookCopy> bookCopies)
        {
            return bookCopies.Join(loanRepository.All(), 
                bc => bc.Id, 
                l => l.BookCopy.Id, 
                (bookCopy, loan) => new { BookCopy = bookCopy, Loan = loan }).
                    Where(l => l.Loan.TimeOfLoan > l.Loan.TimeOfReturn || (l.Loan.TimeOfReturn == null && l.Loan.TimeOfLoan < DateTime.Now)).
                    Select(bc => bc.BookCopy);
        }

        /// <summary>
        /// Sets the loans time of return to now, raises the updated-event, calls the private CreateReturnedLoan, Remove and PenaltyMessage-functions.
        /// </summary>
        /// <param name="selectedLoan">The selected loan to return</param>
        /// <returns>A string with the return message that includes the penalty fee if there is one.</returns>
        public string ReturnBook(Loan selectedLoan)
        {
            int penalty = 0;
            if (IsObjectNotNull(selectedLoan))
            {
                
                if (selectedLoan.DueDate < DateTime.Now)
                {
                    penalty = CalculatePrice(selectedLoan);
                }
                selectedLoan.TimeOfReturn = DateTime.Now;
                loanRepository.Edit(selectedLoan);
                OnUpdated(this, eventArgs);
                CreateReturnedLoan(selectedLoan);
                Loan tempLoan = new Loan()
                {
                    BookCopy = selectedLoan.BookCopy,
                    Member = selectedLoan.Member
                }; 
                Remove(selectedLoan);
                return PenaltyMessage(penalty, tempLoan);
            } else
            {
                throw new NullReferenceException("No loan selected");
            }
        }

        
        private string PenaltyMessage(int penalty, Loan loan)
        {
            string returnMessage = String.Format("{0} returned by {1}!", loan.BookCopy.Book.Title, loan.Member.Name);
            if (penalty <= 0)
            {
                return returnMessage;
            }
            returnMessage += String.Format(" {0}'s penalty fee is {1}!", loan.Member.Name, penalty.ToString());
            return returnMessage;
        }

        private void CreateReturnedLoan(Loan loan)
        {
            ReturnedLoan returned = new ReturnedLoan()
            {
                BookCopy = loan.BookCopy as BookCopy,
                TimeOfLoan = loan.TimeOfLoan,
                TimeOfReturn = loan.TimeOfReturn,
                Member = loan.Member as Member,
                DueDate = loan.DueDate
            };
            _returnedLoanService.Add(returned);
        }

        private int CalculatePrice(Loan loan)
        {
            
            int result = loan.DueDate.Day - DateTime.Now.Day;

            return result * 10;
        }


        /// <summary>
        /// Find all active loans
        /// </summary>
        /// <returns>A collection of loans</returns>
        public IEnumerable<Loan> FindAllBooksOnLoan()
        {
            return loanRepository.All().Select(l => l).Where(l => l.TimeOfLoan > l.TimeOfReturn || (l.TimeOfReturn == null && l.TimeOfLoan < DateTime.Now));
        }

        /// <summary>
        /// Finds all book copies that is not on loan
        /// </summary>
        /// <param name="bookCopies">The book copies to search within</param>
        /// <param name="loans">The loans to search within</param>
        /// <returns>A collection of Book Copies that is not on loan</returns>
        public IEnumerable<BookCopy> FindAllAvailableBooks(IEnumerable<BookCopy> bookCopies, IEnumerable<Loan> loans)
        {
            var loanedBookCopies = loans.Select(l => l.BookCopy).ToList();
            var availableBooks = bookCopies.Where(bc => !loanedBookCopies.Any(lbc => lbc.Id == bc.Id)).ToList();

            return availableBooks;
        }

        /// <summary>
        /// Finds all book copies that is overdue
        /// </summary>
        /// <param name="loans">The loans to search within</param>
        /// <returns>A collection of Book Copies that is overdue.</returns>
        public IEnumerable<BookCopy> FindAllOverdueBooks(IEnumerable<Loan> loans)
        { 
            return loans.Where(l => l.DueDate < DateTime.Now && l.TimeOfReturn == null).
                Select(l => l.BookCopy).ToList();
        }

        /// <summary>
        /// Check if a BookCopy is on loan
        /// </summary>
        /// <param name="bookCopy">The book copy to check</param>
        /// <returns>True if the book is on loan, false otherwise</returns>
        public bool CheckIfBookIsOnLoan (BookCopy bookCopy)
        {
            return (!FindAllAvailableBooks(bookCopyRepository.All(), All()).Contains(bookCopy));

        }
    }
}
