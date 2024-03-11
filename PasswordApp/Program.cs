using System;
using System.Windows.Forms;
using Domain.Interfaces.LoginDetails;
using Domain.Services.LoginDetails;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PasswordApp.Forms;

namespace PasswordApp
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Manager>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Register services
                    services.AddTransient<ILoginDetailService, LoginDetailService>();
                    
                    // Register forms
                    services.AddTransient<Manager>();
                    services.AddTransient<AddLoginDetail>();
                });
        }
    }
}