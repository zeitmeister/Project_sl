namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(223, 79);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(100, 20);
            this.txt_Title.TabIndex = 1;
            this.txt_Title.TextChanged += new System.EventHandler(this.txt_Title_TextChanged);
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(403, 79);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(100, 20);
            this.txt_Author.TabIndex = 2;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(67, 157);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(400, 69);
            this.txt_Description.TabIndex = 3;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(196, 248);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(138, 65);
            this.btn_AddBook.TabIndex = 4;
            this.btn_AddBook.Text = "Add book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(48, 63);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lbl_ISBN.TabIndex = 5;
            this.lbl_ISBN.Text = "ISBN";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(262, 63);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Title";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(438, 63);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(38, 13);
            this.lbl_Author.TabIndex = 7;
            this.lbl_Author.Text = "Author";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(242, 130);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 8;
            this.lbl_Description.Text = "Description";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(12, 79);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(100, 20);
            this.txt_ISBN.TabIndex = 9;
            this.txt_ISBN.TextChanged += new System.EventHandler(this.txt_ISBN_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 340);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_ISBN);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_ISBN;
    }
}