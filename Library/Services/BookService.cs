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
    /// Contains the logic for situations regarding books.
    /// </summary>
    public class BookService : BaseService, IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;
        
        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
        public event EventHandler Updated;
       
        private EventArgs eventArgs = new EventArgs();
        
        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
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
        /// Returns all the books from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        /// <summary>
        /// Adds a book to the repository and raises the Updated-event.
        /// </summary>
        /// <param name="book">The book to be added</param>
        public void Add(Book book)
        {   if (IsObjectNotNull(book))
            {
                bookRepository.Add(book);
                OnUpdated(this, eventArgs);
            }
            else
            {
                throw new ArgumentNullException("No book selected");
            }
        }

        /// <summary>
        /// Removes a book from the repository
        /// </summary>
        /// <param name="book">The book to be removed</param>
        public void Remove(Book book)
        {
            bookRepository.Remove(book);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Finds a specific book given its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The book with the ID provided</returns>
        public Book Find(int id)
        {
            return bookRepository.Find(id);
        }

        /// <summary>
        /// Finds all books that contains a certain input
        /// </summary>
        /// <param name="a">Input string</param>
        /// <returns>The books that matches the input</returns>
        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            return bookRepository.All().Where(b => b.Title.Contains(a));
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"></param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
            // TODO: Raise the Updated event.
        }

        /// <summary>
        /// Checks if a book has any book copies.
        /// </summary>
        /// <param name="book">The book to check for book copies for.</param>
        /// <returns>True if the book has book copies false otherwise.</returns>
        public bool BookHasBookCopies (Book book)
        {
            if (book.BookCopies.Count != 0)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Check if a book already exists
        /// </summary>
        /// <param name="ISBN">The ISBN string</param>
        /// <returns>True if the book already exists in the database</returns>
        public bool BookAlreadyExists (string ISBN)
        {
            var AllISBN = bookRepository.All().Select(isbn => isbn.ISBN).ToList();

            return AllISBN.Contains(ISBN);

        }
    }
}
