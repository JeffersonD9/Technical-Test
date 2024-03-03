using Microsoft.Extensions.DependencyInjection;
using Technical_Test.Services;
namespace Technical_Test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            configureServices(services);

            using(var serviceProvider = services.BuildServiceProvider()){

                var FrClient = serviceProvider.GetRequiredService<FrClient>();
                Application.Run(FrClient);
            }
        }
    
        private static void configureServices(ServiceCollection services)
        {
            //Inyections FrClient

            services.AddScoped<IService, Service>()
                    .AddScoped<FrClient>();

            services.AddScoped<IPagination, PaginationService>()
                   .AddScoped<FrClient>();

            //Inyection Services 

            services.AddScoped<IDataTables, DataTableService>()
                    .AddScoped<Service>();
        }
       
    }
}