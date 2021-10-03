using System;
using System.Collections.Generic;

namespace contact_manager

{
    public class Contact
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (PhoneNumber == null) isValid = false;
            if (EmailAddress == null) isValid = false;

            return isValid;
        }

        public List<Contact> ShowAllContacts()
        {
            //add code to show complete list of customers

            return new List<Contact>();
        }

        public static void AddContact()
        {
            //add code to add a contact
        }

        public static void RemoveContact()
        {
            //add code to remove a contact
        }

        public static void ExitProgram()
        {
            //add code to exit program
        }
    }
    
}

