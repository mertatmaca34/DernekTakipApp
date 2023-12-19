using Autofac.Extensions.DependencyInjection;
using Autofac;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using DernekTakipApp.DependencyResolvers.Autofac;
using DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DernekTakipApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var context = new DTPContext())
            {
                context.Database.EnsureCreated();
            }

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                Application.EnableVisualStyles();

                Application.Run(services.GetRequiredService<FormMain>());
            }

            
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());
                builder.RegisterModule(new AutofacViewModule());
            })
            .ConfigureServices((hostContext, services) =>
            {
                //services.AddDbContext<DTPContext>(options=> options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DTPContext;Trusted_Connection=True;MultipleActiveResultSets=true"));
            });
    }
}