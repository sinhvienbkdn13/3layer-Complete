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
    public partial class frmLogin : Form
    {
        private UserBUS user = new UserBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool ValidateUser(User userlogin)
        {
            DataTable dtTable = new DataTable();
            dtTable = user.SelectAllUser();
            foreach(DataRow row in dtTable.Rows)
            {
                if(userlogin.UserId == row[0].ToString() && userlogin.UserPwd == row[1].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUserLogin = new User();
            newUserLogin.UserId = txtLoginID.Text;
            newUserLogin.UserPwd = txtPassword.Text;
            if (ValidateUser(newUserLogin))
            {
                MessageBox.Show("Correct");
                frmContacts newContacts = new frmContacts();
                newContacts.Show();
            }
            else
            {
                MessageBox.Show("User or Password is incorrect");
                txtLoginID.Focus();
            }
        }
    }
}
