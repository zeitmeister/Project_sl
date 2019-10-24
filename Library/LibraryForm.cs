using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private int i = 0;
        private int duration = 0;

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
            loanService = new LoanService(repFactory);
            returnedLoanService = new ReturnedLoanService(repFactory);

            //timer = new System.Windows.Forms.Timer();


            ShowAllBooks(bookService.All());
            ShowAllBookCopies(copyService.All());
            ShowAllMembers(memberService.All());
            ShowAllAuthors(authorService.All());
            ShowAllLoans(loanService.All());
            
            bookService.Updated += BookService_Updated;
            authorService.Updated += AuthorService_Updated;
            copyService.Updated += CopyService_Updated;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
            


            //RunWorker();
        }





                // pretend like this a really complex calculation going on eating up CPU time
                //System.Threading.Thread.Sleep(100);
            
        


        private void LoanService_Updated(object sender, EventArgs e)
        {
            //ShowAllLoans(loanService.All());
            ShowAllLoans(loanService.FindAllBooksOnLoan());
            //ShowLoanedBooksByMember(loanService.FindBookCopiesOnLoan());
            ShowAllAvailableBooks();
        }

        private void ShowLoanedBooksByMember(IEnumerable<Loan> loans)
        {
            lb_LoanedBooks.Items.Clear();
            foreach (var loan in loans)
            {
                lb_LoanedBooks.Items.Add(loan);
            };
        }

        private void ShowAllOverDueBooks(IEnumerable<BookCopy> bookCopies)
        {
            lb_OverdueBooks.Items.Clear();
            foreach (var item in bookCopies)
            {
                lb_OverdueBooks.Items.Add(item);
                //lb_OverdueBooks.Invoke(new Action(() => lb_OverdueBooks.Items.Add(item)));
            }
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void CopyService_Updated(object sender, EventArgs e)
        {
            ShowAllBookCopies(copyService.All());
            ShowAllAvailableBooks();
        }

        private void ShowAllAvailableBooks()
        {
            lb_AvailableBooks.Items.Clear();
            foreach (var availableBook in loanService.FindAllAvailableBooks(copyService.All(), loanService.All()))
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
            try
            {
                var itemSelected = lbAuthors.SelectedItem as Author;

                foreach (var item in authorService.BookByAuthor(itemSelected))
                {
                    lb_BooksByAuthor.Items.Add(item);
                }
            } catch(NullReferenceException ex)
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

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_FindLoanedBooks_Click(object sender, EventArgs e)
        {
            var book = lbBooks.SelectedItem as Book;
            foreach (var loanedBook in loanService.FindBookCopiesOnLoan(copyService.All()))
            {
                lb_LoanedBooks.Items.Add(loanedBook);
            }
        }


        private void btn_FindLoansForMember_Click(object sender, EventArgs e)
        {
            lb_History.Items.Clear();
            lb_LoansForMember.Items.Clear();
            if (lb_MemberCopy.SelectedItem == null)
            {
                MessageBox.Show("Please select a member to able to show which books they have on loan");
            }
            else
            {
                try
                {
                    var member = lb_MemberCopy.SelectedItem as Member;
                    foreach (var loan in memberService.FindAllBooksOnLoanForMember(member))
                    {
                        lb_LoansForMember.Items.Add(loan);
                    }
                } catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try 
                {
                    var member = lb_MemberCopy.SelectedItem as Member;
                    foreach (var item in memberService.FindHistory(member))
                    {
                        lb_History.Items.Add(item);
                    }
                } catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            if (lb_LoanedBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a loaned book to be able to return it.");
            }
            else
            loanService.ReturnBook(lb_LoanedBooks.SelectedItem as Loan);
        }

        private void btn_FindAvailableBooks_Click(object sender, EventArgs e)
        {
            lbBookCopies.Items.Clear();
            foreach (var bookCopy in loanService.FindAllAvailableBooks(copyService.All(), loanService.All()))
            {
                lbBookCopies.Items.Add(bookCopy);
            }
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_BooksByAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_Member_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (lbBookCopies.SelectedItem == null)
            {
                MessageBox.Show("Please select a book copy to delete it.");
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
                lb_MemberCopy.Items.Add(hejsan as Member);

                //lb_MemberCopy.Items.Clear();
                var member = memberService.Find(find);

                lb_MemberCopy.Items.Add(member);

            }
        }

        private void btn_FindOverdueBooks_Click(object sender, EventArgs e)
        {
            ShowAllOverDueBooks(loanService.FindAllOverdueBooks(loanService.All(), copyService.All()));
        }

        private void btn_HistoryDetails_Click(object sender, EventArgs e)
        {
            AboutHistoryForm aboutHistoryForm = new AboutHistoryForm(lb_History.SelectedItem as BookCopy, returnedLoanService);
            aboutHistoryForm.Show();
        }

        private void lb_History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}

