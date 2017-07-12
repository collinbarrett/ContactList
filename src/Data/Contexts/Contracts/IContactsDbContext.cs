using Data.Entities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts.Contracts
{
    internal interface IContactsDbContext
    {
        DbSet<IContact> Contacts { get; set; }
    }
}