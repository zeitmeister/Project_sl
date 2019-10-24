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
    class LoanService : IService
    {
        LoanRepository loanRepository;
        ReturnedLoanRepository returnedLoanRepository;
        public event EventHandler Updated;

        public event EventHandler Returned;
        private EventArgs eventArgs = new EventArgs();

        public LoanService(RepositoryFactory repFactory)
        {
            loanRepository = repFactory.CreateLoanRepository();
            returnedLoanRepository = repFactory.CreateReturnedLoanRepository();
        }

        protected virtual void OnUpdated(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        protected virtual void OnReturned(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
            OnUpdated(this, eventArgs);
        }

        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        public void Remove(Loan loan)
        {
            loanRepository.Remove(loan);
            OnUpdated(this, eventArgs);
        }

        public Loan Find(int id)
        {
            return loanRepository.Find(id);
        }

        public void MakeLoan(BookCopy bookCopy, Member member)
        {
            Loan loan = new Loan()
            {
                BookCopy = bookCopy,
                Member = member,
                TimeOfLoan = DateTime.Now,
                DueDate = DateTime.Now.AddSeconds(10),
                TimeOfReturn = null
            };
            Add(loan);
        }

        public IEnumerable<BookCopy> FindBookCopiesOnLoan(IEnumerable<BookCopy> bookCopies)
        {
            //var bookCopies = book.BookCopies.ToList();
            IEnumerable <Loan> loans = loanRepository.All().ToList();

            return bookCopies.Join(loans, bc => bc.BookCopyId, l => l.BookCopy.BookCopyId, (bookCopy, loan) => new { BookCopy = bookCopy, Loan = loan }).Where(l => l.Loan.TimeOfLoan > l.Loan.TimeOfReturn || (l.Loan.TimeOfReturn == null && l.Loan.TimeOfLoan < DateTime.Now)).Select(bc => bc.BookCopy);
        }
        /// <summary>
        /// Sets the loans time of return to now
        /// </summary>
        /// <param name="member"></param>
        /// <param name="selectedLoan"></param>
        public void ReturnBook(Member member, Loan selectedLoan)
        {
            //var loan = member.Loans.Select(l => l).Where(l => l.BookCopy.BookCopyId == selectedLoan.BookCopy.BookCopyId).OrderByDescending(l => l.TimeOfLoan).FirstOrDefault();
            var loan = member.Loans.Where(l => l.LoanId == selectedLoan.LoanId).Select(l => l).FirstOrDefault();
            if (loan.DueDate < DateTime.Now)
            {
                CalculatePrice(loan);
            }
            loan.TimeOfReturn = DateTime.Now;
            loanRepository.Edit(loan);
            OnUpdated(this, eventArgs);
            CreateReturnenLoan(loan);

            Remove(loan);
        }

        private void CreateReturnenLoan(Loan loan)
        {
            ReturnedLoan returned = new ReturnedLoan()
            {
                BookCopyId = loan.BookCopy.BookCopyId,
                TimeOfLoan = loan.TimeOfLoan,
                TimeOfReturn = loan.TimeOfReturn,
                MemberId = loan.Member.MemberId,
                DueDate = loan.DueDate
            };
            returnedLoanRepository.Add(returned);
        }

        private int CalculatePrice(Loan loan)
        {
                int days = DateTime.Now.Day - loan.DueDate.Day;
            
            return days * 10;
        }

        public IEnumerable<BookCopy> FindAllAvailableBooks(IEnumerable<BookCopy> bookCopies, IEnumerable<Loan> loans)
        {
            //var skit = loans.ToList();
            var loanedBookCopies = loans.Select(l => l.BookCopy).ToList();
            var availableBooks = bookCopies.Where(bc => !loanedBookCopies.Any(lbc => lbc.BookCopyId == bc.BookCopyId)).ToList();

            return availableBooks;
        }

        public IEnumerable<BookCopy> FindAllOverdueBooks( IEnumerable<Loan> loans)
        {
            return loans.Where(l => l.DueDate > DateTime.Now && l.TimeOfReturn == null).Select(l => l.BookCopy).ToList();
        }
    }
}
