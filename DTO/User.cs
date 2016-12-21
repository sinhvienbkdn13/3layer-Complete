using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string userid;
        private string userpwd;

        public string UserId
        {
            get
            {
                return userid;
            }

            set
            {
                userid = value;
            }
        }
        public string UserPwd
        {
            get
            {
                return userpwd;
            }

            set
            {
                userpwd = value;
            }
        }
    }
}
