using CKK.Logic.Models;
namespace CKK.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Store store = new Store();
            Application.Run(new InventoryManagementForm(store));
            
        }
    }
}