using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Models
{
    public class HouseViewModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int Bedrooms{ get; set; }
        public int SquareFeet { get; set; }
        public DateTime DateBuilt { get; set; }
        public string Flooring { get; set; }

    }
}
