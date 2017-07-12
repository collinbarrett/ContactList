using System.Collections.Generic;
using System.Xml.Serialization;
using Data.Entities.Contracts;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    internal class ContactRepository : IContactRepository
    {
        /// <summary>
        ///     Get all contacts from XML data source
        /// </summary>
        /// <returns>IEnumerable of contacts</returns>
        public IEnumerable<IContact> GetAll()
        {
            var deserializer = new XmlSerializer(typeof(IEnumerable<IContact>));
            //TODO: load path from appsettings.json
            //using (var streamReader = new StreamReader(@"C:\ContactsList.xml"))
            //{
            //    return (IEnumerable<IContact>) deserializer.Deserialize(streamReader);
            //}
            return null;
        }
    }
}