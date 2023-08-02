using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using WindowsBankForm.ServiceExtension;

namespace WindowsBankForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()

                .SetBasePath(Directory.GetCurrentDirectory())

                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<WindowsBankForm>();
            services.AddDbContext<DataContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WindowsBankDb;;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
            services.ConfigureUnitOfWork();
            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var windowsBankForm = serviceProvider.GetRequiredService<WindowsBankForm>();
            Application.Run(windowsBankForm);
        }
    }
}