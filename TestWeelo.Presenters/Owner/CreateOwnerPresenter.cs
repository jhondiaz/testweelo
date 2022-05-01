using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.DTOs;
using TestWeelo.UseCasesPorts.OwnerPorts;

namespace TestWeelo.Presenters.Owner
{
    public class CreateOwnerPresenter : ICreateOwnerOutputPort, IPresenter<OwnerDTO>
    {
        public OwnerDTO Content { get; private set; }

        public Task Handle(OwnerDTO owner)
        {
            Content = owner;
            return Task.CompletedTask;
        }
    }
}
