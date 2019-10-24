using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class ReturnedLoanRepository : IRepository<ReturnedLoan, int>
    {
        LibraryContext context;

        public ReturnedLoanRepository(LibraryContext c)
        {
            context = c;
        }
        public void Add(ReturnedLoan item)
        {
            context.ReturnedLoans.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<ReturnedLoan> All()
        {
            throw new NotImplementedException();
        }

        public void Edit(ReturnedLoan item)
        {
            throw new NotImplementedException();
        }

        public ReturnedLoan Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ReturnedLoan item)
        {
            throw new NotImplementedException();
        }
    }
}
