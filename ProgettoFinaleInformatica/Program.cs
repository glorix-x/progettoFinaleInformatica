using ClassLibraryCalendario;
using System.Text.Json;

namespace ProgettoFinaleInformatica {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<Impegno> prova = new List<Impegno>(){
                new Impegno("Prova1", "blablablablabla", DateTime.Now, new DateTime(2026, 5, 6, 16, 0, 0), 2, true),
                new Impegno("Prova2", "Lorem ipsum", DateTime.Now, new DateTime(2026, 5, 7, 10, 0, 0), 5, true)
            };
            File.WriteAllText("impegni.json", JsonSerializer.Serialize(prova));
            Application.Run(new FormCalendario());
        }
    }
}