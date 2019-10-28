using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    /// <summary>
    /// Contains the logic for situations regarding Members
    /// </summary>
    public class MemberService : BaseService, IService
    {
        private MemberRepository memberRepository;
        private ReturnedLoanRepository returnedLoanRepository;

        /// <summary>
        /// The event that updates the GUI when the database has changed
        /// </summary>
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

        /// <summary>
        /// Returns all members from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Adds a member to the repository.
        /// </summary>
        /// <param name="member"></param>
        public void Add(Member member)
        {
            memberRepository.Add(member);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Removes a member from the repository.
        /// </summary>
        /// <param name="member">The member to remove</param>
        public void Remove(Member member)
        {
            memberRepository.Remove(member);
            OnUpdated(this, eventArgs);
        }

        /// <summary>
        /// Finds a specific member from the repository.
        /// </summary>
        /// <param name="id">The Id to search for.</param>
        /// <returns>A member</returns>
        public Member Find(int id)
        {
            return memberRepository.Find(id);
        }

        /// <summary>
        /// Returns all the active loans for a specific member
        /// </summary>
        /// <param name="member">The member to check for loans for.</param>
        /// <returns>A collection for loans.</returns>
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

        /// <summary>
        /// Finds all returned loans for a member
        /// </summary>
        /// <param name="member">The member to find returned loans for</param>
        /// <returns>A collection of returned loans</returns>
        public IEnumerable<ReturnedLoan> FindHistory(Member member)
        {
            if (IsObjectNotNull(member))
            {
                var selectedMember = memberRepository.All().Where(m => m.MemberId == member.MemberId).FirstOrDefault();
                var result = returnedLoanRepository.All().Where(s => s.Member.MemberId == selectedMember.MemberId);
              
                if (result == null)
                {
                    throw new ArgumentNullException("No result found");
                }
                return result;
            }
            throw new ArgumentNullException("No member selected"); 
        }

        /// <summary>
        /// Finds all the book copies that is overdue for a specific member
        /// </summary>
        /// <param name="member">The member to search for overdue books for.</param>
        /// <returns>A collection of overdue Book Copies</returns>
        public IEnumerable<BookCopy> FindAllOverdueBooks(Member member)
        {
            var booksOverDueDate = member.Loans.Where(l => l.DueDate < DateTime.Now && l.TimeOfReturn == null).
                Select(l => l.BookCopy).ToList();
            return booksOverDueDate;
        }

        /// <summary>
        /// Checks if a user with the same personal ID already exists.
        /// </summary>
        /// <param name="personalId">The ID to compare with the database</param>
        /// <returns>True if the member already exists, false otherwise.</returns>
        public bool MemberAlreadyExists(int personalId)
        {
            var AllPersonalId = memberRepository.All().Select(id => id.PersonId).ToList();

            return AllPersonalId.Contains(personalId);
          
        }
    }
}
