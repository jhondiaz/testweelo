using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.Entities.POCOs;

namespace TestWeelo.Entities.Interfaces
{
    public interface IPropertyImageRepository
    {
        void AddImageProperty(PropertyImage propertyImage);
        Task<IEnumerable<PropertyImage>> GetImageProperties(int propertyId);
    }

}


