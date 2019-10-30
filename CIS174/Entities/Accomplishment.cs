using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Entities
{
    public class Accomplishment
    {
        public int Id { get; set; }

        public string PersonId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfAccomplishment { get; set; }
    }
}
