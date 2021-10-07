namespace contact_manager

{
    // Contact is the class I created to meet project basic requirement add 1 class

    public class Contact
    {
        // Contact is the implicit object I created to meet project basic requirement add 1 object

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public bool Validate() //not working - want to have validations requiring values to be entered for these, MAYBE try to validate format entered
        {
            var isValid = true;
            if (PhoneNumber == null) isValid = false;
            if (EmailAddress == null) isValid = false;

            return isValid;
        }
    }   
}

