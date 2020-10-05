using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AddressBookSystem
{
    class ContactDetails
    {
        public string firstName, lastName, address, state, city, eMail;
        public string zip, phoneNum;

        public ContactDetails()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            this.firstName = firstName;

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            this.lastName = lastName;

            Console.WriteLine("Enter Address of Contact");
            string address = Console.ReadLine();
            this.address = address;

            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            this.state = state;

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            this.city = city;

            Console.WriteLine("Enter ZipCode");
            string zipCode = Console.ReadLine();
            this.zip = zipCode;

            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            this.phoneNum = phoneNumber;

            Console.WriteLine("Enter EMail ID");
            string eMailId = Console.ReadLine();
            this.eMail = eMailId;
        }
    }
}
