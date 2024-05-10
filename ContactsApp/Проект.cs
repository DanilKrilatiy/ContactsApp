using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Проект
    {
        private Dictionary<int, Контакт> contactList;

        public string Name { get; set; }
        public string Description { get; set; }

        public Проект()
        {
            contactList = new Dictionary<int, Контакт>();
        }

        public void AddContact(int id, Контакт contact)
        {
            if (!contactList.ContainsKey(id))
            {
                contactList.Add(id, contact);
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Contact with the same ID already exists.");
            }
        }

        public void RemoveContact(int id)
        {
            if (contactList.ContainsKey(id))
            {
                contactList.Remove(id);
                Console.WriteLine("Contact removed successfully.");
            }
            else
            {
                Console.WriteLine("Contact with the specified ID does not exist.");
            }
        }

        public void DisplayContacts()
        {
            foreach (KeyValuePair<int, Контакт> contact in contactList)
            {
                Console.WriteLine($"Contact ID: {contact.Key}");
                Console.WriteLine(contact.Value);
            }
        }
    }
}