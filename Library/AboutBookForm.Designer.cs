namespace Library
{
    partial class AboutBookForm
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
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.txt_BookDescription = new System.Windows.Forms.TextBox();
            this.lbl_BookISBN = new System.Windows.Forms.Label();
            this.lbl_BookDescription = new System.Windows.Forms.Label();
            this.lbl_BookISBNShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(33, 44);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(57, 20);
            this.lbl_BookTitle.TabIndex = 0;
            this.lbl_BookTitle.Text = "label1";
            // 
            // txt_BookDescription
            // 
            this.txt_BookDescription.Location = new System.Drawing.Point(56, 179);
            this.txt_BookDescription.Multiline = true;
            this.txt_BookDescription.Name = "txt_BookDescription";
            this.txt_BookDescription.ReadOnly = true;
            this.txt_BookDescription.Size = new System.Drawing.Size(460, 248);
            this.txt_BookDescription.TabIndex = 1;
            // 
            // lbl_BookISBN
            // 
            this.lbl_BookISBN.AutoSize = true;
            this.lbl_BookISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookISBN.Location = new System.Drawing.Point(34, 102);
            this.lbl_BookISBN.Name = "lbl_BookISBN";
            this.lbl_BookISBN.Size = new System.Drawing.Size(47, 15);
            this.lbl_BookISBN.TabIndex = 2;
            this.lbl_BookISBN.Text = "ISBN: ";
            // 
            // lbl_BookDescription
            // 
            this.lbl_BookDescription.AutoSize = true;
            this.lbl_BookDescription.Location = new System.Drawing.Point(249, 163);
            this.lbl_BookDescription.Name = "lbl_BookDescription";
            this.lbl_BookDescription.Size = new System.Drawing.Size(60, 13);
            this.lbl_BookDescription.TabIndex = 3;
            this.lbl_BookDescription.Text = "Description";
            // 
            // lbl_BookISBNShow
            // 
            this.lbl_BookISBNShow.AutoSize = true;
            this.lbl_BookISBNShow.Location = new System.Drawing.Point(87, 104);
            this.lbl_BookISBNShow.Name = "lbl_BookISBNShow";
            this.lbl_BookISBNShow.Size = new System.Drawing.Size(38, 13);
            this.lbl_BookISBNShow.TabIndex = 4;
            this.lbl_BookISBNShow.Text = "ISBN: ";
            // 
            // AboutBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 454);
            this.Controls.Add(this.lbl_BookISBNShow);
            this.Controls.Add(this.lbl_BookDescription);
            this.Controls.Add(this.lbl_BookISBN);
            this.Controls.Add(this.txt_BookDescription);
            this.Controls.Add(this.lbl_BookTitle);
            this.Name = "AboutBookForm";
            this.Text = "AboutBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.TextBox txt_BookDescription;
        private System.Windows.Forms.Label lbl_BookISBN;
        private System.Windows.Forms.Label lbl_BookDescription;
        private System.Windows.Forms.Label lbl_BookISBNShow;
    }
}