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
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 20;
            this.lbBooks.Location = new System.Drawing.Point(18, 18);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(271, 364);
            this.lbBooks.TabIndex = 0;
            // 
            // BTNChangeBook
            // 
            this.BTNChangeBook.Location = new System.Drawing.Point(310, 18);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(122, 91);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryForm";
            this.Text = "7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.Button button1;
    }
}

