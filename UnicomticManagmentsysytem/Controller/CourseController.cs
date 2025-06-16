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
    internal class CourseController
    {
        private SQLiteConnection conn = DatabaseManager.GetConnection();

        public long AddOrGetCourse(string courseName)
        {
            string checkQuery = "SELECT CourseID FROM Courses WHERE CourseName = @name";
            using (var cmd = new SQLiteCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@name", courseName);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt64(result);
            }

            string insertQuery = "INSERT INTO Courses (CourseName) VALUES (@name)";
            using (var cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@name", courseName);
                cmd.ExecuteNonQuery();
                return conn.LastInsertRowId;
            }
        }

        public long AddSubject(string subjectName, long courseId)
        {
            string insert = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@sname, @cid)";
            using (var cmd = new SQLiteCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@sname", subjectName);
                cmd.Parameters.AddWithValue("@cid", courseId);
                cmd.ExecuteNonQuery();
                return conn.LastInsertRowId;
            }
        }

        public void LinkSubjectToCourse(long courseId, long subjectId)
        {
            string link = "INSERT INTO Courses_Subject (CourseID, SubjectID) VALUES (@cid, @sid)";
            using (var cmd = new SQLiteCommand(link, conn))
            {
                cmd.Parameters.AddWithValue("@cid", courseId);
                cmd.Parameters.AddWithValue("@sid", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddCourseWithSubject(string courseName, string subjectName)
        {
            long courseId = AddOrGetCourse(courseName);
            long subjectId = AddSubject(subjectName, courseId);
            LinkSubjectToCourse(courseId, subjectId);
        }

        public DataTable GetAllCourses()
        {
            string query = "SELECT CourseID, CourseName FROM Courses GROUP BY CourseName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCoursesWithSubjects()
        {
            var conn = DatabaseManager.GetConnection();
            string query = @"
            SELECT 
                s.SubjectID,
                c.CourseName,
                s.SubjectName
            FROM 
                Courses_Subject cs
            JOIN Courses c ON cs.CourseID = c.CourseID
            JOIN Subjects s ON cs.SubjectID = s.SubjectID
            ORDER BY c.CourseName, s.SubjectName";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public void UpdateSubject(long subjectId, string newName)
        {
            string query = "UPDATE Subjects SET SubjectName = @name WHERE SubjectID = @id";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", newName);
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteSubject(long subjectId)
        {
            // Optional: remove from Courses_Subject
            string deleteLink = "DELETE FROM Courses_Subject WHERE SubjectID = @id";
            using (var cmd = new SQLiteCommand(deleteLink, conn))
            {
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
            }

            // Then delete subject
            string query = "DELETE FROM Subjects WHERE SubjectID = @id";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
