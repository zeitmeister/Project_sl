using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository memberRepository;

        public event EventHandler Updated;

        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        public void Add(Member member)
        {
            memberRepository.Add(member);
            //OnUpdated(this, eventArgs);
        }

        public void Remove(Member member)
        {
            memberRepository.Remove(member);
            //OnUpdated(this, eventArgs);
        }

        public Member Find(int id)
        {
            return memberRepository.Find(id);
        }
    }
}
