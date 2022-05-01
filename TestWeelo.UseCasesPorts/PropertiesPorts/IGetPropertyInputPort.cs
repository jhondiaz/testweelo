using System.Threading.Tasks;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IGetPropertyInputPort
    {
        Task<Task> Handle(int id);
    }
}
