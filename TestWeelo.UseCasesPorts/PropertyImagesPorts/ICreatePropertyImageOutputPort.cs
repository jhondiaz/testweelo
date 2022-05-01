using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertyImagesPorts
{
    public interface ICreatePropertyImageOutputPort
    {
        Task Handle(PropertyImageDTO propertyImage);
    }
}
