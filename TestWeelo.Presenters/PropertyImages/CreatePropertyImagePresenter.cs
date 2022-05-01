using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.Presenters.PropertyImages
{
    public class CreatePropertyImagePresenter : ICreatePropertyImageOutputPort, IPresenter<PropertyImageDTO>
    {
        public PropertyImageDTO Content { get; private set; }

        public Task Handle(PropertyImageDTO propertyImage)
        {
            Content = propertyImage;
            return Task.CompletedTask;
        }
    }
}
