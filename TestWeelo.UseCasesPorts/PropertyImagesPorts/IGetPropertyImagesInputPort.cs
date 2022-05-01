using System.Threading.Tasks;

namespace TestWeelo.UseCasesPorts.PropertyImagesPorts
{
    public interface IGetPropertyImagesInputPort
    {
        Task<Task> Handle(int propertyId);
    }
}
