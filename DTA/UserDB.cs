using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DTA
{
    public class UserDB
    {
        SqlConnection connect = DbConnect.ConnectionDB();
        private SqlDataAdapter dtAdapter;
        public DataTable SelectAll()
        {
            DataTable dtTable = new DataTable();
            dtAdapter = new SqlDataAdapter("spSelectAllUsers",connect);
            dtAdapter.Fill(dtTable);
            return dtTable;
        }
        public bool Insert(User newUser)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("spInsertUsers", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", newUser.UserId);
            cmd.Parameters.AddWithValue("@UserPwd", newUser.UserPwd);
            int i = cmd.ExecuteNonQuery();
            connect.Close();
            if (i == 1) return true;
            return false;
        }
    }
}
