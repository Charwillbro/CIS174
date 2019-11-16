using CIS174.Areas.Identity.Data;
using CIS174.Entities;
using CIS174.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CIS174
{
    public class PersonAccomplishmentContext : IdentityDbContext<PersonIdentityUser>
    {
        public PersonAccomplishmentContext(DbContextOptions<PersonAccomplishmentContext> options)
           : base(options)
        {

        }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
       

        public DbSet<Person> People { get; set; }
        public DbSet<Accomplishment> Accomplishments { get; set; }
        public DbSet<ExceptionLog> Exceptions { get; set; }
        public DbSet<RequestResponse> RequestResponses { get; set; }
    }
}
