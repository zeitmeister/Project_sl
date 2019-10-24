﻿using System;
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
    public partial class AboutHistoryForm : Form
    {
        
        BookCopy BC;
        ReturnedLoanService RLS;
        public AboutHistoryForm(BookCopy bookcopy, ReturnedLoanService returnedLoanService)
        {
            RLS = returnedLoanService;
            BC = bookcopy;
            InitializeComponent();
            lbl_BookTitle.Text = BC.Book.Title;
            
            var selectedbook = RLS.All().Where(s => s.BookCopy == BC).Select(rls => rls.TimeOfLoan);
            

            /*var kalle = selectedbook.Select(b => b.TimeOfLoan);
            var balle = selectedbook.Select(c => c.TimeOfReturn);

            dtm_TimeOfLoan.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dtm_TimeOfReturn.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dtm_TimeOfLoan.Value = selectedbook;
            //var TimeOfLoan = selectedbook.Select(h => h.TimeOfLoan);
            //txt_Info.Text = balle.ToString() + ", " + kalle.ToString();
            //dateTimePicker1.Value = TimeOfLoan.First();*/
        }

        private void btn_AboutBook_Click(object sender, EventArgs e)
        {
            AboutBookForm aboutBookForm = new AboutBookForm(BC.Book);
            aboutBookForm.Show();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
