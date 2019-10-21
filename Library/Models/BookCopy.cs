using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCopy
    {
        public int BookCopyId { get; set; }

        public Book Book { get; set; }
        
        public int Condition { get; set; }


        public override string ToString()
        {
            return String.Format("{0} is in condition {1}", this.Book.Title, this.Condition);
        }
    }
}
