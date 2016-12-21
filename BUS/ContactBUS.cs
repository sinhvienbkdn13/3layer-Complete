using DTA;
using DTO;
using System.Data;
using System.Collections;

namespace BUS
{
    public class ContactBUS
    {
        private ContactDB contact = new ContactDB();
        public DataTable SelectAllContact()
        {
            return contact.SelectAll();
        }
        public ArrayList InsertContact(Contact newContact)
        {
            return contact.Insert(newContact);
        }
        public bool UpdateContact(Contact contacts)
        {
            return contact.Update(contacts);
        }
        public bool DeleteContact(Contact contacts)
        {
            return contact.Delete(contacts);
        }
    }
}
