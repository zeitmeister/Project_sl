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

        public LoanService(RepositoryFactory repFactory)
        {
            loanRepository = repFactory.CreateLoanRepository();
        }

        public void Add(Loan loan)
        {
            loanRepository.Add(loan);
        }

        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        public void Remove(Loan loan)
        {
            loanRepository.Remove(loan);
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
            /* FRÅGA VARFÖR JOIN INTE FUNGERAR! */
            var bookCopies = book.BookCopies.ToList();
            IEnumerable <Loan> loans = loanRepository.All().ToList();
            return bookCopies.Join(loans, bc => bc.BookCopyId, l => l.BookCopy.BookCopyId, (bookCopy, loan) => bookCopy);
        }

    }
}
