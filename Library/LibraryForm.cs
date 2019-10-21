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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {
        Form formPopup = new Form();
        BookService bookService;
        BookCopyService copyService;
        AuthorService authorService;
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
            ShowAllBooks(bookService.All());
            bookService.Updated += BookService_Updated;
            authorService.Updated += AuthorService_Updated;

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
        
        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            
            if (b != null)
            {
                b.Title = "Yoyoma koko";
                bookService.Edit(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book {
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = lbAuthors.SelectedItem as Author
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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Name = txtBox_AddAuthor.Text
            };
            authorService.Add(author);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_AddAuthor_TextChanged(object sender, EventArgs e)
        {

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

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_BooksByAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
