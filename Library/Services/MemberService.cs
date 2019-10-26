using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    public class MemberService : BaseService, IService
    {
        MemberRepository memberRepository;
        BookCopyService bookCopyService;
        ReturnedLoanRepository returnedLoanRepository;
        BookCopyRepository bookCopyRepository;
        

        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
            this.returnedLoanRepository = rFactory.CreateReturnedLoanRepository();
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
            if (IsObjectNotNull(member))
            {

                var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId).FirstOrDefault();
                var result = selectedMember.Loans.Where(l => l.TimeOfLoan > l.TimeOfReturn || (l.TimeOfReturn == null && l.TimeOfLoan < DateTime.Now)).ToList();
                return result;
            }
            throw new ArgumentNullException("No member selected");
        }

        public IEnumerable<Loan> FindAllReturnedBooks(Member member)
        {
            var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId);
            return selectedMember.SelectMany(l => l.Loans).Where(l => l.TimeOfReturn > l.TimeOfLoan);
        }

        public IEnumerable<ReturnedLoan> FindHistory(Member member)
        {
            if (IsObjectNotNull(member))
            {
                var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId).FirstOrDefault();
                var result = returnedLoanRepository.All().Where(s => s.Member.MemberId == selectedMember.MemberId);
              
                if (result == null)
                {
                    throw new ArgumentNullException("bajs");
                }
                return result;
            }
            throw new ArgumentNullException("No member selected"); 
        }

        public IEnumerable<BookCopy> FindAllOverdueBooks(Member member)
        {
            var booksOverDueDate = member.Loans.Where(l => l.DueDate < DateTime.Now && l.TimeOfReturn == null).
                Select(l => l.BookCopy).ToList();
            return booksOverDueDate;
        }

        public bool MemberAlreadyExists(int personalId)
        {
            var AllPersonalId = memberRepository.All().Select(id => id.PersonId).ToList();

            if (AllPersonalId.Contains(personalId))
            {
                return true;
            }
            else
                return false;
        }
    }
}
