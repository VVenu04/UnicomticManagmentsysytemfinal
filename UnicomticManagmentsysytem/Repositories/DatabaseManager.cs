using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace UnicomticManagmentsysytem.Repositories
{
    public class DatabaseManager
    {
        private static SQLiteConnection Connection;
        public static SQLiteConnection GetConnection()
        {
            if (Connection == null)
            {
                if (!File.Exists("unicomtic.db"))
                {
                    SQLiteConnection.CreateFile("unicomtic.db");
                }
                Connection = new SQLiteConnection("Data Source=unicomtic.db;Version=3;");
                Connection.Open();
                CreateTables();
            }
            return Connection;
        }
        private static void CreateTables()
        {
            var commands = new[]
            {
                @"CREATE TABLE IF NOT EXISTS Users(UserID INTEGER PRIMARY KEY, Username TEXT, Password TEXT, Role TEXT);",
                @"CREATE TABLE IF NOT EXISTS Courses(CourseID INTEGER PRIMARY KEY, CourseName TEXT);",
                @"CREATE TABLE IF NOT EXISTS Subjects(SubjectID INTEGER PRIMARY KEY, SubjectName TEXT, CourseID INTEGER);",
                @"CREATE TABLE IF NOT EXISTS Students(StudentID INTEGER PRIMARY KEY, Name TEXT, CourseID INTEGER);",
                @"CREATE TABLE IF NOT EXISTS Exams(ExamID INTEGER PRIMARY KEY, ExamName TEXT, SubjectID INTEGER);",
                @"CREATE TABLE IF NOT EXISTS Marks(MarkID INTEGER PRIMARY KEY, StudentID INTEGER, ExamID INTEGER, Score INTEGER);",
                @"CREATE TABLE IF NOT EXISTS Rooms(RoomID INTEGER PRIMARY KEY, RoomName TEXT, RoomType TEXT);",
                @"CREATE TABLE IF NOT EXISTS Timetables(TimetableID INTEGER PRIMARY KEY, SubjectID INTEGER, TimeSlot TEXT, RoomID INTEGER);"
            };

            foreach (var commandText in commands)
            {
                using (var cmd = new SQLiteCommand(commandText, Connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
