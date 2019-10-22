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

            ShowAllBooks(bookService.All());

            bookService.Updated += BookService_Updated;
            authorService.Updated += AuthorService_Updated;
            copyService.Updated += CopyService_Updated;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAllLoans(loanService.All());
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void CopyService_Updated(object sender, EventArgs e)
        {
            ShowAllBookCopies(copyService.All());
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
            foreach (var member in members)
            {
                lb_Member.Items.Add(member);
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
            bookService.Remove(lbBooks.SelectedItem as Book);
        }

        private void Add_BookCopy_Click(object sender, EventArgs e)
        {
            AddBookCopyForm AddBookCopyForm = new AddBookCopyForm(lbBooks.SelectedItem as Book, copyService);
            AddBookCopyForm.Show();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Name = txtBox_AddAuthor.Text
            };
            authorService.Add(author);
        }

        private void btn_ViewBooks_Click(object sender, EventArgs e)
        {
            //Author author = new Author();
            var itemSelected = lbAuthors.SelectedItem as Author;
            
            foreach (var item in authorService.BookByAuthor(itemSelected))
            {
                lb_BooksByAuthor.Items.Add(item);
            }
        }

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            AddNewMemberForm addNewMemberForm = new AddNewMemberForm(memberService);
            addNewMemberForm.Show();
        }

        private void btn_MakeLoan_Click(object sender, EventArgs e)
        {
            loanService.MakeLoan(lbBookCopies.SelectedItem as BookCopy, lb_Member.SelectedItem as Member);
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_FindLoanedBooks_Click(object sender, EventArgs e)
        {
            var book = lbBooks.SelectedItem as Book;
            foreach (var loanedBook in loanService.FindBookCopiesOnLoan(book))
            {
                lb_LoanedBooks.Items.Add(loanedBook);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_FindLoansForMember_Click(object sender, EventArgs e)
        {
            lb_LoanedBooks.Items.Clear();
            var member = lb_Member.SelectedItem as Member;
            foreach (var loan in memberService.FindAllLoansForMember(member))
            {
                lb_LoanedBooks.Items.Add(loan.BookCopy);
            }
        }


        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            loanService.ReturnBook(lb_Member.SelectedItem as Member, lbBookCopies.SelectedItem as BookCopy);

        }
    } 
}
