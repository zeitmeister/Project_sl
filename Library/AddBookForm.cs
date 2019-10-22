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
        public AddBookForm (BookService bookService)
        {
            BS = bookService;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                ISBN = txt_ISBN.Text,
                Title = txt_Title.Text,
                Description = txt_Description.Text,
                Author = new Author
                {
                    Name = txt_Author.Text
                }
            };
            BS.Add(book);
        }

        private void txt_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
