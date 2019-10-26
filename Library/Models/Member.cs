using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Library.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfMembership { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<ReturnedLoan> ReturnedLoans { get; set; }

        public Member()
        {
            ReturnedLoans = new List<ReturnedLoan>();
            Loans = new List<Loan>();
            
        }

        public override string ToString()
        {
            return String.Format("{0} became member on: {1}", this.Name, this.DateOfMembership);
        }

    }
}
