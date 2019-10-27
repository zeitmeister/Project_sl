using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService : IService
    {
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

        public void Add(BookCopy bookCopy)
        {
            bookCopyRepository.Add(bookCopy);
            OnUpdated(this, eventArgs);
        }

        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        public IEnumerable<BookCopy> SpecificBookCopies(Book book)
        {
            return bookCopyRepository.SpecificBookCopies(book);
        }

        public void Remove(BookCopy bookCopy)
        {
            bookCopyRepository.Remove(bookCopy);
            OnUpdated(this, eventArgs);

        }

        public BookCopy Find(BookCopy bookCopy)
        {
            return bookCopyRepository.Find(bookCopy.Id);
        }

        public bool IsObjectNotNull(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
