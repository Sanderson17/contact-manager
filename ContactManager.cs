using System;
using LINQ;

namespace contact_manager
{
    class ContactManager
    {
        static void Main(string[] args)
        {

            var contact = new Contact();

            vm.totalContacts();

            addContact();

            removeContact();

            Console.WriteLine("Please select a task to run (Show total # of contacts, Add contact, Remove contact, or Exit Program:");
            var selectedTask = Console.ReadLine();

        }
    }
}
