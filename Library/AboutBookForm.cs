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
using Library.Services;

namespace Library
{
    public partial class AboutBookForm : Form
    {
        Book b;
        public AboutBookForm(Book book)
        {
            b = book;
            InitializeComponent();
            lbl_BookTitle.Text = b.Title;
            lbl_BookISBNShow.Text = b.ISBN;
            txt_BookDescription.Text = b.Description;
        }
    }
}
