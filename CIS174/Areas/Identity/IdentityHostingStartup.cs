using System;
using CIS174.Areas.Identity.Data;
using CIS174.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CIS174.Areas.Identity.IdentityHostingStartup))]
namespace CIS174.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PersonAccomplishmentContext>(options => //replaced IdentityContext with PersonAccomplishmentContext
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityContextConnection")));

                services.AddDefaultIdentity<PersonIdentityUser>()
                    .AddEntityFrameworkStores<PersonAccomplishmentContext>();
            });
        }
    }
}