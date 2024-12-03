using CRM_system.Admins_Forms;
using CRM_system.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_system
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database before running the main form
            var dbInitializer = new DatabaseInitializer();
            dbInitializer.InitializeDatabase();

            Application.Run(new Login());

        }
    }
}
