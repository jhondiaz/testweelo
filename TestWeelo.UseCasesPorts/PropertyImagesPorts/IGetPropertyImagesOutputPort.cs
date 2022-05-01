using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertyImagesPorts
{
    public interface IGetPropertyImagesOutputPort
    {
        Task Handle(IEnumerable<PropertyImageDTO> propertyImages);
    }
}
