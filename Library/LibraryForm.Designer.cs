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
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.Add_BookCopy = new System.Windows.Forms.Button();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.lblBookCopies = new System.Windows.Forms.Label();
            this.lb_Member = new System.Windows.Forms.ListBox();
            this.btn_MakeLoan = new System.Windows.Forms.Button();
            this.btn_FindLoanedBooks = new System.Windows.Forms.Button();
            this.lb_LoanedBooks = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.btn_FindAvailableBooks = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_BooksByAuthor = new System.Windows.Forms.ListBox();
            this.btn_ViewBooks = new System.Windows.Forms.Button();
            this.txtBox_AddAuthor = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_AvailableBooks = new System.Windows.Forms.ListBox();
            this.lb_MemberCopy = new System.Windows.Forms.ListBox();
            this.btn_FindLoansForMember = new System.Windows.Forms.Button();
            this.lb_LoansForMember = new System.Windows.Forms.ListBox();
            this.btn_AboutBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(21, 45);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(188, 173);
            this.lbBooks.TabIndex = 0;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(220, 45);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(69, 38);
            this.btn_AddBook.TabIndex = 1;
            this.btn_AddBook.Text = "Add new book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(220, 88);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(69, 38);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.Text = "Delete book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // Add_BookCopy
            // 
            this.Add_BookCopy.Location = new System.Drawing.Point(218, 260);
            this.Add_BookCopy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Add_BookCopy.Name = "Add_BookCopy";
            this.Add_BookCopy.Size = new System.Drawing.Size(69, 40);
            this.Add_BookCopy.TabIndex = 4;
            this.Add_BookCopy.Text = "Add BookCopy";
            this.Add_BookCopy.UseVisualStyleBackColor = true;
            this.Add_BookCopy.Click += new System.EventHandler(this.Add_BookCopy_Click);
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.Location = new System.Drawing.Point(21, 231);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(188, 95);
            this.lbBookCopies.TabIndex = 5;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Location = new System.Drawing.Point(235, 188);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(35, 13);
            this.lblBookCopies.TabIndex = 6;
            this.lblBookCopies.Text = "label1";
            // 
            // lb_Member
            // 
            this.lb_Member.FormattingEnabled = true;
            this.lb_Member.HorizontalScrollbar = true;
            this.lb_Member.Location = new System.Drawing.Point(310, 35);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(163, 56);
            this.lb_Member.TabIndex = 12;
            this.lb_Member.SelectedIndexChanged += new System.EventHandler(this.lb_Member_SelectedIndexChanged);
            // 
            // btn_MakeLoan
            // 
            this.btn_MakeLoan.Location = new System.Drawing.Point(400, 96);
            this.btn_MakeLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MakeLoan.Name = "btn_MakeLoan";
            this.btn_MakeLoan.Size = new System.Drawing.Size(73, 42);
            this.btn_MakeLoan.TabIndex = 14;
            this.btn_MakeLoan.Text = "Make Loan";
            this.btn_MakeLoan.UseVisualStyleBackColor = true;
            this.btn_MakeLoan.Click += new System.EventHandler(this.btn_MakeLoan_Click);
            // 
            // btn_FindLoanedBooks
            // 
            this.btn_FindLoanedBooks.Location = new System.Drawing.Point(398, 285);
            this.btn_FindLoanedBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FindLoanedBooks.Name = "btn_FindLoanedBooks";
            this.btn_FindLoanedBooks.Size = new System.Drawing.Size(55, 48);
            this.btn_FindLoanedBooks.TabIndex = 15;
            this.btn_FindLoanedBooks.Text = "Find Loaned Books";
            this.btn_FindLoanedBooks.UseVisualStyleBackColor = true;
            this.btn_FindLoanedBooks.Click += new System.EventHandler(this.btn_FindLoanedBooks_Click);
            // 
            // lb_LoanedBooks
            // 
            this.lb_LoanedBooks.FormattingEnabled = true;
            this.lb_LoanedBooks.HorizontalScrollbar = true;
            this.lb_LoanedBooks.Location = new System.Drawing.Point(310, 223);
            this.lb_LoanedBooks.Name = "lb_LoanedBooks";
            this.lb_LoanedBooks.Size = new System.Drawing.Size(245, 56);
            this.lb_LoanedBooks.TabIndex = 16;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.Location = new System.Drawing.Point(323, 285);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(54, 48);
            this.btn_ReturnBook.TabIndex = 18;
            this.btn_ReturnBook.Text = "Return Book";
            this.btn_ReturnBook.UseVisualStyleBackColor = true;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // btn_FindAvailableBooks
            // 
            this.btn_FindAvailableBooks.Location = new System.Drawing.Point(477, 285);
            this.btn_FindAvailableBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FindAvailableBooks.Name = "btn_FindAvailableBooks";
            this.btn_FindAvailableBooks.Size = new System.Drawing.Size(69, 50);
            this.btn_FindAvailableBooks.TabIndex = 19;
            this.btn_FindAvailableBooks.Text = "Find Available Books";
            this.btn_FindAvailableBooks.UseVisualStyleBackColor = true;
            this.btn_FindAvailableBooks.Click += new System.EventHandler(this.btn_FindAvailableBooks_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 531);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_AboutBook);
            this.tabPage1.Controls.Add(this.lbBooks);
            this.tabPage1.Controls.Add(this.lb_AvailableBooks);
            this.tabPage1.Controls.Add(this.btn_AddBook);
            this.tabPage1.Controls.Add(this.btn_FindAvailableBooks);
            this.tabPage1.Controls.Add(this.deleteBookBtn);
            this.tabPage1.Controls.Add(this.btn_ReturnBook);
            this.tabPage1.Controls.Add(this.Add_BookCopy);
            this.tabPage1.Controls.Add(this.lbBookCopies);
            this.tabPage1.Controls.Add(this.lb_LoanedBooks);
            this.tabPage1.Controls.Add(this.lblBookCopies);
            this.tabPage1.Controls.Add(this.btn_FindLoanedBooks);
            this.tabPage1.Controls.Add(this.lb_Member);
            this.tabPage1.Controls.Add(this.btn_MakeLoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddAuthor);
            this.tabPage2.Controls.Add(this.txtBox_AddAuthor);
            this.tabPage2.Controls.Add(this.lbAuthors);
            this.tabPage2.Controls.Add(this.btn_ViewBooks);
            this.tabPage2.Controls.Add(this.lb_BooksByAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_BooksByAuthor
            // 
            this.lb_BooksByAuthor.FormattingEnabled = true;
            this.lb_BooksByAuthor.Location = new System.Drawing.Point(139, 133);
            this.lb_BooksByAuthor.Name = "lb_BooksByAuthor";
            this.lb_BooksByAuthor.Size = new System.Drawing.Size(174, 82);
            this.lb_BooksByAuthor.TabIndex = 13;
            this.lb_BooksByAuthor.SelectedIndexChanged += new System.EventHandler(this.lb_BooksByAuthor_SelectedIndexChanged);
            // 
            // btn_ViewBooks
            // 
            this.btn_ViewBooks.Location = new System.Drawing.Point(21, 155);
            this.btn_ViewBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewBooks.Name = "btn_ViewBooks";
            this.btn_ViewBooks.Size = new System.Drawing.Size(100, 34);
            this.btn_ViewBooks.TabIndex = 12;
            this.btn_ViewBooks.Text = "View books by selected author";
            this.btn_ViewBooks.UseVisualStyleBackColor = true;
            this.btn_ViewBooks.Click += new System.EventHandler(this.btn_ViewBooks_Click);
            // 
            // txtBox_AddAuthor
            // 
            this.txtBox_AddAuthor.Location = new System.Drawing.Point(21, 38);
            this.txtBox_AddAuthor.Name = "txtBox_AddAuthor";
            this.txtBox_AddAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AddAuthor.TabIndex = 11;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(36, 63);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(71, 34);
            this.btnAddAuthor.TabIndex = 10;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(139, 28);
            this.lbAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(174, 69);
            this.lbAuthors.TabIndex = 9;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_LoansForMember);
            this.tabPage3.Controls.Add(this.btn_FindLoansForMember);
            this.tabPage3.Controls.Add(this.lb_MemberCopy);
            this.tabPage3.Controls.Add(this.btn_AddMember);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(591, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Members";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Location = new System.Drawing.Point(19, 41);
            this.btn_AddMember.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(99, 31);
            this.btn_AddMember.TabIndex = 14;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(753, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(753, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lb_AvailableBooks
            // 
            this.lb_AvailableBooks.Location = new System.Drawing.Point(21, 362);
            this.lb_AvailableBooks.Name = "lb_AvailableBooks";
            this.lb_AvailableBooks.Size = new System.Drawing.Size(424, 95);
            this.lb_AvailableBooks.TabIndex = 0;
            // 
            // lb_MemberCopy
            // 
            this.lb_MemberCopy.FormattingEnabled = true;
            this.lb_MemberCopy.HorizontalScrollbar = true;
            this.lb_MemberCopy.Location = new System.Drawing.Point(156, 19);
            this.lb_MemberCopy.Name = "lb_MemberCopy";
            this.lb_MemberCopy.Size = new System.Drawing.Size(143, 82);
            this.lb_MemberCopy.TabIndex = 15;
            // 
            // btn_FindLoansForMember
            // 
            this.btn_FindLoansForMember.Location = new System.Drawing.Point(340, 35);
            this.btn_FindLoansForMember.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FindLoansForMember.Name = "btn_FindLoansForMember";
            this.btn_FindLoansForMember.Size = new System.Drawing.Size(73, 42);
            this.btn_FindLoansForMember.TabIndex = 18;
            this.btn_FindLoansForMember.Text = "Find Loans for Member";
            this.btn_FindLoansForMember.UseVisualStyleBackColor = true;
            this.btn_FindLoansForMember.Click += new System.EventHandler(this.btn_FindLoansForMember_Click);
            // 
            // lb_LoansForMember
            // 
            this.lb_LoansForMember.FormattingEnabled = true;
            this.lb_LoansForMember.HorizontalScrollbar = true;
            this.lb_LoansForMember.Location = new System.Drawing.Point(19, 182);
            this.lb_LoansForMember.Name = "lb_LoansForMember";
            this.lb_LoansForMember.Size = new System.Drawing.Size(132, 121);
            this.lb_LoansForMember.TabIndex = 19;
            // 
            // btn_AboutBook
            // 
            this.btn_AboutBook.Location = new System.Drawing.Point(220, 132);
            this.btn_AboutBook.Name = "btn_AboutBook";
            this.btn_AboutBook.Size = new System.Drawing.Size(69, 38);
            this.btn_AboutBook.TabIndex = 20;
            this.btn_AboutBook.Text = "About book";
            this.btn_AboutBook.UseVisualStyleBackColor = true;
            this.btn_AboutBook.Click += new System.EventHandler(this.btn_AboutBook_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibraryForm";
            this.Text = "7";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button Add_BookCopy;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.Label lblBookCopies;
        private System.Windows.Forms.ListBox lb_Member;
        private System.Windows.Forms.Button btn_MakeLoan;
        private System.Windows.Forms.Button btn_FindLoanedBooks;
        private System.Windows.Forms.ListBox lb_LoanedBooks;

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox lb_AvailableBooks;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Button btn_FindAvailableBooks;
        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox lb_BooksByAuthor;
        private System.Windows.Forms.Button btn_ViewBooks;
        private System.Windows.Forms.TextBox txtBox_AddAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Button btn_AddMember;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lb_MemberCopy;
        private System.Windows.Forms.Button btn_FindLoansForMember;
        private System.Windows.Forms.ListBox lb_LoansForMember;
        private System.Windows.Forms.Button btn_AboutBook;
    }
}

