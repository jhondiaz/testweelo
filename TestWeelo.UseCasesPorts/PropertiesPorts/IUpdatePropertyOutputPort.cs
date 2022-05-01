using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IUpdatePropertyOutputPort
    {
        Task Handle(PropertyDTO property);
    }
}
