using CKK.Logic.Models;
using CKK.Persistance.Interfaces;
using CKK.Persistance.Models;
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
            loginForm loginform = new loginForm();
            Application.Run(loginform);
            FileStore store = new FileStore();
            if(loginform.DialogResult == DialogResult.OK)
            {
                Application.Run(new InventoryManagementForm(store));
            }
            
            
        }
    }
}