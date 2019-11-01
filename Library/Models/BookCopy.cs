using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library.Models
{
    
    public class BookCopy
    {
        public int Id { get; set; }

        public Book Book { get; set; }
        
        public int Condition { get; set; }


        public override string ToString()
        {
            try
            {
                return String.Format("[{0}] -- {1} is in condition {2}",this.Id, this.Book.Title, this.Condition);
            } catch(NullReferenceException e)
            {
                return e.Message;
            }

            
        }

        
    }
}
