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

        public IEnumerable<Book> FindHistory(Member member)
        {
            var bookcopy = bookCopyRepository.All().ToList();
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            var join = selectedMember.Join(returnedLoanService.All(), sm => sm.MemberId, rls => rls.MemberId, (s, l) => new { Test = s.Name, TestTest = l.BookCopyId});
            var joinjoin = join.Join(bookcopy, jj => jj.TestTest, bc => bc.BookCopyId, (apa, kapa) => new { fitta = apa.Test, britta = kapa.Book });
            return joinjoin.Select(KLAR => KLAR.britta);
            /*var bookcopy = bookCopyService.All();
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            var fajt = selectedMember.Select(lp => lp.ReturnedLoans);
            var testjoin = fajt.Join(bookcopy, sm => sm.BookCopyId, bc => bc.BookCopyId, (s, b) => new { testest = s.PersonId, Namn = b.Book });
            
            var returnedloan = returnedLoanService.All();
            var join = bookcopy.Join(returnedloan, bc => bc.BookCopyId, rl => rl.BookCopyId, (b, r) => new { Name = b.Book, Id = r.BookCopyId }).Join(memberRepository.All().;
            var galje = join.Select(jh => jh.Name);
            //var kalle = alla.Join(hej, a => a.BookCopyId, h => h.BookCopyId, (a, h) => new { BookCopy = a, ReturnedLoan = h });
            
            var bög = selectedMember.Select(e => e.Loans.Where(asd => asd.BookCopy == galje));
            return bög;
            //var kalle = selectedMember.Select(bc => bc.ReturnedLoans.Where(x => x.BookCopyId == alla.Select(gh => gh.BookCopyId).ToList())*/

        }
    }
}
