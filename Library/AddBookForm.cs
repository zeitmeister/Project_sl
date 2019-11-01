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
using Library.Models;

namespace Library
{
    /// <summary>
    /// The form that let a user add a book.
    /// </summary>
    public partial class AddBookForm : Form
    {
        BookService BS;
        AuthorService AS;
        
        public AddBookForm (BookService bookService, AuthorService authorService)
        {
            BS = bookService;
            AS = authorService;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        /// <summary>
        /// The button that adds the book and check all the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            var author = AS.All().Where(a => a.Name == txt_Author.Text.Trim()).FirstOrDefault();
            if (txt_ISBN.Text.Trim() == "" || txt_Title.Text.Trim() == "" || txt_Description.Text.Trim() == "" || txt_Author.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all the fields.");
            }
            else if (BS.BookAlreadyExists(txt_ISBN.Text.Trim()))
            {
                MessageBox.Show("This Book already exists");
            }
            else
            {
                if (author != null)
                {
                    Book book = new Book()
                    {
                        ISBN = txt_ISBN.Text.Trim(),
                        Title = txt_Title.Text.Trim(),
                        Description = txt_Description.Text.Trim(),
                        Author = author
                    };
                    try
                    {
                        BS.Add(book);
                    } catch (ArgumentNullException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    Author author2 = new Author()
                    {
                        Name = txt_Author.Text.Trim()
                    };
                    Book book = new Book()
                    {
                        ISBN = txt_ISBN.Text.Trim(),
                        Title = txt_Title.Text.Trim(),
                        Description = txt_Description.Text.Trim(),
                        Author = author2
                    };
                    AS.Add(author2);
                    BS.Add(book);
                    this.Close();
                }
            }
            
        }

        private void txt_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
