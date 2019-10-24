﻿namespace Library
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
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.btn_AboutBook = new System.Windows.Forms.Button();
            this.dtm_TimeOfLoan = new System.Windows.Forms.DateTimePicker();
            this.dtm_TimeOfReturn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Info
            // 
            this.txt_Info.Location = new System.Drawing.Point(28, 148);
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ReadOnly = true;
            this.txt_Info.Size = new System.Drawing.Size(435, 20);
            this.txt_Info.TabIndex = 0;
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(24, 53);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(66, 24);
            this.lbl_BookTitle.TabIndex = 1;
            this.lbl_BookTitle.Text = "label1";
            // 
            // btn_AboutBook
            // 
            this.btn_AboutBook.Location = new System.Drawing.Point(15, 12);
            this.btn_AboutBook.Name = "btn_AboutBook";
            this.btn_AboutBook.Size = new System.Drawing.Size(75, 23);
            this.btn_AboutBook.TabIndex = 2;
            this.btn_AboutBook.Text = "About book";
            this.btn_AboutBook.UseVisualStyleBackColor = true;
            this.btn_AboutBook.Click += new System.EventHandler(this.btn_AboutBook_Click);
            // 
            // dtm_TimeOfLoan
            // 
            this.dtm_TimeOfLoan.Location = new System.Drawing.Point(28, 239);
            this.dtm_TimeOfLoan.Name = "dtm_TimeOfLoan";
            this.dtm_TimeOfLoan.Size = new System.Drawing.Size(241, 20);
            this.dtm_TimeOfLoan.TabIndex = 3;
            // 
            // dtm_TimeOfReturn
            // 
            this.dtm_TimeOfReturn.Location = new System.Drawing.Point(348, 239);
            this.dtm_TimeOfReturn.Name = "dtm_TimeOfReturn";
            this.dtm_TimeOfReturn.Size = new System.Drawing.Size(245, 20);
            this.dtm_TimeOfReturn.TabIndex = 4;
            // 
            // AboutHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 483);
            this.Controls.Add(this.dtm_TimeOfReturn);
            this.Controls.Add(this.dtm_TimeOfLoan);
            this.Controls.Add(this.btn_AboutBook);
            this.Controls.Add(this.lbl_BookTitle);
            this.Controls.Add(this.txt_Info);
            this.Name = "AboutHistoryForm";
            this.Text = "AboutHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.Button btn_AboutBook;
        private System.Windows.Forms.DateTimePicker dtm_TimeOfLoan;
        private System.Windows.Forms.DateTimePicker dtm_TimeOfReturn;
    }
}