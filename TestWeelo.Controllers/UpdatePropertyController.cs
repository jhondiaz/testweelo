﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.Presenters;
using TestWeelo.UseCasesPorts.PropertiesPorts;

namespace TestWeelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePropertyController
    {
        private readonly IUpdatePropertyInputPort _inputPort;
        private readonly IUpdatePropertyOutputPort _outputPort;
        public UpdatePropertyController(IUpdatePropertyInputPort inputPort, IUpdatePropertyOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);
        [HttpPost]
        public async Task<PropertyDTO> CreateProperty(UpdatePropertyDTO property)
        {
            await _inputPort.Handle(property);
            return ((IPresenter<PropertyDTO>)_outputPort).Content;
        }
    }

}
