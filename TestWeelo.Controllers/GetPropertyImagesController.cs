using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Presenters;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPropertyImagesController
    {
        private readonly IGetPropertyImagesInputPort _inputPort;
        private readonly IGetPropertyImagesOutputPort _outputPort;
        public GetPropertyImagesController(IGetPropertyImagesInputPort inputPort, IGetPropertyImagesOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpGet("{id}")]
        public async Task<IEnumerable<PropertyImageDTO>> GetProperties(int id)
        {
            await _inputPort.Handle(propertyId: id);
            return ((IPresenter<IEnumerable<PropertyImageDTO>>)_outputPort).Content;
        }
    }

}
