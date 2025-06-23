using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Controller
{
    internal class LecturerController
    {
        public static bool AddLecturerWithUser(string username, string fullName, int age, string address, string nic, string gender, string className, int subjectId, out string error)
        {
            error = "";

            try
            {
                var conn = DatabaseManager.GetConnection();

                // Step 1: Add User
                string password = "password@123";
                string role = "Lecturer";

                string insertUser = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)";
                using (var userCmd = new SQLiteCommand(insertUser, conn))
                {
                    userCmd.Parameters.AddWithValue("@u", username);
                    userCmd.Parameters.AddWithValue("@p", password);
                    userCmd.Parameters.AddWithValue("@r", role);
                    userCmd.ExecuteNonQuery();
                }

                long userId = conn.LastInsertRowId;

                // Step 2: Add to Lecturers
                string insertLecturer = @"INSERT INTO Lecturers (FullName, Age, Address, NIC, Gender, Class, SubjectID, UserID)
                                  VALUES (@full, @age, @addr, @nic, @gender, @class, @subject, @uid)";
                using (var lecCmd = new SQLiteCommand(insertLecturer, conn))
                {
                    lecCmd.Parameters.AddWithValue("@full", fullName);
                    lecCmd.Parameters.AddWithValue("@age", age);
                    lecCmd.Parameters.AddWithValue("@addr", address);
                    lecCmd.Parameters.AddWithValue("@nic", nic);
                    lecCmd.Parameters.AddWithValue("@gender", gender);
                    lecCmd.Parameters.AddWithValue("@class", className);
                    lecCmd.Parameters.AddWithValue("@subject", subjectId);
                    lecCmd.Parameters.AddWithValue("@uid", userId);
                    lecCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                error = "Registration error: " + ex.Message;
                return false;
            }
        }

        public static DataTable GetSubjects()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT SubjectID, SubjectName FROM Subjects ORDER BY SubjectName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public static bool UpdateLecturer(int id, string fullName, int age, string address, string nic, string gender, string className, int subjectId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string updateQuery = @"UPDATE Lecturers SET 
                                        FullName = @full, 
                                        Age = @age, 
                                        Address = @addr, 
                                        NIC = @nic, 
                                        Gender = @gender, 
                                        Class = @class, 
                                        SubjectID = @subject 
                                      WHERE LecturerID = @id";
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@full", fullName);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@addr", address);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@class", className);
                    cmd.Parameters.AddWithValue("@subject", subjectId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error updating lecturer: " + ex.Message;
                return false;
            }
        }

        public static DataTable GetAllLecturers()
        {
            var conn = DatabaseManager.GetConnection();
            string query = @"SELECT l.LecturerID, u.Username, l.FullName, l.Age, l.Address, l.NIC, l.Gender, l.Class, s.SubjectName
                             FROM Lecturers l
                             JOIN Users u ON l.UserID = u.UserID
                             JOIN Subjects s ON l.SubjectID = s.SubjectID
                             ORDER BY l.FullName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
    }

}
