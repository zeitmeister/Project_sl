using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class LoanService : IService
    {
        LoanRepository loanRepository;
        public event EventHandler Updated;

        public event EventHandler Returned;
        private EventArgs eventArgs = new EventArgs();

        public LoanService(RepositoryFactory repFactory)
        {
            loanRepository = repFactory.CreateLoanRepository();
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
                DueDate = DateTime.Now.AddDays(15),
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
            Remove(loan);
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


            /*var test = bookCopies.Join(loans,
                                    bc => bc.BookCopyId,
                                    l => l.BookCopy.BookCopyId,
                                    (bc, l) => new { BookCopy = bc, Loan = l })
                            .Where(lo => lo.Loan.TimeOfReturn > lo.Loan.TimeOfLoan).ToList();*/
            //.Select(bc => bc.BookCopy);

            //var cp = test.Select(l => l.Loan.BookCopy.BookCopyId).Count();
            //var test = loans.Where(l => l.TimeOfReturn > l.TimeOfLoan.Date).Count(l => l.BookCopy.BookCopyId > 1);
            //var test2 = test.Select(l => l.BookCopy);
            //var test2 = loans.Where(l => l.TimeOfReturn > l.TimeOfLoan);
            //var availableBooks2 = loans.Where(bc => !test2.Any(l => l.BookCopy.BookCopyId == bc.BookCopy.BookCopyId) || bc.TimeOfReturn > DateTime.Now).Select(l => l.BookCopy).ToList();
            //foreach (var item in availableBooks2)
            //{
            //    availableBooks.Add(item);
            //}
            //availableBooks.AddRange(test);
            return availableBooks;
        }
    }
}
