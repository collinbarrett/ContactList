using Data.Contexts;
using Data.DependencyInjection.Extensions;
using Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddContactListRepositories();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });

            var context = app.ApplicationServices.GetService<ContactsDbContext>();
            LoadTestData(context);
        }

        private static void LoadTestData(ContactsDbContext context)
        {
            //TODO: load from XML
            var testContact = new Contact
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Pottida",
                EmailAddress = "joe@pottida.com",
                BusinessPhone = "1-800-555-5555",
                HomePhone = "1-800-555-5554",
                MobilePhone = "1-800-555-5553",
                StreetAddress = "123 S. Main St.",
                City = "Kalamazoo",
                State = "MI",
                ZipCode = "55555",
                Notes = "Joe is a person."
            };
            context.Contacts.Add(testContact);
            context.SaveChanges();
        }
    }
}