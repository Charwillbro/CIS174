using CIS174.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
