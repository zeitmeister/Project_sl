using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// Contains the logic for situations regarding returned loans
    /// </summary>
    public class ReturnedLoanService : IService
    {
        ReturnedLoanRepository returnedLoanRepository;

        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
        public event EventHandler Updated;
        public ReturnedLoanService(RepositoryFactory repFactory)
        {
            returnedLoanRepository = repFactory.CreateReturnedLoanRepository();
        }

        /// <summary>
        /// Adds a returned loan to the database
        /// </summary>
        /// <param name="returnedLoan">The returned loan to add to the database</param>
        public void Add(ReturnedLoan returnedLoan)
        {
            returnedLoanRepository.Add(returnedLoan);
        }

        /// <summary>
        /// Returns all the returned loans from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReturnedLoan> All()
        {
            return returnedLoanRepository.All();
        }


    }
}
