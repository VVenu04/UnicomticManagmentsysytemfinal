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
    internal class MarkController
    {
        private SQLiteConnection conn = DatabaseManager.GetConnection();

        public DataTable GetAllExams()
        {
            string query = "SELECT ExamID, ExamName FROM Exams";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllStudents()
        {
            string query = "SELECT StudentID, StudentName FROM Students"; // Adjust column names
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddMark(long studentId, long examId, int score)
        {
            string insert = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@sid, @eid, @score)";
            using (var cmd = new SQLiteCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@eid", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllMarksWithDetails()
        {
            string query = @"
                SELECT 
                    m.MarkID,
                    s.StudentName,
                    e.ExamName,
                    m.Score
                FROM Marks m
                JOIN Students s ON m.StudentID = s.StudentID
                JOIN Exams e ON m.ExamID = e.ExamID";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

