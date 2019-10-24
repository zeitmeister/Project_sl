namespace Library
{
    partial class AddBookCopyForm
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
            this.cb_Condition = new System.Windows.Forms.ComboBox();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.btn_AddBookCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Condition
            // 
            this.cb_Condition.FormattingEnabled = true;
            this.cb_Condition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_Condition.Location = new System.Drawing.Point(100, 165);
            this.cb_Condition.MaxDropDownItems = 10;
            this.cb_Condition.Name = "cb_Condition";
            this.cb_Condition.Size = new System.Drawing.Size(121, 21);
            this.cb_Condition.TabIndex = 0;
            this.cb_Condition.Text = "1";
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.Location = new System.Drawing.Point(76, 109);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(175, 13);
            this.lbl_Condition.TabIndex = 1;
            this.lbl_Condition.Text = "In what condition is the book copy?";
            // 
            // btn_AddBookCopy
            // 
            this.btn_AddBookCopy.Location = new System.Drawing.Point(109, 218);
            this.btn_AddBookCopy.Name = "btn_AddBookCopy";
            this.btn_AddBookCopy.Size = new System.Drawing.Size(102, 47);
            this.btn_AddBookCopy.TabIndex = 2;
            this.btn_AddBookCopy.Text = "Add book copy";
            this.btn_AddBookCopy.UseVisualStyleBackColor = true;
            this.btn_AddBookCopy.Click += new System.EventHandler(this.btn_AddBookCopy_Click);
            // 
            // AddBookCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 300);
            this.Controls.Add(this.btn_AddBookCopy);
            this.Controls.Add(this.lbl_Condition);
            this.Controls.Add(this.cb_Condition);
            this.Name = "AddBookCopyForm";
            this.Text = "AddBookCopy";
            this.Load += new System.EventHandler(this.AddBookCopyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Condition;
        private System.Windows.Forms.Label lbl_Condition;
        private System.Windows.Forms.Button btn_AddBookCopy;
    }
}