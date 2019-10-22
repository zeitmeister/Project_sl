namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.BTNChangeBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.Add_BookCopy = new System.Windows.Forms.Button();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.lblBookCopies = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.txtBox_AddAuthor = new System.Windows.Forms.TextBox();
            this.lb_BooksByAuthor = new System.Windows.Forms.ListBox();
            this.btn_ViewBooks = new System.Windows.Forms.Button();
            this.lb_Member = new System.Windows.Forms.ListBox();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.btn_MakeLoan = new System.Windows.Forms.Button();
            this.btn_FindLoanedBooks = new System.Windows.Forms.Button();
            this.lb_LoanedBooks = new System.Windows.Forms.ListBox();
            this.btn_FindLoansForMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 20;
            this.lbBooks.Location = new System.Drawing.Point(18, 18);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(644, 364);
            this.lbBooks.TabIndex = 0;
            // 
            // BTNChangeBook
            // 
            this.BTNChangeBook.Location = new System.Drawing.Point(672, 34);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(122, 91);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(672, 278);
            this.deleteBookBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(112, 35);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.Text = "Delete book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // Add_BookCopy
            // 
            this.Add_BookCopy.Location = new System.Drawing.Point(672, 673);
            this.Add_BookCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_BookCopy.Name = "Add_BookCopy";
            this.Add_BookCopy.Size = new System.Drawing.Size(226, 62);
            this.Add_BookCopy.TabIndex = 4;
            this.Add_BookCopy.Text = "Add BookCopy";
            this.Add_BookCopy.UseVisualStyleBackColor = true;
            this.Add_BookCopy.Click += new System.EventHandler(this.Add_BookCopy_Click);
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.ItemHeight = 20;
            this.lbBookCopies.Location = new System.Drawing.Point(18, 592);
            this.lbBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(644, 364);
            this.lbBookCopies.TabIndex = 5;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Location = new System.Drawing.Point(18, 568);
            this.lblBookCopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(51, 20);
            this.lblBookCopies.TabIndex = 6;
            this.lblBookCopies.Text = "label1";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(672, 425);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(183, 52);
            this.btnAddAuthor.TabIndex = 7;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.ItemHeight = 20;
            this.lbAuthors.Location = new System.Drawing.Point(12, 446);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(640, 84);
            this.lbAuthors.TabIndex = 8;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // txtBox_AddAuthor
            // 
            this.txtBox_AddAuthor.Location = new System.Drawing.Point(862, 437);
            this.txtBox_AddAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_AddAuthor.Name = "txtBox_AddAuthor";
            this.txtBox_AddAuthor.Size = new System.Drawing.Size(148, 26);
            this.txtBox_AddAuthor.TabIndex = 9;
            this.txtBox_AddAuthor.TextChanged += new System.EventHandler(this.txtBox_AddAuthor_TextChanged);
            // 
            // lb_BooksByAuthor
            // 
            this.lb_BooksByAuthor.FormattingEnabled = true;
            this.lb_BooksByAuthor.ItemHeight = 20;
            this.lb_BooksByAuthor.Location = new System.Drawing.Point(885, 34);
            this.lb_BooksByAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_BooksByAuthor.Name = "lb_BooksByAuthor";
            this.lb_BooksByAuthor.Size = new System.Drawing.Size(409, 364);
            this.lb_BooksByAuthor.TabIndex = 10;
            this.lb_BooksByAuthor.SelectedIndexChanged += new System.EventHandler(this.lb_BooksByAuthor_SelectedIndexChanged);
            // 
            // btn_ViewBooks
            // 
            this.btn_ViewBooks.Location = new System.Drawing.Point(672, 497);
            this.btn_ViewBooks.Name = "btn_ViewBooks";
            this.btn_ViewBooks.Size = new System.Drawing.Size(183, 52);
            this.btn_ViewBooks.TabIndex = 11;
            this.btn_ViewBooks.Text = "View books by selected author";
            this.btn_ViewBooks.UseVisualStyleBackColor = true;
            this.btn_ViewBooks.Click += new System.EventHandler(this.btn_ViewBooks_Click);
            // 
            // lb_Member
            // 
            this.lb_Member.FormattingEnabled = true;
            this.lb_Member.ItemHeight = 20;
            this.lb_Member.Location = new System.Drawing.Point(862, 471);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(243, 84);
            this.lb_Member.TabIndex = 12;
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Location = new System.Drawing.Point(957, 582);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(148, 47);
            this.btn_AddMember.TabIndex = 13;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // btn_MakeLoan
            // 
            this.btn_MakeLoan.Location = new System.Drawing.Point(1148, 419);
            this.btn_MakeLoan.Name = "btn_MakeLoan";
            this.btn_MakeLoan.Size = new System.Drawing.Size(146, 63);
            this.btn_MakeLoan.TabIndex = 14;
            this.btn_MakeLoan.Text = "Make Loan";
            this.btn_MakeLoan.UseVisualStyleBackColor = true;
            this.btn_MakeLoan.Click += new System.EventHandler(this.btn_MakeLoan_Click);
            // 
            // btn_FindLoanedBooks
            // 
            this.btn_FindLoanedBooks.Location = new System.Drawing.Point(1148, 501);
            this.btn_FindLoanedBooks.Name = "btn_FindLoanedBooks";
            this.btn_FindLoanedBooks.Size = new System.Drawing.Size(174, 45);
            this.btn_FindLoanedBooks.TabIndex = 15;
            this.btn_FindLoanedBooks.Text = "Find Loaned Books";
            this.btn_FindLoanedBooks.UseVisualStyleBackColor = true;
            this.btn_FindLoanedBooks.Click += new System.EventHandler(this.btn_FindLoanedBooks_Click);
            // 
            // lb_LoanedBooks
            // 
            this.lb_LoanedBooks.FormattingEnabled = true;
            this.lb_LoanedBooks.ItemHeight = 20;
            this.lb_LoanedBooks.Location = new System.Drawing.Point(957, 653);
            this.lb_LoanedBooks.Name = "lb_LoanedBooks";
            this.lb_LoanedBooks.Size = new System.Drawing.Size(365, 84);
            this.lb_LoanedBooks.TabIndex = 16;
            // 
            // btn_FindLoansForMember
            // 
            this.btn_FindLoansForMember.Location = new System.Drawing.Point(1148, 573);
            this.btn_FindLoansForMember.Name = "btn_FindLoansForMember";
            this.btn_FindLoansForMember.Size = new System.Drawing.Size(164, 65);
            this.btn_FindLoansForMember.TabIndex = 17;
            this.btn_FindLoansForMember.Text = "Find Loans for Member";
            this.btn_FindLoansForMember.UseVisualStyleBackColor = true;
            this.btn_FindLoansForMember.Click += new System.EventHandler(this.btn_FindLoansForMember_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_FindLoansForMember);
            this.Controls.Add(this.lb_LoanedBooks);
            this.Controls.Add(this.btn_FindLoanedBooks);
            this.Controls.Add(this.btn_MakeLoan);
            this.Controls.Add(this.btn_AddMember);
            this.Controls.Add(this.lb_Member);
            this.Controls.Add(this.btn_ViewBooks);
            this.Controls.Add(this.lb_BooksByAuthor);
            this.Controls.Add(this.txtBox_AddAuthor);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.lbBookCopies);
            this.Controls.Add(this.Add_BookCopy);
            this.Controls.Add(this.deleteBookBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryForm";
            this.Text = "7";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button Add_BookCopy;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.Label lblBookCopies;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.TextBox txtBox_AddAuthor;
        private System.Windows.Forms.ListBox lb_BooksByAuthor;
        private System.Windows.Forms.Button btn_ViewBooks;
        private System.Windows.Forms.ListBox lb_Member;
        private System.Windows.Forms.Button btn_AddMember;
        private System.Windows.Forms.Button btn_MakeLoan;
        private System.Windows.Forms.Button btn_FindLoanedBooks;
        private System.Windows.Forms.ListBox lb_LoanedBooks;
        private System.Windows.Forms.Button btn_FindLoansForMember;
    }
}

