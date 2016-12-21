using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTA;
using System.Data;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        private UserDB user = new UserDB();

        public DataTable SelectAllUser()
        {
            return user.SelectAll();
        }
        public bool SignUpNewUser(User newUser)
        {
            return user.Insert(newUser);
        }
    }
}
