using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174.Entities
{
    public class RequestResponse
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public DateTime LogTime { get; set; }
    }
}
