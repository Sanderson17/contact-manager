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
                Console.WriteLine("\nPlease select a task to run (add contact, remove contact, display contacts or exit program): ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "add contact":
                        Contact.AddContact();
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
                    default: Console.WriteLine("Sorry that's not a valid option.");
                        break;
                }
            }
            while (!exitProgram);
        }
    }
}