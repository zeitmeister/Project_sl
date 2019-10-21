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
    }
}
