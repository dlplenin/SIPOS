using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SIPOS.Persistence;
using SIPOS.Persistence.Repository;
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
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<FormLogin>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            //        .AddScoped<IBusinessLayer, CBusinessLayer>()
            services.AddDbContext<RepositoryContext>(options =>
               options.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True"));
        }
    }
}
