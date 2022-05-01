using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.UseCasesPorts.PropertiesPorts;

namespace TestWeelo.Presenters.Properties
{
    public class GetPropertiesPresenter : IGetPropertiesOutputPort, IPresenter<IEnumerable<PropertyDTO>>
    {
        public IEnumerable<PropertyDTO> Content { get; private set; }

        public Task Handle(IEnumerable<PropertyDTO> properties)
        {
            Content = properties;
            return Task.CompletedTask;
        }
    }
}
