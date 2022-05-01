using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Presenters;
using TestWeelo.UseCasesPorts.PropertiesPorts;

namespace TestWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPropertyController
    {
        private readonly IGetPropertyInputPort _inputPort;
        private readonly IGetPropertyOutputPort _outputPort;
        public GetPropertyController(IGetPropertyInputPort inputPort, IGetPropertyOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet]
        public async Task<PropertyDTO> GetProperty(int id)
        {
            await _inputPort.Handle(id);
            return ((IPresenter<PropertyDTO>)_outputPort).Content;
        }
    }

}
