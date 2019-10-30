using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174.Entities
{
    public class Accomplishment
    {
        public int Id { get; set; }

        public string PersonId { get; set; }

        [StringLength(25, ErrorMessage = "Maximum length is 25")]
        public string Name { get; set; }

        [Display(Name = "Date of Accomplishment")]
        public DateTime DateOfAccomplishment { get; set; }
    }
}
