using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts.Contracts
{
    public interface IContactsDbContext
    {
        DbSet<Contact> Contacts { get; set; }
    }
}