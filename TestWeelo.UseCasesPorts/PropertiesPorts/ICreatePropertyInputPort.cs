using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface ICreatePropertyInputPort
    {
        Task Handle(CreatePropertyDTO property);
    }
}
