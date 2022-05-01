using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IGetPropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
