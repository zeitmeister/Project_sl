namespace Library
{
    partial class AboutHistoryForm
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
            this.txt_TimeOfLoan = new System.Windows.Forms.TextBox();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.btn_AboutBook = new System.Windows.Forms.Button();
            this.lbl_TimeOfLoan = new System.Windows.Forms.Label();
            this.lbl_TimeOfReturn = new System.Windows.Forms.Label();
            this.txt_TimeOfReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_TimeOfLoan
            // 
            this.txt_TimeOfLoan.Location = new System.Drawing.Point(213, 189);
            this.txt_TimeOfLoan.Name = "txt_TimeOfLoan";
            this.txt_TimeOfLoan.ReadOnly = true;
            this.txt_TimeOfLoan.Size = new System.Drawing.Size(122, 20);
            this.txt_TimeOfLoan.TabIndex = 0;
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(32, 94);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(92, 31);
            this.lbl_BookTitle.TabIndex = 1;
            this.lbl_BookTitle.Text = "label1";
            // 
            // btn_AboutBook
            // 
            this.btn_AboutBook.Location = new System.Drawing.Point(38, 38);
            this.btn_AboutBook.Name = "btn_AboutBook";
            this.btn_AboutBook.Size = new System.Drawing.Size(75, 23);
            this.btn_AboutBook.TabIndex = 2;
            this.btn_AboutBook.Text = "About book";
            this.btn_AboutBook.UseVisualStyleBackColor = true;
            this.btn_AboutBook.Click += new System.EventHandler(this.btn_AboutBook_Click);
            // 
            // lbl_TimeOfLoan
            // 
            this.lbl_TimeOfLoan.AutoSize = true;
            this.lbl_TimeOfLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeOfLoan.Location = new System.Drawing.Point(24, 184);
            this.lbl_TimeOfLoan.Name = "lbl_TimeOfLoan";
            this.lbl_TimeOfLoan.Size = new System.Drawing.Size(132, 24);
            this.lbl_TimeOfLoan.TabIndex = 3;
            this.lbl_TimeOfLoan.Text = "Time of loan:";
            // 
            // lbl_TimeOfReturn
            // 
            this.lbl_TimeOfReturn.AutoSize = true;
            this.lbl_TimeOfReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeOfReturn.Location = new System.Drawing.Point(24, 226);
            this.lbl_TimeOfReturn.Name = "lbl_TimeOfReturn";
            this.lbl_TimeOfReturn.Size = new System.Drawing.Size(147, 24);
            this.lbl_TimeOfReturn.TabIndex = 4;
            this.lbl_TimeOfReturn.Text = "Time of return:";
            // 
            // txt_TimeOfReturn
            // 
            this.txt_TimeOfReturn.Location = new System.Drawing.Point(213, 230);
            this.txt_TimeOfReturn.Name = "txt_TimeOfReturn";
            this.txt_TimeOfReturn.ReadOnly = true;
            this.txt_TimeOfReturn.Size = new System.Drawing.Size(122, 20);
            this.txt_TimeOfReturn.TabIndex = 5;
            // 
            // AboutHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 483);
            this.Controls.Add(this.txt_TimeOfReturn);
            this.Controls.Add(this.lbl_TimeOfReturn);
            this.Controls.Add(this.lbl_TimeOfLoan);
            this.Controls.Add(this.btn_AboutBook);
            this.Controls.Add(this.lbl_BookTitle);
            this.Controls.Add(this.txt_TimeOfLoan);
            this.Name = "AboutHistoryForm";
            this.Text = "AboutHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimeOfLoan;
        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.Button btn_AboutBook;
        private System.Windows.Forms.Label lbl_TimeOfLoan;
        private System.Windows.Forms.Label lbl_TimeOfReturn;
        private System.Windows.Forms.TextBox txt_TimeOfReturn;
    }
}