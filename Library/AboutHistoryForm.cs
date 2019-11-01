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
    /// The from that show details about a book that has been on loan.
    /// </summary>
    public partial class AboutHistoryForm : Form
    {
        ReturnedLoan RL;
        ReturnedLoanService RLS;
        /// <summary>
        /// Sets the fields to their proper values.
        /// </summary>
        /// <param name="returnedLoan"></param>
        /// <param name="returnedLoanService"></param>
        public AboutHistoryForm(ReturnedLoan returnedLoan, ReturnedLoanService returnedLoanService)
        {
            RLS = returnedLoanService;
            RL = returnedLoan;
            InitializeComponent();
            lbl_BookTitle.Text = RL.BookCopy.Book.Title;

            txt_TimeOfLoan.Text = RL.TimeOfLoan.ToString();
            txt_TimeOfReturn.Text = RL.TimeOfReturn.ToString();
        }

        private void btn_AboutBook_Click(object sender, EventArgs e)
        {
            AboutBookForm aboutBookForm = new AboutBookForm(RL.BookCopy.Book);
            aboutBookForm.Show(); 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
