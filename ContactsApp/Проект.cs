using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Проект
    {
        public List<Контакт> Contacts { get; private set; }

        public Проект()
        {
            Contacts = new List<Контакт>();
        }

        public void AddContact(Контакт contact)
        {
            Contacts.Add(contact);
        }
    }
}