namespace Library
{
    partial class AddNewMemberForm
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_PersonalId = new System.Windows.Forms.TextBox();
            this.btn_AddNewMember = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_PersonalId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(81, 75);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(123, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_PersonalId
            // 
            this.txt_PersonalId.Location = new System.Drawing.Point(81, 118);
            this.txt_PersonalId.Name = "txt_PersonalId";
            this.txt_PersonalId.Size = new System.Drawing.Size(123, 20);
            this.txt_PersonalId.TabIndex = 1;
            // 
            // btn_AddNewMember
            // 
            this.btn_AddNewMember.Location = new System.Drawing.Point(98, 165);
            this.btn_AddNewMember.Name = "btn_AddNewMember";
            this.btn_AddNewMember.Size = new System.Drawing.Size(91, 43);
            this.btn_AddNewMember.TabIndex = 2;
            this.btn_AddNewMember.Text = "Add new member";
            this.btn_AddNewMember.UseVisualStyleBackColor = true;
            this.btn_AddNewMember.Click += new System.EventHandler(this.btn_AddNewMember_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(123, 59);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_PersonalId
            // 
            this.lbl_PersonalId.AutoSize = true;
            this.lbl_PersonalId.Location = new System.Drawing.Point(108, 102);
            this.lbl_PersonalId.Name = "lbl_PersonalId";
            this.lbl_PersonalId.Size = new System.Drawing.Size(62, 13);
            this.lbl_PersonalId.TabIndex = 4;
            this.lbl_PersonalId.Text = "Personal ID";
            // 
            // AddNewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 258);
            this.Controls.Add(this.lbl_PersonalId);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_AddNewMember);
            this.Controls.Add(this.txt_PersonalId);
            this.Controls.Add(this.txt_Name);
            this.Name = "AddNewMemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_PersonalId;
        private System.Windows.Forms.Button btn_AddNewMember;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_PersonalId;
    }
}