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
    /// Contains the logic for situations regarding book copies.
    /// </summary>
    public class BookCopyService : IService
    {
        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        BookCopyRepository bookCopyRepository;
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
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
        /// Adds a BookCopy to the repository and raises the Updated-event.
        /// </summary>
        /// <param name="bookCopy"></param>
        public void Add(BookCopy bookCopy)
        {
            bookCopyRepository.Add(bookCopy);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Gets all the BookCopies from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        public IEnumerable<BookCopy> SpecificBookCopies(Book book)
        {
            return bookCopyRepository.SpecificBookCopies(book);
        }

        /// <summary>
        /// Removes a specific BookCopy from the repository
        /// </summary>
        /// <param name="bookCopy">The BookCopy to remove</param>
        public void Remove(BookCopy bookCopy)
        {
            bookCopyRepository.Remove(bookCopy);
            OnUpdated(this, eventArgs);
        }


        /// <summary>
        /// Finds a specific BookCopy given an Id
        /// </summary>
        /// <param name="bookCopy"></param>
        /// <returns>A bookCopy with the Id provided</returns>
        public BookCopy Find(BookCopy bookCopy)
        {
            return bookCopyRepository.Find(bookCopy.Id);
        }
    }
}
