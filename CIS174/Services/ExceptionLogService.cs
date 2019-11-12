using CIS174.Entities;
using CIS174.Models;

namespace CIS174.Services
{
    public class ExceptionLogService
    {
        private readonly PersonAccomplishmentContext _personAccomplishmentContext;
        public ExceptionLogService(PersonAccomplishmentContext demoContext)
        {
            _personAccomplishmentContext = demoContext;
        }

        public void CreateExceptionRecord(CreateExceptionLogCommand cmd)
        {
            var exceptionLogRecord = new ExceptionLog
            {
                LogTime = cmd.LogTime,
                HttpStatusCode = cmd.HttpStatusCode,
                RequestId = cmd.RequestId,
                ExceptionMessage = cmd.ExceptionMessage,
                ExceptionStackTrace = cmd.ExceptionStackTrace
            };

            _personAccomplishmentContext.Add(exceptionLogRecord);
            _personAccomplishmentContext.SaveChanges();
        }
    }
}
