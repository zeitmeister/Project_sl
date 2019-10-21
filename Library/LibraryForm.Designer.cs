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
<<<<<<< HEAD
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.Add_BookCopy = new System.Windows.Forms.Button();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.lblBookCopies = new System.Windows.Forms.Label();
=======
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 12);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(431, 238);
            this.lbBooks.TabIndex = 0;
            // 
            // BTNChangeBook
            // 
<<<<<<< HEAD
            this.BTNChangeBook.Location = new System.Drawing.Point(448, 22);
=======
            this.BTNChangeBook.Location = new System.Drawing.Point(207, 12);
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            this.BTNChangeBook.Margin = new System.Windows.Forms.Padding(2);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(81, 59);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(448, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 15);
=======
            this.button1.Location = new System.Drawing.Point(213, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
<<<<<<< HEAD
            // deleteBookBtn
            // 
            this.deleteBookBtn.Location = new System.Drawing.Point(448, 181);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBookBtn.TabIndex = 3;
            this.deleteBookBtn.Text = "Delete book";
            this.deleteBookBtn.UseVisualStyleBackColor = true;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // Add_BookCopy
            // 
            this.Add_BookCopy.Location = new System.Drawing.Point(544, 463);
            this.Add_BookCopy.Name = "Add_BookCopy";
            this.Add_BookCopy.Size = new System.Drawing.Size(227, 83);
            this.Add_BookCopy.TabIndex = 4;
            this.Add_BookCopy.Text = "Add BookCopy";
            this.Add_BookCopy.UseVisualStyleBackColor = true;
            this.Add_BookCopy.Click += new System.EventHandler(this.Add_BookCopy_Click);
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.Location = new System.Drawing.Point(12, 385);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(431, 238);
            this.lbBookCopies.TabIndex = 5;
            // 
            // lblBookCopies
            // 
            this.lblBookCopies.AutoSize = true;
            this.lblBookCopies.Location = new System.Drawing.Point(12, 369);
            this.lblBookCopies.Name = "lblBookCopies";
            this.lblBookCopies.Size = new System.Drawing.Size(35, 13);
            this.lblBookCopies.TabIndex = 6;
            this.lblBookCopies.Text = "label1";
            // 
=======
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1060, 762);
            this.Controls.Add(this.lblBookCopies);
            this.Controls.Add(this.lbBookCopies);
            this.Controls.Add(this.Add_BookCopy);
            this.Controls.Add(this.deleteBookBtn);
=======
            this.ClientSize = new System.Drawing.Size(302, 262);
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
<<<<<<< HEAD
            this.Text = "7";
=======
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Button Add_BookCopy;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.Label lblBookCopies;
=======
>>>>>>> 5313290710a16ccd916e146f5d35e8bf00e056fd
    }
}

