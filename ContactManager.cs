using System;

namespace contact_manager
{
    class ContactManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a task to run (Show all contacts, Add contact, Remove contact, or Exit Program:");
            var selectedTask = Console.ReadLine();

            ShowAllContacts(); //add method code to customer class

            AddContact(); //add method code to customer class

            RemoveContact(); //add method code to customer class

            ExitProgram(); //add method code to customer class to quit 

        }
    }
}
