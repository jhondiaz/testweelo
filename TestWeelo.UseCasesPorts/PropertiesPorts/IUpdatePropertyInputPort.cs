using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IUpdatePropertyInputPort
    {
        Task Handle(UpdatePropertyDTO property);
    }


  
}
