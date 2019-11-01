﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }
        public BookCopy BookCopy { get; set; }
        public Member Member { get; set; }

        public override string ToString()
        {

            try
            {
                return String.Format("[{0}] -- {1} is on loan.", this.Id, this.BookCopy.Book.Title); 
            }
            catch(NullReferenceException ex)
            {
                return ex.Message;
            }
                

        }
    }
}
