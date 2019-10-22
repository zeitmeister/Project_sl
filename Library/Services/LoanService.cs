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
                TimeOfReturn = DateTime.Now
            };
            loanRepository.Add(loan);
        }

        public IEnumerable<BookCopy> FindBookCopiesOnLoan(Book book)
        {
            var bookCopies = book.BookCopies.ToList();
            IEnumerable <Loan> loans = loanRepository.All().ToList();

            return bookCopies.Join(loans, bc => bc.BookCopyId, l => l.BookCopy.BookCopyId, (bookCopy, loan) => bookCopy);
        }

        public void ReturnBook(Member member, BookCopy bookCopy)
        {
            var loan = member.Loans.Select(l => l).Where(l => l.BookCopy.BookCopyId == bookCopy.BookCopyId).FirstOrDefault();
            if(loan.DueDate < DateTime.Now)
            {
                CalculatePrice(loan);
            }
            loan.TimeOfReturn = DateTime.Now;
            
        }

        private int CalculatePrice(Loan loan)
        {
            int days = DateTime.Now.Day - loan.DueDate.Day;
            return days * 10;
        }
    }
}
