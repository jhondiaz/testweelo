using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using TestWeelo.UseCases.CreateOwner;
using TestWeelo.UseCases.CreateProperty;
using TestWeelo.UseCases.CreatePropertyImage;
using TestWeelo.UseCases.GetProperties;
using TestWeelo.UseCases.GetPropertyImages;
using TestWeelo.UseCases.Mappings;
using TestWeelo.UseCases.UpdateProperty;
using TestWeelo.UseCasesPorts.OwnerPorts;
using TestWeelo.UseCasesPorts.PropertiesPorts;
using TestWeelo.UseCasesPorts.PropertyImagesPorts;

namespace TestWeelo.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<ICreatePropertyInputPort, CreatePropertyInteractor>();
            services.AddTransient<IUpdatePropertyInputPort, UpdatePropertyInteractor>();
            services.AddTransient<IGetPropertiesInputPort, GetPropertiesInteractor>();
            services.AddTransient<IGetPropertyInputPort, GetPropertyInteractor>();
            services.AddTransient<ICreatePropertyImageInputPort, CreatePropertyImageInteractor>();
            services.AddTransient<IGetPropertyImagesInputPort, GetPropertyImagesInteractor>();
            services.AddTransient<ICreateOwnerInputPort, CreateOwnerInteractor>();
            return services;
        }
    }
}
