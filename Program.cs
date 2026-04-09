using Microsoft.VisualBasic;

namespace FurnitureStoreDBMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBInstaller dbInstaller = new DBInstaller();
            DBFacade dbFacade = new DBFacade("Data Source=database.db");
            DBService dBService = new DBService(dbFacade);

            dbInstaller.Install(dbFacade);

            ApplicationConfiguration.Initialize();

            Application.Run(new MainForm(dBService));

        }
    }
}