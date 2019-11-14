using CIS174.Models;
using CIS174.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CIS174
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//instructed by the Identity readme
            var connectionString = "Server = tcp:cis174cwbroderick.database.windows.net,1433; Initial Catalog = CIS174; Persist Security Info = False; User ID = charwillbro; Password =PublicServerPassword1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            services.AddDbContext<PersonAccomplishmentContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<PersonAccomplishmentContext>();
            services.AddScoped<PersonService>();
            services.AddScoped<ExceptionLogService>();

            var identityConnectionString = "Server = tcp:cis174cwbroderick.database.windows.net,1433; Initial Catalog = CIS174; Persist Security Info = False; User ID = charwillbro; Password =PublicServerPassword1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(identityConnectionString));
            services.AddScoped<IdentityContext>();



            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().AddXmlSerializerFormatters();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(); //instructed by the Identity readme


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //  name: "view_Students",
                //  template: "{controller=Assignment6_1}/{action=Index}/{accessLevel:range(1,10)}",
                //  defaults: new { accessLevel = 1 });

            });
        }
    }
}
