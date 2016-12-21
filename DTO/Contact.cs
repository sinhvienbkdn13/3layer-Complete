using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contact
    {
        private int contactid;
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private string address;
        private string email;
        private string phone;

        public int ContactId
        {
            get
            {
                return contactid;
            }

            set
            {
                contactid = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }
}
