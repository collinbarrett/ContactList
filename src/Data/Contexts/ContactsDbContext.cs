using Data.Contexts.Contracts;
using Data.Entities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    internal class ContactsDbContext : DbContext, IContactsDbContext
    {
        public ContactsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<IContact> Contacts { get; set; }
    }
}