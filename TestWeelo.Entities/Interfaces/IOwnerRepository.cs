using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.Entities.POCOs;

namespace TestWeelo.Entities.Interfaces
{
    public interface IOwnerRepository
    {
        Task CreateOwner(Owner owner);
        Task<Owner> GetOwner(int id);
    }

}


