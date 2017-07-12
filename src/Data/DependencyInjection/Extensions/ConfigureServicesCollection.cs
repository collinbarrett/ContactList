using Data.Contexts;
using Data.Repositories;
using Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Data.DependencyInjection.Extensions
{
    public static class ConfigureServicesCollection
    {
        public static void AddContactListRepositories(this IServiceCollection services)
        {
            services.AddDbContext<ContactsDbContext>(opt => opt.UseInMemoryDatabase());
            services.TryAddScoped<IContactRepository, ContactRepository>();
        }
    }
}