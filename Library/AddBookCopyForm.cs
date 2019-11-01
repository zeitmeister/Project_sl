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
    /// <summary>
    /// The form that let the user add a book copy.
    /// </summary>
    public partial class AddBookCopyForm : Form
    {
        BookCopyService BCS;
        Book selectedBook;

        public AddBookCopyForm(Book book, BookCopyService bookCopyService)
        {
            BCS = bookCopyService;
            selectedBook = book;
            InitializeComponent();
        }

        /// <summary>
        /// The button that adds the book copy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddBookCopy_Click(object sender, EventArgs e)
        {
            if (cb_Condition.SelectedItem == null)
            {
                MessageBox.Show("Please choose a condition from the list.");
            }
            else
            {
                int bookCondition;

                if (int.TryParse(cb_Condition.SelectedItem.ToString(), out bookCondition))
                {
                    BookCopy bookCopy = new BookCopy()
                    {
                        Book = selectedBook,
                        Condition = bookCondition
                    };
                    BCS.Add(bookCopy);
                }
            }  
        }

        private void AddBookCopyForm_Load(object sender, EventArgs e)
        {
            IEnumerable<int> conditions = Enumerable.Range(1, 10);
            foreach (var item in conditions)
            {
                cb_Condition.Items.Add(item);
            }
        }
    }
}
