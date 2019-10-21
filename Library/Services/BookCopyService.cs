using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookCopyService : IService
    {
        public event EventHandler Updated;

        BookCopyRepository bookCopyRepository;
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        public void Add(BookCopy bookCopy)
        {
            bookCopyRepository.Add(bookCopy);
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
            
        }

        public BookCopy Find(BookCopy bookCopy)
        {
            return bookCopyRepository.Find(bookCopy.BookCopyId);
        }

        public IEnumerable<BookCopy> FindBookCopiesOnLoan(Book book)
        {
            bookCopyRepository.All.
        }
    }
}
