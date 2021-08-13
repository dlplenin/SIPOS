using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SIPOS.Persistence;
using SIPOS.Persistence.Repository;
using SIPOS.Services;
using System.Windows.Forms;

namespace SIPOS
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var initForm = serviceProvider.GetRequiredService<FormLogin>();
            Application.Run(initForm);

            //Application.Run(new FormLogin());

            //var builder = new HostBuilder()
            // .ConfigureServices((hostContext, services) =>
            // {
            //     services.AddSingleton<FormLogin>();
            //     services.AddLogging(configure => configure.AddConsole());
            //     services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            //     services.AddScoped<ISiposUserService, SiposUserService>();
            // })
            // .Build();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<FormLogin>();

            services.AddSingleton<SiposContext>()
                    .AddScoped<IRepositoryWrapper, RepositoryWrapper>()
                    .AddScoped<ISiposUserService, SiposUserService>();

            //services.AddDbContext<RepositoryContext>(options =>
            //   options.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True"));
        }
    }
}
