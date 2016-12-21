using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Collections;

namespace ReView
{
    public partial class frmContacts : Form
    {
        private ContactBUS contacts = new ContactBUS();
        private DataTable dtListContact = new DataTable();
        private int index;
        private bool isSelect = true;
        public string frmName;
        public frmContacts()
        {
            InitializeComponent();
        }
        public void Init()
        {
            dgvListContact.AutoGenerateColumns = false;
            dgvListContact.Columns.Add("clsContactId", "Contact Id");
            dgvListContact.Columns[0].DataPropertyName = "ContactId";
            dgvListContact.Columns[0].ReadOnly = true;

            dgvListContact.Columns.Add("clsFirstName", "First Name");
            dgvListContact.Columns[1].DataPropertyName = "FirstName";

            dgvListContact.Columns.Add("clsLastName", "Last Name");
            dgvListContact.Columns[2].DataPropertyName = "LastName";
            
            dgvListContact.Columns.Add("clsBirthDate", "Birth Date");
            dgvListContact.Columns[3].DataPropertyName = "BirthDate";

            dgvListContact.Columns.Add("clsAddress", "Address");
            dgvListContact.Columns[4].DataPropertyName = "Address";

            dgvListContact.Columns.Add("clsEmail", "Email");
            dgvListContact.Columns[5].DataPropertyName = "Email";

            dgvListContact.Columns.Add("clsPhone", "Phone");
            dgvListContact.Columns[6].DataPropertyName = "Phone";
        }

        public void LoadList() {
            dtListContact = contacts.SelectAllContact();
            dgvListContact.DataSource = dtListContact;
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            this.Text = " UserID - " + frmName;
            Init();
            LoadList();
        }

        private void InsertnewContact(Contact addContact)
        {
            ArrayList getlist = new ArrayList();
            getlist = contacts.InsertContact(addContact);
            int i = Int32.Parse(getlist[0].ToString());
            if (i == 1)
            {
                MessageBox.Show("Insert Sucessfully");
                dtListContact.ImportRow((DataRow)getlist[1]);
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact newContactAdd = new Contact();
            newContactAdd.FirstName = txtFirstName.Text.Trim();
            newContactAdd.LastName = txtLastName.Text.Trim();
            newContactAdd.Address = txtAddress.Text.Trim();
            newContactAdd.BirthDate = DateTime.Parse(txtBirthdate.Text.Trim());
            newContactAdd.Email = txtEmail.Text.Trim();
            newContactAdd.Phone = txtPhone.Text.Trim();
            InsertnewContact(newContactAdd);
        }

        private void BindingValue()
        {
            if (isSelect)
            {
                if (index >= 0)
                {
                    txtFirstName.Text = dgvListContact.Rows[index].Cells[1].Value.ToString();
                    txtLastName.Text = dgvListContact.Rows[index].Cells[2].Value.ToString();
                    txtAddress.Text = dgvListContact.Rows[index].Cells[4].Value.ToString();
                    txtEmail.Text = dgvListContact.Rows[index].Cells[5].Value.ToString();
                    txtPhone.Text = dgvListContact.Rows[index].Cells[6].Value.ToString();
                    if (dgvListContact.Rows[index].Cells[3].Value.ToString() != "")
                    {

                        txtBirthdate.Text = DateTime.Parse(dgvListContact.Rows[index].Cells[3].Value.ToString()).ToShortDateString();
                    }
                    else
                    {
                        txtBirthdate.Text = "";
                    }
                }
            }
            isSelect = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Contact editContact = new Contact();
                editContact.ContactId = Int32.Parse(dgvListContact.Rows[index].Cells[0].Value.ToString());
                editContact.FirstName = txtFirstName.Text;
                editContact.LastName = txtLastName.Text;
                editContact.Address = txtAddress.Text;
                if (txtBirthdate.Text != "")
                    editContact.BirthDate = DateTime.Parse(txtBirthdate.Text);
                editContact.Email = txtEmail.Text;
                editContact.Phone = txtPhone.Text;

                //Update
                if (contacts.UpdateContact(editContact))
                {
                    MessageBox.Show("Update Sucessfully");
                    DataRow row = dtListContact.Rows[index];
                    row[1] = txtFirstName.Text;
                    row[2] = txtLastName.Text;
                    row[4] = txtAddress.Text;
                    row[3] = txtBirthdate.Text;
                    row[5] = txtEmail.Text;
                    row[6] = txtPhone.Text;
                    dgvListContact.Refresh();
                }
                else
                {
                    MessageBox.Show("Update Faile");
                }
            }
        }

        private void dgvListContact_SelectionChanged(object sender, EventArgs e)
        {
            index = dgvListContact.CurrentCell.RowIndex;
            BindingValue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Contact deletecontact = new Contact();
                deletecontact.ContactId = Int32.Parse(dgvListContact.Rows[index].Cells[0].Value.ToString());
                if (contacts.DeleteContact(deletecontact))
                {
                    MessageBox.Show("Delete Success");
                    isSelect = false;
                    dtListContact.Rows.RemoveAt(index);
                    dgvListContact.Refresh();
                    dgvListContact.Update();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
        }

        private void dgvListContact_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvListContact.CurrentCell.RowIndex;
        }

        private void frmContacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Visible = true;
        }
    }
}
