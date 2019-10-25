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
            this.lb_Member = new System.Windows.Forms.ListBox();
            this.btn_MakeLoan = new System.Windows.Forms.Button();
            this.lb_LoanedBooks = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_OverdueBooks = new System.Windows.Forms.Label();
            this.lb_OverdueBooks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_AvailableBooks = new System.Windows.Forms.Label();
            this.lb_AvailableBooks = new System.Windows.Forms.ListBox();
            this.btn_DeleteBookCopy = new System.Windows.Forms.Button();
            this.btn_AboutBook = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtBox_AddAuthor = new System.Windows.Forms.TextBox();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.btn_ViewBooks = new System.Windows.Forms.Button();
            this.lb_BooksByAuthor = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_BooksOverdueForMember = new System.Windows.Forms.Label();
            this.lbl_PreviouslyLoanedForMember = new System.Windows.Forms.Label();
            this.lbl_LoansForMember = new System.Windows.Forms.Label();
            this.lbl_MembersCopy = new System.Windows.Forms.Label();
            this.lb_OverdueBooksForMember = new System.Windows.Forms.ListBox();
            this.btn_HistoryDetails = new System.Windows.Forms.Button();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.btn_FindMember = new System.Windows.Forms.Button();
            this.txt_FindMember = new System.Windows.Forms.TextBox();
            this.btn_DeleteMember = new System.Windows.Forms.Button();
            this.lb_LoansForMember = new System.Windows.Forms.ListBox();
            this.btn_FindLoansForMember = new System.Windows.Forms.Button();
            this.lb_MemberCopy = new System.Windows.Forms.ListBox();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbl_AllMembers = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 20;
            this.lbBooks.Location = new System.Drawing.Point(32, 69);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(280, 164);
            this.lbBooks.TabIndex = 0;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(32, 8);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(90, 58);
            this.btn_AddBook.TabIndex = 1;
            this.btn_AddBook.Text = "Add new book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(129, 8);
            this.deleteBookBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(82, 58);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.Text = "Delete book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // Add_BookCopy
            // 
            this.Add_BookCopy.Location = new System.Drawing.Point(62, 285);
            this.Add_BookCopy.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Add_BookCopy.Name = "Add_BookCopy";
            this.Add_BookCopy.Size = new System.Drawing.Size(104, 62);
            this.Add_BookCopy.TabIndex = 4;
            this.Add_BookCopy.Text = "Add BookCopy";
            this.Add_BookCopy.UseVisualStyleBackColor = true;
            this.Add_BookCopy.Click += new System.EventHandler(this.Add_BookCopy_Click);
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.ItemHeight = 20;
            this.lbBookCopies.Location = new System.Drawing.Point(32, 355);
            this.lbBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(280, 144);
            this.lbBookCopies.TabIndex = 5;
            // 
            // lb_Member
            // 
            this.lb_Member.FormattingEnabled = true;
            this.lb_Member.HorizontalScrollbar = true;
            this.lb_Member.ItemHeight = 20;
            this.lb_Member.Location = new System.Drawing.Point(465, 54);
            this.lb_Member.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(242, 204);
            this.lb_Member.TabIndex = 12;
            this.lb_Member.SelectedIndexChanged += new System.EventHandler(this.lb_Member_SelectedIndexChanged);
            // 
            // btn_MakeLoan
            // 
            this.btn_MakeLoan.Location = new System.Drawing.Point(723, 69);
            this.btn_MakeLoan.Name = "btn_MakeLoan";
            this.btn_MakeLoan.Size = new System.Drawing.Size(110, 65);
            this.btn_MakeLoan.TabIndex = 14;
            this.btn_MakeLoan.Text = "Make Loan";
            this.btn_MakeLoan.UseVisualStyleBackColor = true;
            this.btn_MakeLoan.Click += new System.EventHandler(this.btn_MakeLoan_Click);
            // 
            // lb_LoanedBooks
            // 
            this.lb_LoanedBooks.FormattingEnabled = true;
            this.lb_LoanedBooks.HorizontalScrollbar = true;
            this.lb_LoanedBooks.ItemHeight = 20;
            this.lb_LoanedBooks.Location = new System.Drawing.Point(442, 355);
            this.lb_LoanedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_LoanedBooks.Name = "lb_LoanedBooks";
            this.lb_LoanedBooks.Size = new System.Drawing.Size(388, 124);
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
            this.btn_ReturnBook.Location = new System.Drawing.Point(723, 162);
            this.btn_ReturnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(110, 74);
            this.btn_ReturnBook.TabIndex = 18;
            this.btn_ReturnBook.Text = "Return Book";
            this.btn_ReturnBook.UseVisualStyleBackColor = true;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 817);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_DeleteBookCopy);
            this.tabPage1.Controls.Add(this.btn_AboutBook);
            this.tabPage1.Controls.Add(this.lbBooks);
            this.tabPage1.Controls.Add(this.btn_AddBook);
            this.tabPage1.Controls.Add(this.deleteBookBtn);
            this.tabPage1.Controls.Add(this.btn_ReturnBook);
            this.tabPage1.Controls.Add(this.Add_BookCopy);
            this.tabPage1.Controls.Add(this.lbBookCopies);
            this.tabPage1.Controls.Add(this.lb_LoanedBooks);
            this.tabPage1.Controls.Add(this.lb_Member);
            this.tabPage1.Controls.Add(this.btn_MakeLoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(890, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_OverdueBooks);
            this.panel2.Controls.Add(this.lb_OverdueBooks);
            this.panel2.Location = new System.Drawing.Point(442, 534);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 227);
            this.panel2.TabIndex = 23;
            // 
            // lbl_OverdueBooks
            // 
            this.lbl_OverdueBooks.AutoSize = true;
            this.lbl_OverdueBooks.Location = new System.Drawing.Point(129, 15);
            this.lbl_OverdueBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OverdueBooks.Name = "lbl_OverdueBooks";
            this.lbl_OverdueBooks.Size = new System.Drawing.Size(118, 20);
            this.lbl_OverdueBooks.TabIndex = 24;
            this.lbl_OverdueBooks.Text = "Overdue Books";
            // 
            // lb_OverdueBooks
            // 
            this.lb_OverdueBooks.FormattingEnabled = true;
            this.lb_OverdueBooks.ItemHeight = 20;
            this.lb_OverdueBooks.Location = new System.Drawing.Point(34, 40);
            this.lb_OverdueBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_OverdueBooks.Name = "lb_OverdueBooks";
            this.lb_OverdueBooks.Size = new System.Drawing.Size(327, 144);
            this.lb_OverdueBooks.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_AvailableBooks);
            this.panel1.Controls.Add(this.lb_AvailableBooks);
            this.panel1.Location = new System.Drawing.Point(32, 537);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 224);
            this.panel1.TabIndex = 26;
            // 
            // lbl_AvailableBooks
            // 
            this.lbl_AvailableBooks.AutoSize = true;
            this.lbl_AvailableBooks.Location = new System.Drawing.Point(111, 12);
            this.lbl_AvailableBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AvailableBooks.Name = "lbl_AvailableBooks";
            this.lbl_AvailableBooks.Size = new System.Drawing.Size(121, 20);
            this.lbl_AvailableBooks.TabIndex = 22;
            this.lbl_AvailableBooks.Text = "Available Books";
            // 
            // lb_AvailableBooks
            // 
            this.lb_AvailableBooks.ItemHeight = 20;
            this.lb_AvailableBooks.Location = new System.Drawing.Point(52, 37);
            this.lb_AvailableBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_AvailableBooks.Name = "lb_AvailableBooks";
            this.lb_AvailableBooks.Size = new System.Drawing.Size(280, 144);
            this.lb_AvailableBooks.TabIndex = 0;
            // 
            // btn_DeleteBookCopy
            // 
            this.btn_DeleteBookCopy.Location = new System.Drawing.Point(178, 285);
            this.btn_DeleteBookCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteBookCopy.Name = "btn_DeleteBookCopy";
            this.btn_DeleteBookCopy.Size = new System.Drawing.Size(104, 62);
            this.btn_DeleteBookCopy.TabIndex = 21;
            this.btn_DeleteBookCopy.Text = "Delete book copy";
            this.btn_DeleteBookCopy.UseVisualStyleBackColor = true;
            this.btn_DeleteBookCopy.Click += new System.EventHandler(this.btn_DeleteBookCopy_Click);
            // 
            // btn_AboutBook
            // 
            this.btn_AboutBook.Location = new System.Drawing.Point(220, 9);
            this.btn_AboutBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AboutBook.Name = "btn_AboutBook";
            this.btn_AboutBook.Size = new System.Drawing.Size(93, 58);
            this.btn_AboutBook.TabIndex = 20;
            this.btn_AboutBook.Text = "About book";
            this.btn_AboutBook.UseVisualStyleBackColor = true;
            this.btn_AboutBook.Click += new System.EventHandler(this.btn_AboutBook_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddAuthor);
            this.tabPage2.Controls.Add(this.txtBox_AddAuthor);
            this.tabPage2.Controls.Add(this.lbAuthors);
            this.tabPage2.Controls.Add(this.btn_ViewBooks);
            this.tabPage2.Controls.Add(this.lb_BooksByAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(890, 784);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(54, 97);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(106, 52);
            this.btnAddAuthor.TabIndex = 10;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtBox_AddAuthor
            // 
            this.txtBox_AddAuthor.Location = new System.Drawing.Point(32, 58);
            this.txtBox_AddAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_AddAuthor.Name = "txtBox_AddAuthor";
            this.txtBox_AddAuthor.Size = new System.Drawing.Size(148, 26);
            this.txtBox_AddAuthor.TabIndex = 11;
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.ItemHeight = 20;
            this.lbAuthors.Location = new System.Drawing.Point(208, 43);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(259, 104);
            this.lbAuthors.TabIndex = 9;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // btn_ViewBooks
            // 
            this.btn_ViewBooks.Location = new System.Drawing.Point(32, 238);
            this.btn_ViewBooks.Name = "btn_ViewBooks";
            this.btn_ViewBooks.Size = new System.Drawing.Size(150, 52);
            this.btn_ViewBooks.TabIndex = 12;
            this.btn_ViewBooks.Text = "View books by selected author";
            this.btn_ViewBooks.UseVisualStyleBackColor = true;
            this.btn_ViewBooks.Click += new System.EventHandler(this.btn_ViewBooks_Click);
            // 
            // lb_BooksByAuthor
            // 
            this.lb_BooksByAuthor.FormattingEnabled = true;
            this.lb_BooksByAuthor.ItemHeight = 20;
            this.lb_BooksByAuthor.Location = new System.Drawing.Point(208, 205);
            this.lb_BooksByAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_BooksByAuthor.Name = "lb_BooksByAuthor";
            this.lb_BooksByAuthor.Size = new System.Drawing.Size(259, 124);
            this.lb_BooksByAuthor.TabIndex = 13;
            this.lb_BooksByAuthor.SelectedIndexChanged += new System.EventHandler(this.lb_BooksByAuthor_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_BooksOverdueForMember);
            this.tabPage3.Controls.Add(this.lbl_PreviouslyLoanedForMember);
            this.tabPage3.Controls.Add(this.lbl_LoansForMember);
            this.tabPage3.Controls.Add(this.lbl_MembersCopy);
            this.tabPage3.Controls.Add(this.lb_OverdueBooksForMember);
            this.tabPage3.Controls.Add(this.btn_HistoryDetails);
            this.tabPage3.Controls.Add(this.lb_History);
            this.tabPage3.Controls.Add(this.btn_FindMember);
            this.tabPage3.Controls.Add(this.txt_FindMember);
            this.tabPage3.Controls.Add(this.btn_DeleteMember);
            this.tabPage3.Controls.Add(this.lb_LoansForMember);
            this.tabPage3.Controls.Add(this.btn_FindLoansForMember);
            this.tabPage3.Controls.Add(this.lb_MemberCopy);
            this.tabPage3.Controls.Add(this.btn_AddMember);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 784);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Members";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_BooksOverdueForMember
            // 
            this.lbl_BooksOverdueForMember.AutoSize = true;
            this.lbl_BooksOverdueForMember.Location = new System.Drawing.Point(663, 357);
            this.lbl_BooksOverdueForMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BooksOverdueForMember.Name = "lbl_BooksOverdueForMember";
            this.lbl_BooksOverdueForMember.Size = new System.Drawing.Size(115, 20);
            this.lbl_BooksOverdueForMember.TabIndex = 29;
            this.lbl_BooksOverdueForMember.Text = "Books overdue";
            // 
            // lbl_PreviouslyLoanedForMember
            // 
            this.lbl_PreviouslyLoanedForMember.AutoSize = true;
            this.lbl_PreviouslyLoanedForMember.Location = new System.Drawing.Point(332, 355);
            this.lbl_PreviouslyLoanedForMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PreviouslyLoanedForMember.Name = "lbl_PreviouslyLoanedForMember";
            this.lbl_PreviouslyLoanedForMember.Size = new System.Drawing.Size(179, 20);
            this.lbl_PreviouslyLoanedForMember.TabIndex = 28;
            this.lbl_PreviouslyLoanedForMember.Text = "Books previously loaned";
            // 
            // lbl_LoansForMember
            // 
            this.lbl_LoansForMember.AutoSize = true;
            this.lbl_LoansForMember.Location = new System.Drawing.Point(28, 357);
            this.lbl_LoansForMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoansForMember.Name = "lbl_LoansForMember";
            this.lbl_LoansForMember.Size = new System.Drawing.Size(116, 20);
            this.lbl_LoansForMember.TabIndex = 27;
            this.lbl_LoansForMember.Text = "Books on Loan";
            // 
            // lbl_MembersCopy
            // 
            this.lbl_MembersCopy.AutoSize = true;
            this.lbl_MembersCopy.Location = new System.Drawing.Point(327, 38);
            this.lbl_MembersCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MembersCopy.Name = "lbl_MembersCopy";
            this.lbl_MembersCopy.Size = new System.Drawing.Size(75, 20);
            this.lbl_MembersCopy.TabIndex = 26;
            this.lbl_MembersCopy.Text = "Members";
            // 
            // lb_OverdueBooksForMember
            // 
            this.lb_OverdueBooksForMember.FormattingEnabled = true;
            this.lb_OverdueBooksForMember.ItemHeight = 20;
            this.lb_OverdueBooksForMember.Location = new System.Drawing.Point(663, 386);
            this.lb_OverdueBooksForMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_OverdueBooksForMember.Name = "lb_OverdueBooksForMember";
            this.lb_OverdueBooksForMember.Size = new System.Drawing.Size(204, 184);
            this.lb_OverdueBooksForMember.TabIndex = 25;
            // 
            // btn_HistoryDetails
            // 
            this.btn_HistoryDetails.Location = new System.Drawing.Point(380, 595);
            this.btn_HistoryDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HistoryDetails.Name = "btn_HistoryDetails";
            this.btn_HistoryDetails.Size = new System.Drawing.Size(112, 35);
            this.btn_HistoryDetails.TabIndex = 24;
            this.btn_HistoryDetails.Text = "Show details";
            this.btn_HistoryDetails.UseVisualStyleBackColor = true;
            this.btn_HistoryDetails.Click += new System.EventHandler(this.btn_HistoryDetails_Click);
            // 
            // lb_History
            // 
            this.lb_History.FormattingEnabled = true;
            this.lb_History.HorizontalScrollbar = true;
            this.lb_History.ItemHeight = 20;
            this.lb_History.Location = new System.Drawing.Point(332, 383);
            this.lb_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(212, 184);
            this.lb_History.TabIndex = 23;
            this.lb_History.SelectedIndexChanged += new System.EventHandler(this.lb_History_SelectedIndexChanged);
            // 
            // btn_FindMember
            // 
            this.btn_FindMember.Location = new System.Drawing.Point(380, 258);
            this.btn_FindMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FindMember.Name = "btn_FindMember";
            this.btn_FindMember.Size = new System.Drawing.Size(112, 35);
            this.btn_FindMember.TabIndex = 22;
            this.btn_FindMember.Text = "Search";
            this.btn_FindMember.UseVisualStyleBackColor = true;
            this.btn_FindMember.Click += new System.EventHandler(this.btn_FindMember_Click);
            // 
            // txt_FindMember
            // 
            this.txt_FindMember.Location = new System.Drawing.Point(358, 218);
            this.txt_FindMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FindMember.Name = "txt_FindMember";
            this.txt_FindMember.Size = new System.Drawing.Size(148, 26);
            this.txt_FindMember.TabIndex = 21;
            // 
            // btn_DeleteMember
            // 
            this.btn_DeleteMember.Location = new System.Drawing.Point(132, 143);
            this.btn_DeleteMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteMember.Name = "btn_DeleteMember";
            this.btn_DeleteMember.Size = new System.Drawing.Size(146, 46);
            this.btn_DeleteMember.TabIndex = 20;
            this.btn_DeleteMember.Text = "Delete Member";
            this.btn_DeleteMember.UseVisualStyleBackColor = true;
            this.btn_DeleteMember.Click += new System.EventHandler(this.btn_DeleteMember_Click);
            // 
            // lb_LoansForMember
            // 
            this.lb_LoansForMember.FormattingEnabled = true;
            this.lb_LoansForMember.HorizontalScrollbar = true;
            this.lb_LoansForMember.ItemHeight = 20;
            this.lb_LoansForMember.Location = new System.Drawing.Point(28, 386);
            this.lb_LoansForMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_LoansForMember.Name = "lb_LoansForMember";
            this.lb_LoansForMember.Size = new System.Drawing.Size(196, 184);
            this.lb_LoansForMember.TabIndex = 19;
            // 
            // btn_FindLoansForMember
            // 
            this.btn_FindLoansForMember.Location = new System.Drawing.Point(585, 63);
            this.btn_FindLoansForMember.Name = "btn_FindLoansForMember";
            this.btn_FindLoansForMember.Size = new System.Drawing.Size(156, 63);
            this.btn_FindLoansForMember.TabIndex = 18;
            this.btn_FindLoansForMember.Text = "Find Loans for Member";
            this.btn_FindLoansForMember.UseVisualStyleBackColor = true;
            this.btn_FindLoansForMember.Click += new System.EventHandler(this.btn_FindLoansForMember_Click);
            // 
            // lb_MemberCopy
            // 
            this.lb_MemberCopy.FormattingEnabled = true;
            this.lb_MemberCopy.HorizontalScrollbar = true;
            this.lb_MemberCopy.ItemHeight = 20;
            this.lb_MemberCopy.Location = new System.Drawing.Point(332, 63);
            this.lb_MemberCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_MemberCopy.Name = "lb_MemberCopy";
            this.lb_MemberCopy.Size = new System.Drawing.Size(212, 124);
            this.lb_MemberCopy.TabIndex = 15;
            this.lb_MemberCopy.SelectedIndexChanged += new System.EventHandler(this.lb_MemberCopy_SelectedIndexChanged);
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Location = new System.Drawing.Point(132, 63);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(148, 48);
            this.btn_AddMember.TabIndex = 14;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(890, 784);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(890, 784);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbl_AllMembers
            // 
            this.lbl_AllMembers.AutoSize = true;
            this.lbl_AllMembers.Location = new System.Drawing.Point(310, 16);
            this.lbl_AllMembers.Name = "lbl_AllMembers";
            this.lbl_AllMembers.Size = new System.Drawing.Size(63, 13);
            this.lbl_AllMembers.TabIndex = 27;
            this.lbl_AllMembers.Text = "All members";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 815);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryForm";
            this.Text = "7";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button Add_BookCopy;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.ListBox lb_Member;
        private System.Windows.Forms.Button btn_MakeLoan;
        private System.Windows.Forms.ListBox lb_LoanedBooks;

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox lb_AvailableBooks;
        private System.Windows.Forms.Button btn_ReturnBook;
        
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
        private System.Windows.Forms.Button btn_DeleteMember;
        private System.Windows.Forms.Button btn_DeleteBookCopy;
        private System.Windows.Forms.Label lbl_OverdueBooks;
        private System.Windows.Forms.ListBox lb_OverdueBooks;
        private System.Windows.Forms.Label lbl_AvailableBooks;
        private System.Windows.Forms.Button btn_FindMember;
        private System.Windows.Forms.TextBox txt_FindMember;

        private System.Windows.Forms.ListBox lb_History;

        private System.Windows.Forms.Button btn_HistoryDetails;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AllMembers;
        private System.Windows.Forms.Label lbl_BooksOverdueForMember;
        private System.Windows.Forms.Label lbl_PreviouslyLoanedForMember;
        private System.Windows.Forms.Label lbl_LoansForMember;
        private System.Windows.Forms.Label lbl_MembersCopy;
        private System.Windows.Forms.ListBox lb_OverdueBooksForMember;
    }
}

