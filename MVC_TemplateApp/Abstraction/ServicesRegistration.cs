using MVC_TemplateApp.Abstraction.Service;
using MVC_TemplateApp.Services;

namespace MVC_TemplateApp.Abstraction
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFileService, FileService>();

            return services;
        }
    }
}
