using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Models
{
    class Member
    {
        public int MemberId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfMembership { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public Member()
        {
            Loans = new List<Loan>();
        }

    }
}
