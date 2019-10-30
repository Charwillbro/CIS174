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
    }
}
