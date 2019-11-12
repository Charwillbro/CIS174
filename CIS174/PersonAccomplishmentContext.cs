using CIS174.Entities;
using Microsoft.EntityFrameworkCore;

namespace CIS174
{
    public class PersonAccomplishmentContext : DbContext
    {
        public PersonAccomplishmentContext(DbContextOptions<PersonAccomplishmentContext>options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Accomplishment> Accomplishments { get; set; }
        public DbSet<ExceptionLog> Exceptions { get; set; }
        public DbSet<RequestResponse> RequestResponses { get; set; }
    }
}
