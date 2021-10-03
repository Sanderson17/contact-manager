using System;

namespace contact_manager
{
    class ContactManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a task to run (Add contact, Remove contact, Show total # of contacts, Exit Program:");
            var selectedTask = Console.ReadLine();
        }
    }
}
