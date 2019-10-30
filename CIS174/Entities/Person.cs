using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Entities
{
    public class Person
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        public string City{ get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        public string State { get; set; }

        public ICollection<Accomplishment> Accomplishments { get; set; }
    }
}
