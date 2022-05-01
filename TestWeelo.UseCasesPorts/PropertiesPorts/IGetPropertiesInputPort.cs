using System.Threading.Tasks;

namespace TestWeelo.UseCasesPorts.PropertiesPorts
{
    public interface IGetPropertiesInputPort
    {
        Task<Task> Handle();
    }
}
