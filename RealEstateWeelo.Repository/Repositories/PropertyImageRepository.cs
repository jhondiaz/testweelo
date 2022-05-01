using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeelo.Entities.Interfaces;
using TestWeelo.Entities.POCOs;
using TestWeelo.Repositories.EFCore.DataContexts;

namespace TestWeelo.Repository
{
    public class PropertyImageRepository : IPropertyImageRepository
    {
        private readonly TestWeeloContext _context;
        public PropertyImageRepository(TestWeeloContext context) =>
            _context = context;
        public void AddImageProperty(PropertyImage propertyImage)
        {
            _context.Add(propertyImage);
        }

        public async Task<IEnumerable<PropertyImage>> GetImageProperties(int propertyId)
        {
            return await _context.PropertyImage.Where(w => w.PropertyId == propertyId).ToListAsync();
        }
    }
}
