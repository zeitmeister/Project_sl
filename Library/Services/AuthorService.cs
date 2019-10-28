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
    /// Contains the logic for situations regarding authors.
    /// </summary>
    public class AuthorService : BaseService, IService
    {
        AuthorRepository authorRepository;
        
        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        public AuthorService(RepositoryFactory rFactory)
        {
            authorRepository = rFactory.CreateAuthorRepository();
        }

        protected virtual void OnUpdated(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
                //Testar
            }
        }

        /// <summary>
        /// Adds an author to the repository
        /// </summary>
        /// <param name="author">The author to add</param>
        public void Add(Author author)
        {
            authorRepository.Add(author);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Returns all authors from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        /// <summary>
        /// Finds a specific author given its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An author.</returns>
        public Author Find(int id)
        {
            return authorRepository.Find(id);
        }

        /// <summary>
        /// Removes an author from the repository
        /// </summary>
        /// <param name="author">The author to remove</param>
        public void Remove (Author author)
        {
            authorRepository.Remove(author);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Finds all books that's written by an author
        /// </summary>
        /// <param name="author">The author</param>
        /// <returns>Books written by the author</returns>
        public IEnumerable<Book> BookByAuthor (Author author)
        {
            if (IsObjectNotNull(author))
            {
                var books = authorRepository.All().Where(a => a.Id == author.Id).SelectMany(b => b.Books);
                return books;
            }
            throw new ArgumentNullException("No author selected");
        }

    }
}
