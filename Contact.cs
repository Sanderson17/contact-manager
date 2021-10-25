using System;
using System.Collections.Generic;
using System.Linq;

namespace contact_manager

{
    // Contact is the class created to meet project basic requirement 'add 1 class'

    public class Contact
    {
        // this is the list my app creates for project feature requirement 'add a list'

        public static List<Contact> Contacts = new();

        // Contact is the implicit object created to meet project basic requirement 'add 1 object'

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        // the 1st method to meet the basic requirement 'add 3 methods'

        public static Contact AddContact()
        {
            Contact contact = new();

            Console.Write("\nEnter Full Name: ");
            contact.FullName = Console.ReadLine();

            Console.Write("Enter Email Address: ");
            contact.EmailAddress = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            return contact;
        }

        // the 2nd method to meet the basic requirement 'add 3 methods' and feature requirement 'visual data representation'

        public static void DisplayContact(Contact contact)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Full Name: " + contact.FullName);
            Console.WriteLine("Email Address " + contact.EmailAddress);
            Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            Console.WriteLine("*******************************************");
        }

        // the 3rd method to meet the basic requirement 'add 3 methods'

        public static void DisplayContacts()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts found. \n\nHit 'Enter' to display the main menu.");
                Console.ReadLine();
                return;
            }
   
            Console.WriteLine("\nCurrent contacts:\n");
            foreach (var contact in Contacts)
            {
                DisplayContact(contact);
            }
            Console.WriteLine("\n\nHit 'Enter' to display the main menu.");
            Console.ReadLine();
        }

        //my LINQ method checks the contacts list for the first instance of the full name entered by the user for project feature requirement 'use a LINQ query to retrieve information from a list'

        public static void RemoveContact()
        {
            Console.WriteLine("\nEnter the full name of the contact you would like to remove.");
            string fullName = Console.ReadLine();
            Contact contact = Contacts.FirstOrDefault(x => x.FullName.ToLower() == fullName.ToLower());

            if (contact == null)
            {
                Console.WriteLine("\nSorry, the contact could not be found. \n\nHit 'Enter' to display the main menu.");
                Console.ReadLine();
                return;
            }
            Contacts.Remove(contact);
            Console.WriteLine("\nContact removed. \n\nHit 'Enter' to display the main menu.");
            Console.ReadLine();
        }
    }
}

