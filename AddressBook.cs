using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private readonly NLog nLog = new NLog();
        public List<ContactDetails> contactList = new List<ContactDetails>();

        public void AddContact()
        {
            ContactDetails contact = new ContactDetails();
            if(contact.firstName == "" || contact.lastName == "" || contact.address == "" || contact.city == "" || contact.state == "" || contact.zip == "" || contact.phoneNum == "" || contact.eMail == "")
            {
                //Just to mark that this operation was unsuccessful
                nLog.LogDebug("Operation Unsuccessful: AddContact()");
                //Just to make note that whatever values entered should be greater than zero
                nLog.LogError("Values entered by user cannot be empty string");
                //Just to warn that values should be non empty
                nLog.LogWarn("Entry should not be empty");
            }
            
            contactList.Add(contact);
            Console.WriteLine("Contact created successfully with following details: ");
            Console.WriteLine("First Name: "+ contact.firstName + " Last Name: " + contact.lastName);
            Console.WriteLine("Address: " + contact.address + " \nCity: " + contact.city + " \nState: " + contact.state);
            Console.WriteLine("Zip Code: " + contact.zip + " \nPhone Number: " + contact.phoneNum + " \nEMail ID: " + contact.eMail);

            nLog.LogDebug("Log Successful: AddContact()");
            //Just to mark a flag that this operation was successful
            nLog.LogInfo("Contact Created with first name: " + contact.firstName + " last name: " + contact.lastName);
        }
    }
}
