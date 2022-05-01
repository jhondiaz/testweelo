using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface ICreatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
