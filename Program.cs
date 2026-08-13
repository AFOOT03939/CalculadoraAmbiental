using CalculadoraAmbienta.Handlers;
using CalculadoraAmbienta.PantallaCalculadora;
using CalculadoraAmbienta.PantallaReportes;
using CalculadoraAmbienta.Repositorios;
using CalculadoraAmbienta.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraAmbienta

{
    internal static class Program
    {

        public static ServiceProvider Services { get; private set; }
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

            services.AddScoped<DapperHandler>();
            services.AddScoped<RepositorioReportes>();
            services.AddScoped<PantallaService>();
            services.AddScoped<ExcelService>();

            services.AddTransient<PantallaPrincipal.PantallaPrincipal>();
            services.AddTransient<Calculadora>();
            services.AddTransient<Reportes>();

            Services = services.BuildServiceProvider();

            Application.Run(
                Services.GetRequiredService<PantallaPrincipal.PantallaPrincipal>());
        }
    }
}