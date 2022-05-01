using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestWeelo.Entities.Interfaces;
using TestWeelo.Entities.POCOs;
using TestWeelo.Repositories.EFCore.DataContexts;

namespace TestWeelo.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly TestWeeloContext _context;
        public PropertyRepository(TestWeeloContext context) =>
            _context = context;

        public async Task CreatePropertyAsync(Property property)
        {
            await _context.AddAsync(property);
        }

        public async Task<IEnumerable<Property>> GetPropertiesAsync()
        {
            return await _context.Property.ToListAsync();
        }

        public async Task<Property> GetPropertyAsync(int id)
        {
            return await _context.Property.FindAsync(id);
        }

        public async Task UpdatePropertyAsync(Property property)
        {
            var dbProperty = await _context.Property.FindAsync(property.Id);
            if (property.OwnerId.HasValue)
                dbProperty.OwnerId = property.OwnerId;
            dbProperty.Price = property.Price;
            dbProperty.CodeInternal = property.CodeInternal;
            dbProperty.Address = property.Address;
            dbProperty.Year = property.Year;
            dbProperty.Name = property.Name;
        }
    }
}
