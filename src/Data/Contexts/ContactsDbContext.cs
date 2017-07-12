using Data.Contexts.Contracts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class ContactsDbContext : DbContext, IContactsDbContext
    {
        public ContactsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}