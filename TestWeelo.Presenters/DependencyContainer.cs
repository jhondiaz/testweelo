using Microsoft.Extensions.DependencyInjection;
using TestWeelo.Presenters.Owner;
using TestWeelo.Presenters.Properties;
using TestWeelo.Presenters.PropertyImages;
using TestWeelo.UseCasesPorts.OwnerPorts;
using TestWeelo.UseCasesPorts.PropertiesPorts;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreatePropertyImageOutputPort, CreatePropertyImagePresenter>();
            services.AddScoped<ICreatePropertyOutputPort, CreatePropertyPresenter>();
            services.AddScoped<ICreateOwnerOutputPort, CreateOwnerPresenter>();
            services.AddScoped<IGetPropertiesOutputPort, GetPropertiesPresenter>();
            services.AddScoped<IGetPropertyImagesOutputPort, GetPropertyImagesPresenter>();
            services.AddScoped<IUpdatePropertyOutputPort, UpdatePropertyPresenter>();
            services.AddScoped<IGetPropertyOutputPort, GetPropertyPresenter>();
            return services;
        }
    }
}
