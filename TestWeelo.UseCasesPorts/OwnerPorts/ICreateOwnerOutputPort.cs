using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.OwnerPorts
{
    public interface ICreateOwnerOutputPort
    {
        Task Handle(OwnerDTO owner);
    }
}
