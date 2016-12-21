using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA
{
    public class DbConnect
    {
        public static SqlConnection ConnectionDB()
        {
            string connect = "Data Source=TOMMY;Initial Catalog=MyDB;Integrated Security=True";
            SqlConnection newConnect = new SqlConnection(connect);
            return newConnect;
        }
    }
}
