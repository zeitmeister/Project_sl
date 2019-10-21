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
        Form formPopup = new Form();
        BookService bookService;
        BookCopyService copyService;
        public LibraryForm()
        {
            InitializeComponent();
            
            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            copyService = new BookCopyService(repFactory);
            ShowAllBooks(bookService.All());
            bookService.Updated += BookService_Updated;
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
        
        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            
            if (b != null)
            {
                b.Title = "Yoyoma koko";
                bookService.Edit(b);
            }
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book { 
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = new Author { Name = "J.K. Rowling" }
            };
            bookService.Add(book);
            /*book.AddToCopyList(8);
            book.AddToCopyList(2);
            book.AddToCopyList(1);
            book.AddToCopyList(9);
            foreach (var booktest in bookService.All())
            {
                foreach (var bookCopyTest in booktest.BookCopies)
                {
                    lbBooks.Items.Add(String.Format("{0} is in condition {1}", bookCopyTest.Book.Title, bookCopyTest.Condition));
                }
            }*/
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            bookService.Remove(lbBooks.SelectedItem as Book);
        }

        private void Add_BookCopy_Click(object sender, EventArgs e)
        {
            //formPopup.Show(this);
            lbBookCopies.Items.Clear();
            var book = lbBooks.SelectedItem as Book;         
            BookCopy bookCopy = new BookCopy()
            {
                Book = book,
                Condition = 8
            };
            copyService.Add(bookCopy);
            foreach (var copy in copyService.SpecificBookCopies(book))
            {
                lbBookCopies.Items.Add(copy);
            }
            lblBookCopies.Text = "We currently have " + book.BookCopies.Count() + " copies of " + book.Title;
        }
    } 
=======
        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.Title = "harry harry";
            bookService.Add(book);
        }
    }
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
}
