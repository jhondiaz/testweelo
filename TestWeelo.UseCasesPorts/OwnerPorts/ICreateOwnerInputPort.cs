using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.OwnerPorts
{
    public interface ICreateOwnerInputPort
    {
        Task Handle(CreateOwnerDTO owner);
    }
}
