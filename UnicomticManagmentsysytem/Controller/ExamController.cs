using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Repositories;
using System.Xml.Linq;

namespace UnicomticManagmentsysytem.Controller
{
    internal class ExamController
    {
        private SQLiteConnection conn = DatabaseManager.GetConnection();

        public void AddExam(string examName, long subjectId, DateTime examDate)
        {
            string query = "INSERT INTO Exams (ExamName, SubjectID, ExamDate) VALUES (@name, @sid, @date)";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", examName);
                cmd.Parameters.AddWithValue("@sid", subjectId);
                cmd.Parameters.AddWithValue("@date", examDate.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
            }
        }






        public DataTable GetAllSubjects()
        {
            string query = "SELECT SubjectID, SubjectName FROM Subjects";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }





        public void UpdateExam(long examId, string newName, long newSubjectId)
        {
            string query = "UPDATE Exams SET ExamName = @name, SubjectID = @subId WHERE ExamID = @id";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", newName);
                cmd.Parameters.AddWithValue("@subId", newSubjectId);
                cmd.Parameters.AddWithValue("@id", examId);
                cmd.ExecuteNonQuery();
            }
        }










        public void DeleteExam(long examId)
        {
            // Optional: delete related marks first to avoid foreign key conflict
            string deleteMarks = "DELETE FROM Marks WHERE ExamID = @id";
            using (var cmd = new SQLiteCommand(deleteMarks, conn))
            {
                cmd.Parameters.AddWithValue("@id", examId);
                cmd.ExecuteNonQuery();
            }

            string deleteExam = "DELETE FROM Exams WHERE ExamID = @id";
            using (var cmd = new SQLiteCommand(deleteExam, conn))
            {
                cmd.Parameters.AddWithValue("@id", examId);
                cmd.ExecuteNonQuery();
            }
        }








        public DataTable GetAllExamsWithSubjects()
        {
            string query = @"
                SELECT 
                    e.ExamID,
                    e.ExamName,
                    s.SubjectID,
                    s.SubjectName
                FROM Exams e
                JOIN Subjects s ON e.SubjectID = s.SubjectID";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }









        public DataTable SearchExams(string keyword)
        {
            string query = @"
                SELECT e.ExamID, e.ExamName, s.SubjectName, e.ExamDate
                FROM Exams e
                JOIN Subjects s ON e.SubjectID = s.SubjectID
                WHERE e.ExamName LIKE @kw OR s.SubjectName LIKE @kw";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }





        public static DataTable GetAllExams()
        {
            var conn = DatabaseManager.GetConnection();
            string query = @"SELECT e.ExamID, e.ExamName, s.SubjectName, e.ExamDate
                     FROM Exams e
                     JOIN Subjects s ON e.SubjectID = s.SubjectID
                     ORDER BY e.ExamDate";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
