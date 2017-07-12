using System.Collections.Generic;
using Data.Entities.Contracts;

namespace Data.Repositories.Contracts
{
    internal interface IContactRepository
    {
        /// <summary>
        ///     Get all contacts from XML data source
        /// </summary>
        /// <returns>IEnumerable of contacts</returns>
        IEnumerable<IContact> GetAll();
    }
}