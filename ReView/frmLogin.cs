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
            if (chbRememberLogin.Checked)
            {
                Properties.Settings.Default.user = txtLoginID.Text;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
            if (ValidateUser(newUserLogin))
            {
                MessageBox.Show("Welcome Back " + txtLoginID.Text);
                frmContacts fContact = new frmContacts();
                fContact.frmName = txtLoginID.Text;
                this.Visible = false;
                fContact.ShowDialog();
            }
            else
            {
                MessageBox.Show("User or Password is incorrect");
                txtLoginID.Focus();
            }
        }

        private void benSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp fSignUp = new frmSignUp();
            fSignUp.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginID.Text = Properties.Settings.Default.user;
            txtPassword.Text = Properties.Settings.Default.password;
        }
    }
}
