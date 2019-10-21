﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Loan
    {
        public int LoadId { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TimeOfReturn { get; set; }
        public BookCopy BookCopy { get; set; }
        public Member Member { get; set; }
    }
}
