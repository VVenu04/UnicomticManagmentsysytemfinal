using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Models;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Controller
{
    internal class LoginController
    {
        public static User Authenticate(string username, string password, string role)
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password AND Role = @role";

            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3)
                        };
                    }
                }
            }

            return null; // login failed
        }
    }
}
