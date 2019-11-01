﻿using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    public partial class LibraryForm : Form
    {
        BookService bookService;
        BookCopyService copyService;
        AuthorService authorService;
        MemberService memberService;
        LoanService loanService;
        ReturnedLoanService returnedLoanService;

        public LibraryForm()
        {
            InitializeComponent();
            
            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            bookService = new BookService(repFactory);
            copyService = new BookCopyService(repFactory);
            authorService = new AuthorService(repFactory);
            memberService = new MemberService(repFactory);
            returnedLoanService = new ReturnedLoanService(repFactory);
            loanService = new LoanService(repFactory, returnedLoanService);
            
            ShowAllBooks(bookService.All());
            ShowAllBookCopies(copyService.All());
            ShowAllMembers(memberService.All());
            ShowAllAuthors(authorService.All());
            ShowAllLoans(loanService.All());
            ShowAllAvailableBooks(copyService.All(), loanService.All());
            ShowAllOverDueBooks(copyService.All());
            
            bookService.Updated += BookService_Updated;
            authorService.Updated += AuthorService_Updated;
            copyService.Updated += CopyService_Updated;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
        }

        /// <summary>
        /// OnLoad starts a timer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        /// <summary>
        /// Calls the backgroundworker everytime the timer interval (2000 ms) hits. Backgroundworker is here devided in two tasks: DoWork and RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        /// <summary>
        /// The second runworker-method. Calls the ShowAllOverdueBooks-function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            ShowAllOverDueBooks(copyService.All());

        }

        /// <summary>
        /// The first runworker-method. Sleeps the thread for 2 seconds. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAllLoans(loanService.FindAllBooksOnLoan());
            ShowAllAvailableBooks(copyService.All(), loanService.All());
            ShowAllOverDueBooks(copyService.All());
        }


        private void ShowAllOverDueBooks(IEnumerable<BookCopy> bookCopies)
        {
            lb_OverdueBooks.Items.Clear();
            foreach (var item in loanService.FindAllOverdueBooks(loanService.All()))
            {
                lb_OverdueBooks.Items.Add(item);
            }
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void CopyService_Updated(object sender, EventArgs e)
        {
            ShowAllBookCopies(copyService.All());
            ShowAllAvailableBooks(copyService.All(), loanService.All());
        }

        private void ShowAllAvailableBooks(IEnumerable<BookCopy> bookCopies, IEnumerable<Loan> loans)
        {
            lb_AvailableBooks.Items.Clear();
            foreach (var availableBook in loanService.FindAllAvailableBooks(bookCopies, loans))
            {
                lb_AvailableBooks.Items.Add(availableBook);
            }
        }

        private void AuthorService_Updated(object sender, EventArgs e)
        {
            ShowAllAuthors(authorService.All());
        }

        private void BookService_Updated(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All());
        }

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lbAuthors.Items.Add(author);
            }
        }

        private void ShowAllBookCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbBookCopies.Items.Clear();
            foreach (var bookCopy in bookCopies)
            {
                lbBookCopies.Items.Add(bookCopy);
            }
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lb_Member.Items.Clear();
            lb_MemberCopy.Items.Clear();
            foreach (var member in members)
            {
                lb_Member.Items.Add(member);
                lb_MemberCopy.Items.Add(member);
            }
        }

        private void ShowAllLoans(IEnumerable<Loan> Loans)
        {
            lb_LoanedBooks.Items.Clear();
            foreach (var loan in Loans)
            {
                lb_LoanedBooks.Items.Add(loan);
            }
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(bookService, authorService);
            addBookForm.Show();
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {

            if (lbBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book you would like to delete.");
            }
            else if (bookService.BookHasBookCopies(lbBooks.SelectedItem as Book))
            {
                MessageBox.Show("You have to remove all the bookcopies related to the book before you can delete the book.");
            }
            else
            bookService.Remove(lbBooks.SelectedItem as Book);
        }

        private void Add_BookCopy_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to be able to create a book copy.");
            }
            else
            {
                AddBookCopyForm AddBookCopyForm = new AddBookCopyForm(lbBooks.SelectedItem as Book, copyService);
                AddBookCopyForm.Show();
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (txtBox_AddAuthor.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an author.");
            }
            else
            {
                Author author = new Author()
                {
                    Name = txtBox_AddAuthor.Text.Trim()
                };
                authorService.Add(author);
            }
        }

        private void btn_ViewBooks_Click(object sender, EventArgs e)
        {
            lb_BooksByAuthor.Items.Clear();
            var authorSelected = lbAuthors.SelectedItem as Author;
            try
            {
                foreach (var item in authorService.BookByAuthor(authorSelected))
                {
                    lb_BooksByAuthor.Items.Add(item);
                }
            } catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            AddNewMemberForm addNewMemberForm = new AddNewMemberForm(memberService);
            addNewMemberForm.Show();
        }

        private void btn_MakeLoan_Click(object sender, EventArgs e)
        {
            if (lb_AvailableBooks.SelectedItem == null || lb_Member.SelectedItem == null)
            {
                MessageBox.Show("Please select a book from 'Availible books' and a member to be able to make the loan.");
            }
            else

            loanService.MakeLoan(lb_AvailableBooks.SelectedItem as BookCopy, lb_Member.SelectedItem as Member);
        }

        /// <summary>
        /// Finds all currently books on loan, books that have been loaned
        /// and calls the function that show books that are overdue for a specific member.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FindLoansForMember_Click(object sender, EventArgs e)
        {
            lb_History.Items.Clear();
            lb_LoansForMember.Items.Clear();
            lb_OverdueBooksForMember.Items.Clear();

            var member = lb_MemberCopy.SelectedItem as Member;
            if (member == null)
            {
                MessageBox.Show("Please select a member to able to show which books they have on loan");
            }
            else
            {
                    foreach (var loan in memberService.FindAllBooksOnLoanForMember(member))
                    {
                        lb_LoansForMember.Items.Add(loan);
                    }
                try 
                {
                    foreach (var item in memberService.FindHistory(member))
                    {
                        lb_History.Items.Add(item);
                    }
                } catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ShowAllOverdueBooksForMember(lb_MemberCopy.SelectedItem as Member);
            }
        }

        private void ShowAllOverdueBooksForMember(Member member)
        {
            member = lb_MemberCopy.SelectedItem as Member;
            foreach (var bookCopy in memberService.FindAllOverdueBooks(member))
            {
                lb_OverdueBooksForMember.Items.Add(bookCopy);
            }
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string message = loanService.ReturnBook(lb_LoanedBooks.SelectedItem as Loan);
                MessageBox.Show(message);
            } catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btn_FindAvailableBooks_Click(object sender, EventArgs e)
        {
            lbBookCopies.Items.Clear();
            foreach (var bookCopy in loanService.FindAllAvailableBooks(copyService.All(), loanService.All()))
            {
                lbBookCopies.Items.Add(bookCopy);
            }
        }


        private void btn_AboutBook_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to show detail about it.");
            }
            else
            {
                AboutBookForm aboutBookForm = new AboutBookForm(lbBooks.SelectedItem as Book);
                aboutBookForm.Show();
            }
        }

        private void btn_DeleteMember_Click(object sender, EventArgs e)
        {
            if (lb_MemberCopy.SelectedItem == null)
            {
                MessageBox.Show("Please select a member you would like to delete.");
            }
            else
            memberService.Remove(lb_MemberCopy.SelectedItem as Member);
            
        }

        private void btn_DeleteBookCopy_Click(object sender, EventArgs e)
        {
            var selected = lbBookCopies.SelectedItem as BookCopy;
 
            if (lbBookCopies.SelectedItem == null)
            {
                MessageBox.Show("Please select a book copy to delete it.");
            }
            else if (loanService.CheckIfBookIsOnLoan(selected))
            {
                MessageBox.Show("You can't remove a book copy that is on loan.");
            }
            else
            copyService.Remove(lbBookCopies.SelectedItem as BookCopy);
        }

        private void btn_FindMember_Click(object sender, EventArgs e)
        {
            var find = memberService.All().Where(m => m.Name == txt_FindMember.Text).Select(m => m.MemberId).FirstOrDefault();
            if (find == 0)
            {
                MessageBox.Show("Member could not be found.");
            }
            else
            {
                lb_MemberCopy.Items.Clear();
                var hejsan = memberService.Find(find);
                lb_MemberCopy.Items.Add(hejsan);
            }
        }

        private void btn_FindOverdueBooks_Click(object sender, EventArgs e)
        {
            ShowAllOverDueBooks(loanService.FindAllOverdueBooks(loanService.All()));
        }

        /// <summary>
        /// Finds details about a book that has been on loan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_HistoryDetails_Click(object sender, EventArgs e)
        {
            if (lb_History.SelectedItem == null)
            {
                MessageBox.Show("Please select a loan from the history to view its details.");
            }
            else
            {
                AboutHistoryForm aboutHistoryForm = new AboutHistoryForm(lb_History.SelectedItem as ReturnedLoan, returnedLoanService);
                aboutHistoryForm.Show();
            } 
        }

        private void btn_ShowAllMembers_Click(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        /// <summary>
        /// Sets a loan a month back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EditLoan_Click(object sender, EventArgs e)
        {
            try
            {
                Loan loan = lb_LoanedBooks.SelectedItem as Loan;
                loan.TimeOfLoan = DateTime.Now.AddDays(-30);
                loan.DueDate = loan.TimeOfLoan.AddDays(15);
                loanService.Edit(loan);
            } catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            } catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    } 
}

