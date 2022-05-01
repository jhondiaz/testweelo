using System.Threading.Tasks;

namespace TestWeelo.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }

}


