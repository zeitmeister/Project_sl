using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        public LoanRepository(LibraryContext c)
        {
            context = c;
        }
        public void Add(Loan item)
        {
            context.Loans.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        public void Edit(Loan item)
        {
            context.SaveChanges();
        }

        public Loan Find(int id)
        {
            return context.Loans.Where(l => l.LoanId == id) as Loan;
        }

        public void Remove(Loan item)
        {
            context.Loans.Remove(item);
            context.SaveChanges();
        }
    }
}