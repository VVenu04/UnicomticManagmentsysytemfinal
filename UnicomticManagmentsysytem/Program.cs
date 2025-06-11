using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Repositories;
using UnicomticManagmentsysytem.Views;

namespace UnicomticManagmentsysytem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var conn = DatabaseManager.GetConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Check if any users exist
            string checkUserQuery = "SELECT COUNT(*) FROM Users";
            using (var cmd = new SQLiteCommand(checkUserQuery, conn))
            {
                long userCount = (long)cmd.ExecuteScalar();
                if (userCount == 0)
                {
                    // No users? Show RegisterForm
                    Application.Run(new RegisterForm());
                }
                else
                {
                    // Users exist? Show LoginForm
                    Application.Run(new LoginForm());
                }
            }
        }
    }
}
