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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbl_AllMembers = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.lb_MemberCopy = new System.Windows.Forms.ListBox();
            this.btn_FindLoansForMember = new System.Windows.Forms.Button();
            this.lb_LoansForMember = new System.Windows.Forms.ListBox();
            this.btn_DeleteMember = new System.Windows.Forms.Button();
            this.txt_FindMember = new System.Windows.Forms.TextBox();
            this.btn_FindMember = new System.Windows.Forms.Button();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.btn_HistoryDetails = new System.Windows.Forms.Button();
            this.lb_OverdueBooksForMember = new System.Windows.Forms.ListBox();
            this.lbl_MembersCopy = new System.Windows.Forms.Label();
            this.lbl_LoansForMember = new System.Windows.Forms.Label();
            this.lbl_PreviouslyLoanedForMember = new System.Windows.Forms.Label();
            this.lbl_BooksOverdueForMember = new System.Windows.Forms.Label();
            this.btn_ShowAllMembers = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_BooksByAuthor = new System.Windows.Forms.ListBox();
            this.btn_ViewBooks = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.txtBox_AddAuthor = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_MakeLoan = new System.Windows.Forms.Button();
            this.lb_Member = new System.Windows.Forms.ListBox();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.Add_BookCopy = new System.Windows.Forms.Button();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.btn_AboutBook = new System.Windows.Forms.Button();
            this.btn_DeleteBookCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_AvailableBooks = new System.Windows.Forms.ListBox();
            this.lbl_AvailableBooks = new System.Windows.Forms.Label();
            this.lbl_BooksMember = new System.Windows.Forms.Label();
            this.lbl_BooksBookCopys = new System.Windows.Forms.Label();
            this.lb_LoanedBooks = new System.Windows.Forms.ListBox();
            this.lb_OverdueBooks = new System.Windows.Forms.ListBox();
            this.lbl_BooksBooks = new System.Windows.Forms.Label();
            this.lbl_BooksLoanedBooks = new System.Windows.Forms.Label();
            this.lbl_OverdueBooks = new System.Windows.Forms.Label();
            this.btn_EditLoan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.btn_ShowAllMembers);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(855, 660);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Members";
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AddMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddMember.FlatAppearance.BorderSize = 0;
            this.btn_AddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddMember.Location = new System.Drawing.Point(16, 42);
            this.btn_AddMember.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(97, 31);
            this.btn_AddMember.TabIndex = 14;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = false;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // lb_MemberCopy
            // 
            this.lb_MemberCopy.FormattingEnabled = true;
            this.lb_MemberCopy.HorizontalScrollbar = true;
            this.lb_MemberCopy.Location = new System.Drawing.Point(130, 42);
            this.lb_MemberCopy.Name = "lb_MemberCopy";
            this.lb_MemberCopy.Size = new System.Drawing.Size(266, 160);
            this.lb_MemberCopy.TabIndex = 15;
            // 
            // btn_FindLoansForMember
            // 
            this.btn_FindLoansForMember.BackColor = System.Drawing.Color.DimGray;
            this.btn_FindLoansForMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_FindLoansForMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindLoansForMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_FindLoansForMember.Location = new System.Drawing.Point(266, 208);
            this.btn_FindLoansForMember.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FindLoansForMember.Name = "btn_FindLoansForMember";
            this.btn_FindLoansForMember.Size = new System.Drawing.Size(130, 41);
            this.btn_FindLoansForMember.TabIndex = 18;
            this.btn_FindLoansForMember.Text = "Find Loans for Member";
            this.btn_FindLoansForMember.UseVisualStyleBackColor = false;
            this.btn_FindLoansForMember.Click += new System.EventHandler(this.btn_FindLoansForMember_Click);
            // 
            // lb_LoansForMember
            // 
            this.lb_LoansForMember.FormattingEnabled = true;
            this.lb_LoansForMember.HorizontalScrollbar = true;
            this.lb_LoansForMember.Location = new System.Drawing.Point(469, 42);
            this.lb_LoansForMember.Name = "lb_LoansForMember";
            this.lb_LoansForMember.Size = new System.Drawing.Size(266, 160);
            this.lb_LoansForMember.TabIndex = 19;
            // 
            // btn_DeleteMember
            // 
            this.btn_DeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeleteMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteMember.Location = new System.Drawing.Point(16, 87);
            this.btn_DeleteMember.Name = "btn_DeleteMember";
            this.btn_DeleteMember.Size = new System.Drawing.Size(97, 30);
            this.btn_DeleteMember.TabIndex = 20;
            this.btn_DeleteMember.Text = "Delete Member";
            this.btn_DeleteMember.UseVisualStyleBackColor = false;
            this.btn_DeleteMember.Click += new System.EventHandler(this.btn_DeleteMember_Click);
            // 
            // txt_FindMember
            // 
            this.txt_FindMember.Location = new System.Drawing.Point(16, 132);
            this.txt_FindMember.Multiline = true;
            this.txt_FindMember.Name = "txt_FindMember";
            this.txt_FindMember.Size = new System.Drawing.Size(97, 26);
            this.txt_FindMember.TabIndex = 21;
            // 
            // btn_FindMember
            // 
            this.btn_FindMember.BackColor = System.Drawing.Color.DimGray;
            this.btn_FindMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_FindMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_FindMember.Location = new System.Drawing.Point(16, 171);
            this.btn_FindMember.Name = "btn_FindMember";
            this.btn_FindMember.Size = new System.Drawing.Size(97, 31);
            this.btn_FindMember.TabIndex = 22;
            this.btn_FindMember.Text = "Search";
            this.btn_FindMember.UseVisualStyleBackColor = false;
            this.btn_FindMember.Click += new System.EventHandler(this.btn_FindMember_Click);
            // 
            // lb_History
            // 
            this.lb_History.FormattingEnabled = true;
            this.lb_History.HorizontalScrollbar = true;
            this.lb_History.Location = new System.Drawing.Point(130, 340);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(266, 121);
            this.lb_History.TabIndex = 23;
            // 
            // btn_HistoryDetails
            // 
            this.btn_HistoryDetails.BackColor = System.Drawing.Color.DimGray;
            this.btn_HistoryDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_HistoryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HistoryDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HistoryDetails.Location = new System.Drawing.Point(16, 378);
            this.btn_HistoryDetails.Name = "btn_HistoryDetails";
            this.btn_HistoryDetails.Size = new System.Drawing.Size(97, 31);
            this.btn_HistoryDetails.TabIndex = 24;
            this.btn_HistoryDetails.Text = "Show details";
            this.btn_HistoryDetails.UseVisualStyleBackColor = false;
            this.btn_HistoryDetails.Click += new System.EventHandler(this.btn_HistoryDetails_Click);
            // 
            // lb_OverdueBooksForMember
            // 
            this.lb_OverdueBooksForMember.FormattingEnabled = true;
            this.lb_OverdueBooksForMember.HorizontalScrollbar = true;
            this.lb_OverdueBooksForMember.Location = new System.Drawing.Point(469, 340);
            this.lb_OverdueBooksForMember.Name = "lb_OverdueBooksForMember";
            this.lb_OverdueBooksForMember.Size = new System.Drawing.Size(266, 121);
            this.lb_OverdueBooksForMember.TabIndex = 25;
            // 
            // lbl_MembersCopy
            // 
            this.lbl_MembersCopy.AutoSize = true;
            this.lbl_MembersCopy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MembersCopy.Location = new System.Drawing.Point(231, 12);
            this.lbl_MembersCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MembersCopy.Name = "lbl_MembersCopy";
            this.lbl_MembersCopy.Size = new System.Drawing.Size(50, 13);
            this.lbl_MembersCopy.TabIndex = 26;
            this.lbl_MembersCopy.Text = "Members";
            // 
            // lbl_LoansForMember
            // 
            this.lbl_LoansForMember.AutoSize = true;
            this.lbl_LoansForMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LoansForMember.Location = new System.Drawing.Point(556, 12);
            this.lbl_LoansForMember.Name = "lbl_LoansForMember";
            this.lbl_LoansForMember.Size = new System.Drawing.Size(79, 13);
            this.lbl_LoansForMember.TabIndex = 27;
            this.lbl_LoansForMember.Text = "Books on Loan";
            // 
            // lbl_PreviouslyLoanedForMember
            // 
            this.lbl_PreviouslyLoanedForMember.AutoSize = true;
            this.lbl_PreviouslyLoanedForMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_PreviouslyLoanedForMember.Location = new System.Drawing.Point(197, 308);
            this.lbl_PreviouslyLoanedForMember.Name = "lbl_PreviouslyLoanedForMember";
            this.lbl_PreviouslyLoanedForMember.Size = new System.Drawing.Size(122, 13);
            this.lbl_PreviouslyLoanedForMember.TabIndex = 28;
            this.lbl_PreviouslyLoanedForMember.Text = "Books previously loaned";
            // 
            // lbl_BooksOverdueForMember
            // 
            this.lbl_BooksOverdueForMember.AutoSize = true;
            this.lbl_BooksOverdueForMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BooksOverdueForMember.Location = new System.Drawing.Point(556, 308);
            this.lbl_BooksOverdueForMember.Name = "lbl_BooksOverdueForMember";
            this.lbl_BooksOverdueForMember.Size = new System.Drawing.Size(79, 13);
            this.lbl_BooksOverdueForMember.TabIndex = 29;
            this.lbl_BooksOverdueForMember.Text = "Books overdue";
            // 
            // btn_ShowAllMembers
            // 
            this.btn_ShowAllMembers.BackColor = System.Drawing.Color.DimGray;
            this.btn_ShowAllMembers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ShowAllMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAllMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ShowAllMembers.Location = new System.Drawing.Point(130, 208);
            this.btn_ShowAllMembers.Name = "btn_ShowAllMembers";
            this.btn_ShowAllMembers.Size = new System.Drawing.Size(130, 41);
            this.btn_ShowAllMembers.TabIndex = 30;
            this.btn_ShowAllMembers.Text = "Show all members";
            this.btn_ShowAllMembers.UseVisualStyleBackColor = false;
            this.btn_ShowAllMembers.Click += new System.EventHandler(this.btn_ShowAllMembers_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.btnAddAuthor);
            this.tabPage2.Controls.Add(this.txtBox_AddAuthor);
            this.tabPage2.Controls.Add(this.lbAuthors);
            this.tabPage2.Controls.Add(this.btn_ViewBooks);
            this.tabPage2.Controls.Add(this.lb_BooksByAuthor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            // 
            // lb_BooksByAuthor
            // 
            this.lb_BooksByAuthor.FormattingEnabled = true;
            this.lb_BooksByAuthor.Location = new System.Drawing.Point(455, 15);
            this.lb_BooksByAuthor.Name = "lb_BooksByAuthor";
            this.lb_BooksByAuthor.Size = new System.Drawing.Size(302, 407);
            this.lb_BooksByAuthor.TabIndex = 13;
            // 
            // btn_ViewBooks
            // 
            this.btn_ViewBooks.BackColor = System.Drawing.Color.DimGray;
            this.btn_ViewBooks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ViewBooks.Location = new System.Drawing.Point(325, 113);
            this.btn_ViewBooks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewBooks.Name = "btn_ViewBooks";
            this.btn_ViewBooks.Size = new System.Drawing.Size(100, 40);
            this.btn_ViewBooks.TabIndex = 12;
            this.btn_ViewBooks.Text = "View books by selected author";
            this.btn_ViewBooks.UseVisualStyleBackColor = false;
            this.btn_ViewBooks.Click += new System.EventHandler(this.btn_ViewBooks_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(5, 15);
            this.lbAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(302, 407);
            this.lbAuthors.TabIndex = 9;
            // 
            // txtBox_AddAuthor
            // 
            this.txtBox_AddAuthor.Location = new System.Drawing.Point(325, 17);
            this.txtBox_AddAuthor.Multiline = true;
            this.txtBox_AddAuthor.Name = "txtBox_AddAuthor";
            this.txtBox_AddAuthor.Size = new System.Drawing.Size(100, 40);
            this.txtBox_AddAuthor.TabIndex = 11;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAuthor.Location = new System.Drawing.Point(325, 65);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(100, 40);
            this.btnAddAuthor.TabIndex = 10;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.btn_EditLoan);
            this.tabPage1.Controls.Add(this.lbl_OverdueBooks);
            this.tabPage1.Controls.Add(this.lbl_BooksLoanedBooks);
            this.tabPage1.Controls.Add(this.lbl_BooksBooks);
            this.tabPage1.Controls.Add(this.lb_OverdueBooks);
            this.tabPage1.Controls.Add(this.lb_LoanedBooks);
            this.tabPage1.Controls.Add(this.lbl_BooksBookCopys);
            this.tabPage1.Controls.Add(this.lbl_BooksMember);
            this.tabPage1.Controls.Add(this.lbl_AvailableBooks);
            this.tabPage1.Controls.Add(this.lb_AvailableBooks);
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
            this.tabPage1.Controls.Add(this.lb_Member);
            this.tabPage1.Controls.Add(this.btn_MakeLoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            // 
            // btn_MakeLoan
            // 
            this.btn_MakeLoan.BackColor = System.Drawing.Color.DimGray;
            this.btn_MakeLoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_MakeLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MakeLoan.Location = new System.Drawing.Point(12, 254);
            this.btn_MakeLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MakeLoan.Name = "btn_MakeLoan";
            this.btn_MakeLoan.Size = new System.Drawing.Size(97, 31);
            this.btn_MakeLoan.TabIndex = 14;
            this.btn_MakeLoan.Text = "Make Loan";
            this.btn_MakeLoan.UseVisualStyleBackColor = false;
            this.btn_MakeLoan.Click += new System.EventHandler(this.btn_MakeLoan_Click);
            // 
            // lb_Member
            // 
            this.lb_Member.FormattingEnabled = true;
            this.lb_Member.HorizontalScrollbar = true;
            this.lb_Member.Location = new System.Drawing.Point(114, 237);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(250, 108);
            this.lb_Member.TabIndex = 12;
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.HorizontalScrollbar = true;
            this.lbBookCopies.Location = new System.Drawing.Point(512, 49);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(250, 108);
            this.lbBookCopies.TabIndex = 5;
            // 
            // Add_BookCopy
            // 
            this.Add_BookCopy.BackColor = System.Drawing.Color.ForestGreen;
            this.Add_BookCopy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_BookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_BookCopy.ForeColor = System.Drawing.Color.White;
            this.Add_BookCopy.Location = new System.Drawing.Point(406, 50);
            this.Add_BookCopy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Add_BookCopy.Name = "Add_BookCopy";
            this.Add_BookCopy.Size = new System.Drawing.Size(97, 39);
            this.Add_BookCopy.TabIndex = 4;
            this.Add_BookCopy.Text = "Add BookCopy";
            this.Add_BookCopy.UseVisualStyleBackColor = false;
            this.Add_BookCopy.Click += new System.EventHandler(this.Add_BookCopy_Click);
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.BackColor = System.Drawing.Color.DimGray;
            this.btn_ReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReturnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ReturnBook.Location = new System.Drawing.Point(11, 298);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(97, 31);
            this.btn_ReturnBook.TabIndex = 18;
            this.btn_ReturnBook.Text = "Return Book";
            this.btn_ReturnBook.UseVisualStyleBackColor = false;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBookBtn.Location = new System.Drawing.Point(12, 90);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(97, 31);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.Text = "Delete book";
            this.deleteBookBtn.UseVisualStyleBackColor = false;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_AddBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddBook.Location = new System.Drawing.Point(12, 49);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(97, 31);
            this.btn_AddBook.TabIndex = 1;
            this.btn_AddBook.Text = "Add new book";
            this.btn_AddBook.UseVisualStyleBackColor = false;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(114, 50);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(250, 108);
            this.lbBooks.TabIndex = 0;
            // 
            // btn_AboutBook
            // 
            this.btn_AboutBook.BackColor = System.Drawing.Color.DimGray;
            this.btn_AboutBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AboutBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AboutBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AboutBook.Location = new System.Drawing.Point(12, 127);
            this.btn_AboutBook.Name = "btn_AboutBook";
            this.btn_AboutBook.Size = new System.Drawing.Size(97, 31);
            this.btn_AboutBook.TabIndex = 20;
            this.btn_AboutBook.Text = "About book";
            this.btn_AboutBook.UseVisualStyleBackColor = false;
            this.btn_AboutBook.Click += new System.EventHandler(this.btn_AboutBook_Click);
            // 
            // btn_DeleteBookCopy
            // 
            this.btn_DeleteBookCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DeleteBookCopy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteBookCopy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteBookCopy.Location = new System.Drawing.Point(406, 113);
            this.btn_DeleteBookCopy.Name = "btn_DeleteBookCopy";
            this.btn_DeleteBookCopy.Size = new System.Drawing.Size(97, 44);
            this.btn_DeleteBookCopy.TabIndex = 21;
            this.btn_DeleteBookCopy.Text = "Delete book copy";
            this.btn_DeleteBookCopy.UseVisualStyleBackColor = false;
            this.btn_DeleteBookCopy.Click += new System.EventHandler(this.btn_DeleteBookCopy_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-17, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 10);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 10);
            this.panel2.TabIndex = 23;
            // 
            // lb_AvailableBooks
            // 
            this.lb_AvailableBooks.HorizontalScrollbar = true;
            this.lb_AvailableBooks.Location = new System.Drawing.Point(512, 237);
            this.lb_AvailableBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_AvailableBooks.Name = "lb_AvailableBooks";
            this.lb_AvailableBooks.Size = new System.Drawing.Size(250, 108);
            this.lb_AvailableBooks.TabIndex = 0;
            // 
            // lbl_AvailableBooks
            // 
            this.lbl_AvailableBooks.AutoSize = true;
            this.lbl_AvailableBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_AvailableBooks.Location = new System.Drawing.Point(598, 219);
            this.lbl_AvailableBooks.Name = "lbl_AvailableBooks";
            this.lbl_AvailableBooks.Size = new System.Drawing.Size(83, 13);
            this.lbl_AvailableBooks.TabIndex = 22;
            this.lbl_AvailableBooks.Text = "Available Books";
            // 
            // lbl_BooksMember
            // 
            this.lbl_BooksMember.AutoSize = true;
            this.lbl_BooksMember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BooksMember.Location = new System.Drawing.Point(216, 219);
            this.lbl_BooksMember.Name = "lbl_BooksMember";
            this.lbl_BooksMember.Size = new System.Drawing.Size(50, 13);
            this.lbl_BooksMember.TabIndex = 27;
            this.lbl_BooksMember.Text = "Members";
            // 
            // lbl_BooksBookCopys
            // 
            this.lbl_BooksBookCopys.AutoSize = true;
            this.lbl_BooksBookCopys.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BooksBookCopys.Location = new System.Drawing.Point(596, 21);
            this.lbl_BooksBookCopys.Name = "lbl_BooksBookCopys";
            this.lbl_BooksBookCopys.Size = new System.Drawing.Size(66, 13);
            this.lbl_BooksBookCopys.TabIndex = 28;
            this.lbl_BooksBookCopys.Text = "Book copies";
            // 
            // lb_LoanedBooks
            // 
            this.lb_LoanedBooks.FormattingEnabled = true;
            this.lb_LoanedBooks.HorizontalScrollbar = true;
            this.lb_LoanedBooks.Location = new System.Drawing.Point(114, 417);
            this.lb_LoanedBooks.Name = "lb_LoanedBooks";
            this.lb_LoanedBooks.Size = new System.Drawing.Size(250, 108);
            this.lb_LoanedBooks.TabIndex = 16;
            // 
            // lb_OverdueBooks
            // 
            this.lb_OverdueBooks.FormattingEnabled = true;
            this.lb_OverdueBooks.HorizontalScrollbar = true;
            this.lb_OverdueBooks.Location = new System.Drawing.Point(512, 417);
            this.lb_OverdueBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_OverdueBooks.Name = "lb_OverdueBooks";
            this.lb_OverdueBooks.Size = new System.Drawing.Size(250, 108);
            this.lb_OverdueBooks.TabIndex = 23;
            // 
            // lbl_BooksBooks
            // 
            this.lbl_BooksBooks.AutoSize = true;
            this.lbl_BooksBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BooksBooks.Location = new System.Drawing.Point(216, 21);
            this.lbl_BooksBooks.Name = "lbl_BooksBooks";
            this.lbl_BooksBooks.Size = new System.Drawing.Size(37, 13);
            this.lbl_BooksBooks.TabIndex = 29;
            this.lbl_BooksBooks.Text = "Books";
            // 
            // lbl_BooksLoanedBooks
            // 
            this.lbl_BooksLoanedBooks.AutoSize = true;
            this.lbl_BooksLoanedBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BooksLoanedBooks.Location = new System.Drawing.Point(182, 386);
            this.lbl_BooksLoanedBooks.Name = "lbl_BooksLoanedBooks";
            this.lbl_BooksLoanedBooks.Size = new System.Drawing.Size(118, 13);
            this.lbl_BooksLoanedBooks.TabIndex = 30;
            this.lbl_BooksLoanedBooks.Text = "Books currently on loan";
            // 
            // lbl_OverdueBooks
            // 
            this.lbl_OverdueBooks.AutoSize = true;
            this.lbl_OverdueBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_OverdueBooks.Location = new System.Drawing.Point(598, 386);
            this.lbl_OverdueBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OverdueBooks.Name = "lbl_OverdueBooks";
            this.lbl_OverdueBooks.Size = new System.Drawing.Size(81, 13);
            this.lbl_OverdueBooks.TabIndex = 24;
            this.lbl_OverdueBooks.Text = "Overdue Books";
            // 
            // btn_EditLoan
            // 
            this.btn_EditLoan.BackColor = System.Drawing.Color.DimGray;
            this.btn_EditLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditLoan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_EditLoan.Location = new System.Drawing.Point(13, 445);
            this.btn_EditLoan.Name = "btn_EditLoan";
            this.btn_EditLoan.Size = new System.Drawing.Size(95, 24);
            this.btn_EditLoan.TabIndex = 31;
            this.btn_EditLoan.Text = "Edit Loan";
            this.btn_EditLoan.UseVisualStyleBackColor = false;
            this.btn_EditLoan.Click += new System.EventHandler(this.btn_EditLoan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 686);
            this.tabControl1.TabIndex = 21;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(855, 685);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LibraryForm";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_AllMembers;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_EditLoan;
        private System.Windows.Forms.Label lbl_OverdueBooks;
        private System.Windows.Forms.Label lbl_BooksLoanedBooks;
        private System.Windows.Forms.Label lbl_BooksBooks;
        private System.Windows.Forms.ListBox lb_OverdueBooks;
        private System.Windows.Forms.ListBox lb_LoanedBooks;
        private System.Windows.Forms.Label lbl_BooksBookCopys;
        private System.Windows.Forms.Label lbl_BooksMember;
        private System.Windows.Forms.Label lbl_AvailableBooks;
        private System.Windows.Forms.ListBox lb_AvailableBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DeleteBookCopy;
        private System.Windows.Forms.Button btn_AboutBook;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Button Add_BookCopy;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.ListBox lb_Member;
        private System.Windows.Forms.Button btn_MakeLoan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox txtBox_AddAuthor;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Button btn_ViewBooks;
        private System.Windows.Forms.ListBox lb_BooksByAuthor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_ShowAllMembers;
        private System.Windows.Forms.Label lbl_BooksOverdueForMember;
        private System.Windows.Forms.Label lbl_PreviouslyLoanedForMember;
        private System.Windows.Forms.Label lbl_LoansForMember;
        private System.Windows.Forms.Label lbl_MembersCopy;
        private System.Windows.Forms.ListBox lb_OverdueBooksForMember;
        private System.Windows.Forms.Button btn_HistoryDetails;
        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.Button btn_FindMember;
        private System.Windows.Forms.TextBox txt_FindMember;
        private System.Windows.Forms.Button btn_DeleteMember;
        private System.Windows.Forms.ListBox lb_LoansForMember;
        private System.Windows.Forms.Button btn_FindLoansForMember;
        private System.Windows.Forms.ListBox lb_MemberCopy;
        private System.Windows.Forms.Button btn_AddMember;
    }
}

