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
    internal class AttendanceController
    {
        public static bool MarkAttendance(int studentId, int subjectId, string date, string status, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string query = @"INSERT OR REPLACE INTO Attendance (StudentID, SubjectID, Date, Status)
                                VALUES (@sid, @subid, @date, @status)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    cmd.Parameters.AddWithValue("@subid", subjectId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@status", status);
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

        public static DataTable GetStudents()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT StudentID, FullName FROM Students ORDER BY FullName";
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

        public static DataTable GetAllAttendance()
        {
            var conn = DatabaseManager.GetConnection();
                string query = @"
                SELECT 
                    a.AttendanceID, 
                    s.FullName AS Student, 
                    sub.SubjectName AS Subject, 
                    a.Date, 
                    a.Status 
                FROM Attendance a
                JOIN Students s ON a.StudentID = s.StudentID
                JOIN Subjects sub ON a.SubjectID = sub.SubjectID
                ORDER BY a.Date DESC";

            using (var cmd = new SQLiteCommand(query, conn))
            using (var adapter = new SQLiteDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
