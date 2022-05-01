using System.Threading.Tasks;
using TestWeelo.Entities.Interfaces;
using TestWeelo.Repositories.EFCore.DataContexts;

namespace TestWeelo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestWeeloContext _context;
        public UnitOfWork(TestWeeloContext context) =>
            _context = context;
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
