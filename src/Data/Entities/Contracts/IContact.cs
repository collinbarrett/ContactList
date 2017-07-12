using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Contracts
{
    public interface IContact
    {
        [Key]
        int Id { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string BusinessPhone { get; set; }
        string HomePhone { get; set; }
        string MobilePhone { get; set; }
        string StreetAddress { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string Notes { get; set; }
    }
}