using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Presenters;
using TestWeelo.UseCasesPorts.PropertiesPorts;

namespace TestWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPropertiesController
    {
        private readonly IGetPropertiesInputPort _inputPort;
        private readonly IGetPropertiesOutputPort _outputPort;
        public GetPropertiesController(IGetPropertiesInputPort inputPort, IGetPropertiesOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet]
        public async Task<IEnumerable<PropertyDTO>> GetProperties()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<PropertyDTO>>)_outputPort).Content;
        }
    }

}
