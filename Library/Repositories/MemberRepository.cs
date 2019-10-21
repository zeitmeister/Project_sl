using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        public void Add(Member item)
        {
            context.Member.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<Member> All()
        {
            return context.Member;
        }

        public void Edit(Member item)
        {
            context.SaveChanges();
        }

        public Member Find(int id)
        {
            return context.Member.Where(m => m.MemberId == id) as Member;
        }

        public void Remove(Member item)
        {
            context.Member.Remove(item);
            context.SaveChanges();
        }
    }
}
