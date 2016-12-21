using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTA;
using System.Data;

namespace BUS
{
    public class UserBUS
    {
        private UserDB user = new UserDB();

        public DataTable SelectAllUser()
        {
            return user.SelectAll();
        }
    }
}
