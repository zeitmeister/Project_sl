using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class MemberService : IService
    {
        MemberRepository memberRepository;
        BookCopyService bookCopyService;
        ReturnedLoanService returnedLoanService;
        BookCopyRepository bookCopyRepository;
        

        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        protected virtual void OnUpdated(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
            }
        }

        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        public void Add(Member member)
        {
            memberRepository.Add(member);
            OnUpdated(this, eventArgs);
        }

        public void Remove(Member member)
        {
            memberRepository.Remove(member);
            OnUpdated(this, eventArgs);
        }

        public Member Find(int id)
        {
            return memberRepository.Find(id);
        }

        public IEnumerable<Loan> FindAllBooksOnLoanForMember(Member member)
        {
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            return selectedMember.SelectMany(l => l.Loans).Where(l => l.TimeOfLoan > l.TimeOfReturn || (l.TimeOfReturn == null && l.TimeOfLoan < DateTime.Now));
        }

        public IEnumerable<Loan> FindAllReturnedBooks(Member member)
        {
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            return selectedMember.SelectMany(l => l.Loans).Where(l => l.TimeOfReturn > l.TimeOfLoan);
        }

        public IEnumerable<BookCopy> FindHistory(Member member)
        {
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            var jappa = selectedMember.SelectMany(sm => sm.ReturnedLoans).Select(asdf => asdf.BookCopy);
            return jappa;
           
        }
    }
}
