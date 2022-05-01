using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Presenters;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePropertyImagesController
    {
        private readonly ICreatePropertyImageInputPort _inputPort;
        private readonly ICreatePropertyImageOutputPort _outputPort;
        public CreatePropertyImagesController(ICreatePropertyImageInputPort inputPort, ICreatePropertyImageOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<PropertyImageDTO> CreatePropertyImage(CreatePropertyImageDTO property)
        {
            await _inputPort.Handle(property);
            return ((IPresenter<PropertyImageDTO>)_outputPort).Content;
        }
    }

}
