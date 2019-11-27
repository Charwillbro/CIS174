using System;

namespace CIS174.Entities
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public DateTime LogTime { get; set; }
        public int HttpStatusCode { get; set; }
        public Guid RequestId { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }
    }
}
