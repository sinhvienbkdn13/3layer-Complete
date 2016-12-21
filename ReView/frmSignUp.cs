using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ReView
{
    public partial class frmSignUp : Form
    {
        private UserBUS users = new UserBUS();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.UserId = txtUsername.Text;
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            if(password == rePassword)
            {
                newUser.UserPwd = txtPassword.Text;
                if (users.SignUpNewUser(newUser))
                {
                    MessageBox.Show("Sign Up Successfull");
                    MessageBox.Show("Welcome" + txtUsername.Text);
                    this.Visible = false;
                    frmContacts fContact = new frmContacts();
                    fContact.frmName = txtUsername.Text;
                    fContact.ShowDialog();
                }
            }
        }
    }
}
