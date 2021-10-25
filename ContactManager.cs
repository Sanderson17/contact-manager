using System;

namespace contact_manager
{
    class ContactManager
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;

            do
            {
                Console.Write("Please select a task to run (add contact, remove contact, display contacts or exit program): ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "add contact":
                        var contact = Contact.AddContact();
                        Contact.Contacts.Add(contact);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nContact added.\n");
                        break;
                    case "remove contact":
                        Contact.RemoveContact();
                        break;
                    case "display contacts":
                        Contact.DisplayContacts();
                        break;
                    case "exit program":
                        exitProgram = true;
                        break;
                    default: Console.WriteLine("\nSorry that is not a valid option.\n");
                        break;
                }
            }
            while (!exitProgram);
        }
    }
}