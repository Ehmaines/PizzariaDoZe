using System.Configuration;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string? auxIdiomaRegiao =
                (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
                ConfigurationManager.AppSettings.Get("IdiomaRegiao") : ""; // en-US, es, pt-BR, etc
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            ApplicationConfiguration.Initialize();
            Application.Run(new PaginaPrincipalForm());

        }
    }
}