using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.Entities.POCOs;

namespace TestWeelo.Entities.Interfaces
{
    public interface IPropertyRepository
    {
        Task CreatePropertyAsync(Property property);
        Task UpdatePropertyAsync(Property property);
        Task<IEnumerable<Property>> GetPropertiesAsync();
        Task<Property> GetPropertyAsync(int id);
    }

}


