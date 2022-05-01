using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.Presenters.PropertyImages
{
    public class GetPropertyImagesPresenter : IGetPropertyImagesOutputPort, IPresenter<IEnumerable<PropertyImageDTO>>
    {
        public IEnumerable<PropertyImageDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyImageDTO> propertyImages)
        {
            Content = propertyImages;
            return Task.CompletedTask;
        }
    }
}
