using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IGetPropertiesOutputPort
    {
        Task Handle(IEnumerable<PropertyDTO> properties);
    }
}
