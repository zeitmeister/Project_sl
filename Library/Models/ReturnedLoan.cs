using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class ReturnedLoan
    {
        public int ReturnedLoanId { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        
        public BookCopy BookCopy { get; set; }
        [Required]
        public Member Member { get; set; }

        public override string ToString()
        {
            return String.Format("{0} Was booked on: {1} and returned on",this.TimeOfLoan, this.TimeOfReturn);
        }
    }
}
