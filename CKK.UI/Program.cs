using CKK.DB.UOW;
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
            loginForm loginform = new loginForm();
            Application.Run(loginform);
            var conn = new DatabaseConnectionFactory();
            var uow = new UnitOfWork(conn);
            if(loginform.DialogResult == DialogResult.OK)
            {
                Application.Run(new InventoryManagementForm(uow));
            }
            
            
        }
    }
}