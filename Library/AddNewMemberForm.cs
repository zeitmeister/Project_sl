using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;
using Library.Models;

namespace Library
{
    /// <summary>
    /// The form that let the user add a new member.
    /// </summary>
    public partial class AddNewMemberForm : Form
    {
        MemberService MS;
        public AddNewMemberForm(MemberService memberservice)
        {
            MS = memberservice;
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The button that adds a new member and checks if a member already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddNewMember_Click(object sender, EventArgs e)
        {
            int PersonalID;
            var PersonidIsOK = int.TryParse(txt_PersonalId.Text, out PersonalID);

            if (!PersonidIsOK)
            {
                MessageBox.Show("Personal ID has to be a number.");
            }
            else if (MS.MemberAlreadyExists(PersonalID))
            {
                MessageBox.Show("A member with this personal id already exists.");
            }
            else if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name.");
            }
            else
            {
                Member member = new Member()
                {
                    Name = txt_Name.Text.Trim(),
                    PersonId = PersonalID,
                    DateOfMembership = DateTime.Now
                };
                MS.Add(member);
            }
        }
    }
}
