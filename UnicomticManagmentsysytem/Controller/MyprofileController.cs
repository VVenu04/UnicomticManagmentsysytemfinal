using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Repositories;
using UnicomticManagmentsysytem.Models;

namespace UnicomticManagmentsysytem.Controller
{
    internal class MyprofileController
    {
        public Myprofile GetUserProfile(string username, string role)
        {
            var conn = DatabaseManager.GetConnection();

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int userId = -1;
            string userQuery = "SELECT UserID FROM Users WHERE LOWER(Username) = LOWER(@username)";

            using (var cmdUser = new SQLiteCommand(userQuery, conn))
            {
                cmdUser.Parameters.AddWithValue("@username", username);
                using (var reader = cmdUser.ExecuteReader())
                {
                    if (reader.Read())
                        userId = Convert.ToInt32(reader["UserID"]);
                    else
                        throw new Exception("User not found.");
                }
            }


            // Step 2: Determine table name by role
            string roleTable = role == "Student" ? "Students" :
                                   role == "Staff" ? "Staff" :
                                   role == "Admin" ? "Admin" :
                                   role == "Lecturer" ? "Lecturers" : null;

                if (roleTable == null)
                    throw new Exception("Invalid role specified.");

                // Step 3: Get user profile from role table
                string roleQuery = $"SELECT * FROM {roleTable} WHERE UserID = @userId";

                using (var cmdRole = new SQLiteCommand(roleQuery, conn))
                {
                    cmdRole.Parameters.AddWithValue("@userId", userId);
                    using (var reader = cmdRole.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Myprofile
                            {
                                Username = username,
                                Role = role,
                                FullName = reader["FullName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Address = reader["Address"].ToString(),
                                NIC = reader["NIC"].ToString(),
                                Gender = reader["Gender"].ToString()
                            };
                        }
                        else
                        {
                            throw new Exception($"Profile not found in {roleTable} table.");
                        }
                    }
                }
            }
        }
    }


