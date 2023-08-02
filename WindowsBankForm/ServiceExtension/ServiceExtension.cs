using Microsoft.Extensions.DependencyInjection;
using Repositories.UnitOfWork.Implementation;
using Repositories.UnitOfWork.Interface;
using Services.UnitOfWork.Implementations;
using Services.UnitOfWork.Interfaces;

namespace WindowsBankForm.ServiceExtension
{
    public static class ServiceExtension
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IServiceUnitOfWork, ServiceUnitOfWork>();
        }
    }
}
