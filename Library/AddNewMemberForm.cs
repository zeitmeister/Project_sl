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

        private void btn_AddNewMember_Click(object sender, EventArgs e)
        {
            Member member = new Member()
            {
                Name = txt_Name.Text,
                PersonId = int.Parse(txt_PersonalId.Text),
                DateOfMembership = DateTime.Now
            };
            MS.Add(member);
        }
    }
}
