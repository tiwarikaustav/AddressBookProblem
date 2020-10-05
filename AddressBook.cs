using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private readonly NLog nLog = new NLog();
        public List<ContactDetails> contactList = new List<ContactDetails>();
        public Dictionary<string, ContactDetails> nameToContactMapper = new Dictionary<string, ContactDetails>();

        public void AddContact()
        {
            bool flag = true;
            while (flag) 
            { 
                ContactDetails contact = new ContactDetails();
                if (contact.firstName == "" || contact.lastName == "" || contact.address == "" || contact.city == "" || contact.state == "" || contact.zip == "" || contact.phoneNum == "" || contact.eMail == "")
                {
                    //Just to mark that this operation was unsuccessful
                    nLog.LogDebug("Operation Unsuccessful: AddContact()");
                    //Just to make note that whatever values entered should be greater than zero
                    nLog.LogError("Values entered by user cannot be empty string");
                    //Just to warn that values should be non empty
                    nLog.LogWarn("Entry should not be empty");
                }

                contactList.Add(contact);
                nameToContactMapper.Add(contact.firstName + " " + contact.lastName, contact);
                Console.WriteLine("Contact created successfully with following details: ");
                Console.WriteLine("First Name: " + contact.firstName + " Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address + " \nCity: " + contact.city + " \nState: " + contact.state);
                Console.WriteLine("Zip Code: " + contact.zip + " \nPhone Number: " + contact.phoneNum + " \nEMail ID: " + contact.eMail);

                nLog.LogDebug("Log Successful: AddContact()");
                //Just to mark a flag that this operation was successful
                nLog.LogInfo("Contact Created with first name: " + contact.firstName + " last name: " + contact.lastName);

                //If multiple contacts are to be added
                Console.WriteLine("Do you want to add another contact? Press Y/N");
                string option = Console.ReadLine();
                if (!(option != "Y" ^ option != "y"))
                {
                    flag = false;
                }
            }
        }

        public void EditContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("To edit contact enter 'first name', followed by single space, followed by 'last name'");
                string name = Console.ReadLine();
                if (nameToContactMapper.ContainsKey(name))
                {
                    ContactDetails contact = nameToContactMapper[name];
                    Console.WriteLine("Enter latest details of Contact");

                    Console.WriteLine("Enter First Name of contact");
                    string firstName = Console.ReadLine();
                    contact.firstName = firstName;

                    Console.WriteLine("Enter Last Name of Contact");
                    string lastName = Console.ReadLine();
                    contact.lastName = lastName;

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    contact.address = address;

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();
                    contact.city = city;

                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.state = state;

                    Console.WriteLine("Enter zip");
                    string zipCode = Console.ReadLine();
                    contact.zip = zipCode;

                    Console.WriteLine("Enter Phone Number");
                    string phoneNumber = Console.ReadLine();
                    contact.phoneNum = phoneNumber;

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.eMail = email;

                    Console.WriteLine("\nSuccess! New Details for the contact are: ");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNum + "\nEmail: " + contact.eMail);
                }
                else
                {
                    Console.WriteLine("Entered Name does not match any contact");
                }
                //If multiple contacts are to be updated
                Console.WriteLine("Do you want to update another contact? Press Y/N");
                string option = Console.ReadLine();
                if (!(option != "Y" ^ option != "y"))
                {
                    flag = false;
                }
            }
        }

        public void DeleteContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nTo delete a contact enter 'first name', followed by single space, followed by 'last name'");
                string name = Console.ReadLine();
                if (nameToContactMapper.ContainsKey(name))
                {
                    ContactDetails contact = nameToContactMapper[name];
                    var index = contactList.FindIndex(i => i == contact);
                    if (index >= 0) contactList.RemoveAt(index);
                    nameToContactMapper.Remove(name);
                }
                else
                {
                    Console.WriteLine("Entered Name does not match any contact");
                }

                //If multiple contacts are to be updated
                Console.WriteLine("Do you want to delete another contact? Press Y/N");
                string option = Console.ReadLine();
                if (!(option != "Y" ^ option != "y"))
                {
                    flag = false;
                }
            }
        }

    }
}
