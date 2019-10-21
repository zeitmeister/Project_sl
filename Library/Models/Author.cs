using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
