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

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            var author = AS.All().Where(a => a.Name == txt_Author.Text).FirstOrDefault();
            if (author != null)
            {
                Book book = new Book()
                {
                    ISBN = txt_ISBN.Text,
                    Title = txt_Title.Text,
                    Description = txt_Description.Text,
                    Author = author
                };
                BS.Add(book);
            }
            else
            {
                Author author2 = new Author()
                {
                    Name = txt_Author.Text
                };
                Book book = new Book()
                {
                    ISBN = txt_ISBN.Text,
                    Title = txt_Title.Text,
                    Description = txt_Description.Text,
                    Author = author2
                };
                AS.Add(author2);
                BS.Add(book);
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
