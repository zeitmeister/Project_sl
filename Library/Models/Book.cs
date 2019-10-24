using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCopy> BookCopies { get; set; }
        public string Title { get; set; }

        public Book()
        {
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