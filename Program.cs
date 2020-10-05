using System;
using System.Collections.Generic;
using System.Net;

namespace AddressBookSystem
{
    class Program
    {
        public static Dictionary<string, AddressBook> addressBookMapper = new Dictionary<string, AddressBook>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter 1 to add New Address Book, 2 to Add Contacts, 3 to Edit Contacts, 4 to Delete Contacts, Enter any other key to exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddAddressBook();
                        break;
                    case "2":
                        AddContactInAddressBook();
                        break;
                    case "3":
                        EditContactInAddressBook();
                        break;
                    case "4":
                        DeleteContactInAddressBook();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }

        static void AddAddressBook()
        {
            Console.WriteLine("Enter name of the Address Book to be added");
            string name = Console.ReadLine();
            if (addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("Name already exists!");
            }
            else
            {
                AddressBook addressBook = new AddressBook();
                addressBookMapper.Add(name, addressBook);
            }
        }

        static void AddContactInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to add new contact");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
            }
            else
            {
                AddressBook addressBook = addressBookMapper[name];
                addressBook.AddContact();
            }
        }

        static void EditContactInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to modify contact details");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
            }
            else
            {
                AddressBook addressBook = addressBookMapper[name];
                addressBook.EditContact();
            }
        }

        static void DeleteContactInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to delete contact details");
            string name = Console.ReadLine();
            if (!addressBookMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
            }
            else
            {
                AddressBook addressBook = addressBookMapper[name];
                addressBook.DeleteContact();
            }
        }

    }
}
