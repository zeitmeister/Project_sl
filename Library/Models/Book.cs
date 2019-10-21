using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {

<<<<<<< HEAD
        private Author _author = new Author();

        public int BookId { get; set; }

        public string ISBN { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCopy> BookCopies { get; set; }
=======
        public int BookId { get; set; }
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
        public string Title { get; set; }

        public Book()
        {
            _author.Books.Add(this);
            BookCopies = new List<BookCopy>();
        }

        public void AddToCopyList(int condition)
        {

        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString() {
            return String.Format("[{0}] -- {1}", this.BookId, this.Title);
        }
    }
}