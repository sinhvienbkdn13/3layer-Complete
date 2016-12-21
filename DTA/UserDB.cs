using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
