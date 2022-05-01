using System;
using System.Text;
using System.Threading.Tasks;
using TestWeelo.Entities.Interfaces;
using TestWeelo.Entities.POCOs;
using TestWeelo.Repositories.EFCore.DataContexts;

namespace TestWeelo.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly TestWeeloContext _context;
        public OwnerRepository(TestWeeloContext context) =>
            _context = context;
        public async Task CreateOwner(Owner owner)
        {
            await _context.AddAsync(owner);
        }

        public async Task<Owner> GetOwner(int id)
        {
            var owner = await _context.Owner.FindAsync(id);
            return owner;
        }
    }
}
