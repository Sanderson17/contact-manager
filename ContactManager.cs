using System;
using System.Collections.Generic;
using System.Linq;

namespace contact_manager
{
    class ContactManager
    {
        // this is the list my app creates for project feature requirement add a list

        public static List<Contact> Contacts = new ();

        // the 1st method to meet the basic requirement add 3 methods

        public static void AddContact()
        {
            Contact contact = new();

            Console.WriteLine("\nEnter Full Name: ");
            contact.FullName = Console.ReadLine();

            Console.WriteLine("Enter Email Address: ");
            contact.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Contacts.Add(contact);

            Console.WriteLine("\nContact added. \n\nHit 'Enter' to return to the menu.");
            Console.ReadLine();
        }

        // the 2nd method to meet the basic requirement add 3 methods and feature requirement visual data representation

        public static void DisplayContact(Contact contact)
        {
            Console.WriteLine("Full Name: " + contact.FullName);
            Console.WriteLine("Email Address " + contact.EmailAddress);
            Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            Console.WriteLine("*******************************************");
        }

        // the 3rd method to meet the basic requirement add 3 methods

        public static void DisplayContacts()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("\nNo contacts found. \n\nHit 'Enter' to return to the menu.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("\nCurrent contacts:\n");
            foreach (var contact in Contacts)
            {
                DisplayContact(contact);
            }
            Console.WriteLine("\n\nHit 'Enter' to return to the menu.");
            Console.ReadLine();
        }

        //my LINQ method checks the contacts list for the first instance of the full name entered by the user for project feature requirement use a LINQ query to retrieve information from a list

        public static void RemoveContact()
        {
            Console.WriteLine("\nEnter the full name of the contact you would like to remove.");
            string fullName = Console.ReadLine();
            Contact contact = Contacts.FirstOrDefault(x => x.FullName.ToLower() == fullName.ToLower());

            if (contact == null)
            {
                Console.WriteLine("\nSorry, the contact could not be found. \nHit 'Enter' to return to the menu.");
                Console.ReadLine();
                return;
            }
                Contacts.Remove(contact);
                Console.WriteLine("\nContact removed. \nHit 'Enter' to return to the menu.");
                Console.ReadLine();   
        }

        static void Main(string[] args)
        {
            bool exitProgram = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Please select a task to run (add contact, remove contact, display contacts or exit program): ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "add contact":
                        AddContact();
                        break;
                    case "remove contact":
                        RemoveContact();
                        break;
                    case "display contacts":
                        DisplayContacts();
                        break;
                    case "exit program":
                        exitProgram = true;
                        break;
                    default: Console.WriteLine("Sorry that's not a valid option.");
                        break;
                }
            }
            while (!exitProgram);
        }
    }
}