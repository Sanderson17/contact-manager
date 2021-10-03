namespace contact_manager

{
    public class ContactRepository
    {
        public ContactRepository()
        {
            var contactRepository = new ContactRepository();
            var contact1 = new Contact
            {
                FirstName = "Andie",
                LastName = "Fox",
                EmailAddress = "foxynk@gmail.com",
                PhoneNumber = "502-235-1189"
            };

            var contact2 = new Contact
            {
                FirstName = "Steph",
                LastName = "Baldwin",
                EmailAddress = "Sbaldwin@gmail.com",
                PhoneNumber = "812-229-3528"
            };

            var contact3 = new Contact
            {
                FirstName = "Charles",
                LastName = "Kirk",
                EmailAddress = "KirkC@yahoo.com",
                PhoneNumber = "859-252-7783"
            };

            var contact4 = new Contact
            {
                FirstName = "James",
                LastName = "Patton",
                EmailAddress = "JPatton@hotmail.com",
                PhoneNumber = "502-441-9970"
            };
        }
    }
}
