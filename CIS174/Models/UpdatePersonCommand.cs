using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Models
{
    public class UpdatePersonCommand
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
