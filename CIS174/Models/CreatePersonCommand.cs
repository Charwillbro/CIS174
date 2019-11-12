using System;

namespace CIS174.Models
{
    public class CreatePersonCommand
    {
   
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string State { get; set; }

    }
}
