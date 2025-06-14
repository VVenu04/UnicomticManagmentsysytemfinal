using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Controller
{
    internal class UsersController
    {
        public static bool AddUser(string username, string password, string role, string fullName,int age,string address, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)|| string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(address))
            {
                error = "Username and password cannot be empty.";
                return false;
            }

            if (UserExists(username))
            {
                error = "Username already exists.";
               return false;
            }

            try
            {
                var conn = DatabaseManager.GetConnection();
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                }
                long userId = conn.LastInsertRowId;

                // Insert into role-specific table
                string insertProfileQuery = null;

                if (role == "Student")
                {
                    insertProfileQuery = "INSERT INTO Students (FullName, Age, Address, UserID) VALUES (@fullName, @age, @address, @userId)";
                }
                else if (role == "Lecturer")
                {
                    insertProfileQuery = "INSERT INTO Lecturers (FullName, Age, Address, UserID) VALUES (@fullName, @age, @address, @userId)";
                }
                else if (role == "Staff")
                {
                    insertProfileQuery = "INSERT INTO Staff (FullName, Age, Address, UserID) VALUES (@fullName, @age, @address, @userId)";

                }
                else if (role == "Admin")
                {
                    insertProfileQuery = "INSERT INTO Admin (FullName, Age, Address, UserID) VALUES (@fullName, @age, @address, @userId)";
                    if (insertProfileQuery != null)
                    {

                        using (var cmd = new SQLiteCommand(insertProfileQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@fullName", fullName);
                            cmd.Parameters.AddWithValue("@age", age);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        
                    }
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Database error: " + ex.Message;
                return false;
            }
        }

        //  Check if user exists by username
        public static bool UserExists(string username)
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        //  Get all users for DataGridView
        public static DataTable GetAllUsers()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT UserID, Username, Role FROM Users";
            using (var cmd = new SQLiteCommand(query, conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static bool DeleteUser(int userId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = "DELETE FROM Users WHERE UserID = @userId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        error = "User not found.";
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error deleting user: " + ex.Message;
                return false;
            }
        }
    }
}
