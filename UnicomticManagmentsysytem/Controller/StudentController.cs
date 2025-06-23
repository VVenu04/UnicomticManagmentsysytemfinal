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
    internal class StudentController
    {
        public static DataTable GetCourses()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT CourseID, CourseName FROM Courses ORDER BY CourseName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        

        public static DataTable GetAllStudents()
        {
            var conn = DatabaseManager.GetConnection();
            string query = @"SELECT s.StudentID, u.Username, s.FullName, s.Age, s.Address, s.NIC, s.Gender, s.Class, c.CourseName
                             FROM Students s
                             JOIN Users u ON s.UserID = u.UserID
                             JOIN Courses c ON s.CourseID = c.CourseID
                             ORDER BY s.FullName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static bool AddStudentWithUser(string username, string fullName, int age, string address, string nic, string gender, string className, int courseId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string password = "password@123";
                string role = "Student";

                string insertUser = "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)";
                using (var userCmd = new SQLiteCommand(insertUser, conn))
                {
                    userCmd.Parameters.AddWithValue("@u", username);
                    userCmd.Parameters.AddWithValue("@p", password);
                    userCmd.Parameters.AddWithValue("@r", role);
                    userCmd.ExecuteNonQuery();
                }

                long userId = conn.LastInsertRowId;

                string insertStudent = @"INSERT INTO Students (FullName, Age, Address, NIC, Gender, Class, CourseID, UserID)
                                        VALUES (@full, @age, @addr, @nic, @gender, @class, @course, @uid)";
                using (var stuCmd = new SQLiteCommand(insertStudent, conn))
                {
                    stuCmd.Parameters.AddWithValue("@full", fullName);
                    stuCmd.Parameters.AddWithValue("@age", age);
                    stuCmd.Parameters.AddWithValue("@addr", address);
                    stuCmd.Parameters.AddWithValue("@nic", nic);
                    stuCmd.Parameters.AddWithValue("@gender", gender);
                    stuCmd.Parameters.AddWithValue("@class", className);
                    stuCmd.Parameters.AddWithValue("@course", courseId);
                    stuCmd.Parameters.AddWithValue("@uid", userId);
                    stuCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                error = "Error adding student: " + ex.Message;
                return false;
            }
        }

        public static bool UpdateStudent(int id, string fullName, int age, string address, string nic, string gender, string className, int courseId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = @"UPDATE Students 
                                 SET FullName = @full, Age = @age, Address = @addr, NIC = @nic, Gender = @gender, Class = @class, CourseID = @course 
                                 WHERE StudentID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@full", fullName);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@addr", address);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@class", className);
                    cmd.Parameters.AddWithValue("@course", courseId);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error updating student: " + ex.Message;
                return false;
            }
        }

        public static bool DeleteStudent(int studentId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = "DELETE FROM Students WHERE StudentID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error deleting student: " + ex.Message;
                return false;
            }
        }
    }
}
