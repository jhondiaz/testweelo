using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.DTOs;

namespace TestWeelo.UseCasesPorts.PropertyImagesPorts
{
    public interface ICreatePropertyImageInputPort
    {
        Task Handle(CreatePropertyImageDTO propertyImage);
    }
}
