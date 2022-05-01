using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestWeelo.Presenters;
using TestWeelo.Repository;
using TestWeelo.UseCases;

namespace TestWeelo.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddTestWeeloDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
         
            return services;
        }
    }

}
