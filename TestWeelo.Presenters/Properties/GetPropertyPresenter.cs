using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.UseCasesPorts.PropertiesPorts;

namespace TestWeelo.Presenters.Properties
{
    public class GetPropertyPresenter : IGetPropertyOutputPort, IPresenter<PropertyDTO>
    {
        public PropertyDTO Content { get; private set; }

        public Task Handle(PropertyDTO property)
        {
            Content = property;
            return Task.CompletedTask;
        }
    }
}
