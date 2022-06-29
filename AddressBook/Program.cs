using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter 1 to add a new contact \n Enter 2 to Diplay all Contacts\nEnter 3 to Delete a contact");
                int input = int.Parse(Console.ReadLine());
               
                switch (input)
                {
                    case 1: address.AddContact(); break;
                    case 2: address.Display(); break;
                    case 3: address.DeleteContct(); break;
                }
            }
        }
    }
}
