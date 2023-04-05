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
            string auxIdiomaRegiao = "es"; // en-US, es, pt-BR, etc
                                              //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);

            ApplicationConfiguration.Initialize();
            Application.Run(new PaginaPrincipalForm());

        }
    }
}