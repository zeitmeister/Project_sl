using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
<<<<<<< HEAD
        private List<Book> _books = new List<Book>();
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public List<Book> Books {
            get { return _books; }
            set { }
        }
=======
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
    }
}
