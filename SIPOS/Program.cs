using Microsoft.Extensions.DependencyInjection;
using SIPOS.Persistence;
using SIPOS.Persistence.Repository;
using SIPOS.Persistence.Repository.Contracts;
using SIPOS.Presentation;
using SIPOS.Presentation.Goods;
using SIPOS.Presentation.Security;
using SIPOS.Services;
using System.Globalization;
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
            var culture = CultureInfo.GetCultureInfo("en-US");
            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;
            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var initForm = serviceProvider.GetRequiredService<FormLogin>();
            Application.Run(initForm);

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddScoped<FormLogin>()
                .AddScoped<MainForm>()
                .AddScoped<FormUserManagement>()
                .AddScoped<FormSupplier>()
                .AddScoped<FormProduct>()
                .AddScoped<FormGoodsOrder>()
                .AddScoped<FormSales>()
                .AddScoped<FormChangeMyPassword>()
                ;

            services.AddSingleton<SiposContext>()
                    .AddScoped<IRepositoryWrapper, RepositoryWrapper>()
                    .AddScoped<ISiposUserManagementService, SiposUserManagementService>()
                    .AddScoped<IServiceCollection, ServiceCollection>()
                    ;

            //services.AddDbContext<RepositoryContext>(options =>
            //   options.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True"));
        }
    }
}
