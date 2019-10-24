using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class ReturnedLoan
    {
        public int ReturnedLoanId { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        
        public int BookCopyId { get; set; }

        public int MemberId { get; set; }

    }
}
