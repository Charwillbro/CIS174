using CIS174.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174.Models
{
    public class CreateAccomplishmentCommand
    {
        [Required, StringLength(25)]
        public string Name { get; set; }
       
        public string PersonId { get; set; }

        public DateTime DateOfAccomplishment{ get; set; }

        public Accomplishment ToAccomplishment()
        {
            return new Accomplishment
            {
                Name = Name,
                PersonId = PersonId,
                DateOfAccomplishment = DateOfAccomplishment,
            };
        }
    }
}
