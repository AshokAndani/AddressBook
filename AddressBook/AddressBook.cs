using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        public List<Contact> Contacts;
        public AddressBook()
        {
            Contacts = new List<Contact>();
        }
        public void AddContact()
        {
            var contact = new Contact();
            Console.WriteLine("Enter UserName:");
            contact.Name =Console.ReadLine();
            Console.WriteLine("Enter zipcode:");
            contact.ZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter contact number:");
            contact.ContactNumber = int.Parse(Console.ReadLine());
            Contacts.Add(contact);
        }
        public void Display()
        {
           if(Contacts.Count <= 0)
            {
                Console.WriteLine("No contacts available");
            }
            else
            {
                foreach (var contact in Contacts)
                {
                    Console.WriteLine("ContactName: " + contact.Name + "\n Contact PhoneNumber:" + contact.ContactNumber + "\n ZipCode: " + contact.ZipCode);
                }
            }
        }
        public void DeleteContct()
        {
            Console.WriteLine("Enter UserName to delete appropriate contact:");
            string UserEnteredName=Console.ReadLine();
            if (Contacts.Count <= 0)
            {
                Console.WriteLine("No contacts available");
            }
            else
            {
                Contact contact = null;
                foreach(var item in Contacts)
                {
                    if(item.Name == UserEnteredName)
                    {
                        contact = item;
                    }
                }
                Contacts.Remove(contact);
            }
        }
    }
}
