using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Models;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Controller
{
    internal class TimetableController
    {
        private SQLiteConnection conn = DatabaseManager.GetConnection();

        public static DataTable GetAllTimetables()
        {
             var conn = DatabaseManager.GetConnection();
            string query = @"SELECT 
                                t.TimetableID, 
                                s.SubjectName, 
                                t.Class,
                                r.RoomName, 
                                r.RoomType, 
                                
                                t.Day, 
                                t.Time
                            FROM Timetables t
                            JOIN Subjects s ON t.SubjectID = s.SubjectID
                            JOIN Rooms r ON t.RoomID = r.RoomID
                            JOIN Lecturers l ON t.LecturerID = l.LecturerID
                            ORDER BY t.Day, t.Time";
            try
            {
                using (var adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Timetable load error: " + ex.Message);
                return null;
            }
        }

        public static bool AddTimetable(int subjectId, int roomId, int lecturerId, string day, string time, string className, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(day) || string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(className))
            {
                error = "All fields are required.";
                return false;
            }

            try
            {
                var conn = DatabaseManager.GetConnection();
                string insert = @"INSERT INTO Timetables (SubjectID, RoomID, LecturerID, Day, Time, Class) 
                                  VALUES (@subjectId, @roomId, @lecturerId, @day, @time, @class)";
                using (var cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@class", className);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error adding timetable: " + ex.Message;
                return false;
            }
        }

        public static bool DeleteTimetable(int id, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = "DELETE FROM Timetables WHERE TimetableID = @id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error deleting entry: " + ex.Message;
                return false;
            }
        }

        public static DataTable GetRooms()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT RoomID, RoomName FROM Rooms ORDER BY RoomName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
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

        public static DataTable GetLecturers()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT LecturerID, FullnameName FROM Lecturers ORDER BY FullnameName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

