using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService : IService
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

        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        public void Add(Book book)
        {
            bookRepository.Add(book);
            OnUpdated(this, eventArgs);
        }

        public void Remove(Book book)
        {
            bookRepository.Remove(book);
            OnUpdated(this, eventArgs);
        }

        public Book Find(int id)
        {
            return bookRepository.Find(id);
        }

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
    }
}
