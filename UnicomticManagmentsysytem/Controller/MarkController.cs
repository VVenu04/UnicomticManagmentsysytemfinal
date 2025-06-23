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

        // Returns DataTable of Exams (using SQLiteCommand + Reader)
        public DataTable GetAllExams()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ExamID, ExamName FROM Exams";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            return dt;
        }






        // Returns DataTable of Students
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            string query = "SELECT StudentID, FullName FROM Students";

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);  // Load the DataTable from the reader
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error fetching students: " + ex.Message);
            }

            return dt;
        }






        // Insert new mark
        public void AddMark(long studentId, long examId, int score)
        {
            string insert = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@sid, @eid, @score)";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            using (var cmd = new SQLiteCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@eid", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
            }
        }





        // Get all marks with joined details
        public DataTable GetAllMarksWithDetails()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    m.MarkID,
                    s.FullName AS StudentName,
                    e.ExamName AS ExamName,
                    m.Score
                FROM Marks m
                JOIN Students s ON m.StudentID = s.StudentID
                JOIN Exams e ON m.ExamID = e.ExamID";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            return dt;
        }









        public void UpdateMark(long markId, long studentId, long examId, int score)
        {
            string update = "UPDATE Marks SET StudentID = @sid, ExamID = @eid, Score = @score WHERE MarkID = @mid";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            using (var cmd = new SQLiteCommand(update, conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@eid", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@mid", markId);
                cmd.ExecuteNonQuery();
            }
        }





        // Delete mark by MarkID
        public void DeleteMark(long markId)
        {
            string delete = "DELETE FROM Marks WHERE MarkID = @mid";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            using (var cmd = new SQLiteCommand(delete, conn))
            {
                cmd.Parameters.AddWithValue("@mid", markId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

