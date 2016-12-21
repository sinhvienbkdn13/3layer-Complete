using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Collections;

namespace DTA
{
    public class ContactDB
    {
        private SqlConnection connect = DbConnect.ConnectionDB();
        private SqlDataAdapter dtAdapter;
        public DataTable SelectAll()
        {
            DataTable dtTable = new DataTable();
            dtAdapter = new SqlDataAdapter("spSelectAllConTacts", connect);
            dtAdapter.Fill(dtTable);
            return dtTable;
        }
        public ArrayList Insert(Contact newContact)
        {
            connect.Open();
            DataTable dtTable = new DataTable();
            SqlCommand cmd = new SqlCommand("spInsertContacts", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", newContact.FirstName);
            cmd.Parameters.AddWithValue("@LastName", newContact.LastName);
            cmd.Parameters.AddWithValue("@BirthDate", newContact.BirthDate);
            cmd.Parameters.AddWithValue("@Address", newContact.Address);
            cmd.Parameters.AddWithValue("@Email", newContact.Email);
            cmd.Parameters.AddWithValue("@Phone", newContact.Phone);
            dtAdapter.InsertCommand = cmd;
            int i = dtAdapter.InsertCommand.ExecuteNonQuery();
            dtAdapter.Fill(dtTable);
            DataRow insertrow = dtTable.Rows[dtTable.Rows.Count-1];
            ArrayList newList = new ArrayList();
            newList.Add(i);
            newList.Add(insertrow);
            connect.Close();
            return newList;
        }
        public bool Update(Contact contacts)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("spUpdateContacts",connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactId", contacts.ContactId);
            cmd.Parameters.AddWithValue("@FirstName", contacts.FirstName);
            cmd.Parameters.AddWithValue("@LastName", contacts.LastName);
            cmd.Parameters.AddWithValue("@BirthDate", contacts.BirthDate);
            cmd.Parameters.AddWithValue("@Address", contacts.Address);
            cmd.Parameters.AddWithValue("@Email", contacts.Email);
            cmd.Parameters.AddWithValue("@Phone", contacts.Phone);
            dtAdapter.UpdateCommand = cmd;
            int i = dtAdapter.UpdateCommand.ExecuteNonQuery();
            connect.Close();
            if (i == 1) return true;
            return false;
        }
        public bool Delete(Contact contacts)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("spDeleteContacts", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactId", contacts.ContactId);
            dtAdapter.DeleteCommand = cmd;
            int i = dtAdapter.DeleteCommand.ExecuteNonQuery();
            connect.Close();
            if (i == 1) return true;
            return false;
        }
    }
}
