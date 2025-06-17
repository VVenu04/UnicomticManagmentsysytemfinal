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
        public static bool AddUser(string username, string password, string role, string fullName,int age,string address, string nic, string gender, string className, out string error)
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
                    insertProfileQuery = "INSERT INTO Students (FullName, Age, Address, NIC, Gender, Class, UserID) " +
                                         "VALUES (@fullName, @age, @address, @nic, @gender, @class, @userId)";
                }
                else if (role == "Lecturer")
                {
                    insertProfileQuery = "INSERT INTO Lecturers (FullName, Age, Address, NIC, Gender, Class, UserID) " +
                                         "VALUES (@fullName, @age, @address, @nic, @gender, @class, @userId)";
                }
                else if (role == "Admin")
                {
                    insertProfileQuery = "INSERT INTO Admin (FullName, Age, Address, NIC, Gender, UserID) " +
                                         "VALUES (@fullName, @age, @address, @nic, @gender, @userId)";
                }
                else if (role == "Staff")
                {
                    insertProfileQuery = "INSERT INTO Staff (FullName, Age, Address, NIC, Gender, UserID) " +
                                         "VALUES (@fullName, @age, @address, @nic, @gender, @userId)";
                }

                if (insertProfileQuery != null)
                    {

                        using (var cmd = new SQLiteCommand(insertProfileQuery, conn))
                        {
                        cmd.Parameters.AddWithValue("@fullName", fullName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@class", className);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        cmd.ExecuteNonQuery();

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

        public static bool AssignSubjectToStudent(int studentId, int subjectId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = "INSERT OR IGNORE INTO Student_Subject (StudentID, SubjectID) VALUES (@studentId, @subjectId)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static int GetStudentIdByUserId(long userId)
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT StudentID FROM Students WHERE UserID = @userId";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public static int GetLecturerIdByUserId(long userId)
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT LecturerID FROM Lecturers WHERE UserID = @userId";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public static bool AssignSubjectToLecturer(int lecturerId, int subjectId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = "INSERT OR IGNORE INTO Lecturer_Subject (LecturerID, SubjectID) VALUES (@lecturerId, @subjectId)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public static long GetUserIdByUsername(string username)
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT UserID FROM Users WHERE Username = @username";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt64(result) : -1;
            }
        }

        public static bool DeleteUser(int userId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();

                // Delete from role-specific tables
                string[] profileTables = { "Students", "Lecturers", "Staff", "Admin" };

                foreach (string table in profileTables)
                {
                    string profileDelete = $"DELETE FROM {table} WHERE UserID = @userId";
                    using (var cmd = new SQLiteCommand(profileDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Now delete from Users
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
