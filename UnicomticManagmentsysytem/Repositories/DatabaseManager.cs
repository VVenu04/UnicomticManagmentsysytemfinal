using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var pragmaCmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", Connection);
                pragmaCmd.ExecuteNonQuery();

                CreateTables();
               /* catch(Exception ex)
{
                    MessageBox.Show("Database error: " + ex.Message);
                }*/

            }

            return Connection;
        }
        private static void CreateTables()
        {
            var commands = new[]
            {
                @"CREATE TABLE IF NOT EXISTS Users
                        (UserID INTEGER PRIMARY KEY AUTOINCREMENT
                       , Username TEXT NOT NULL,
                         Password TEXT NOT NULL, 
                         Role TEXT NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS Courses
                        (CourseID INTEGER PRIMARY KEY,
                         CourseName TEXT NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS Admin
                        (AdminID INTEGER PRIMARY KEY  AUTOINCREMENT,
                         FullName TEXT NOT NULL, 
                         Age INTEGER,
                         Address TEXT ,  
                         UserID INTEGER,
                         FOREIGN KEY (UserID) REFERENCES Users(UserID)
                                                       );",


                @"CREATE TABLE IF NOT EXISTS Staff
                        (StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                         FullName TEXT NOT NULL, 
                         Age INTEGER,
                         Address TEXT ,  
                         UserID INTEGER,
                         FOREIGN KEY (UserID) REFERENCES Users(UserID));",


                @"CREATE TABLE IF NOT EXISTS Subjects
                         (SubjectID INTEGER PRIMARY KEY, 
                          SubjectName TEXT NOT NULL,
                          CourseID INTEGER,
                          FOREIGN KEY (CourseID)  REFERENCES Courses (CourseID));",

                @"CREATE TABLE IF NOT EXISTS Students
                         (StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                           FullName TEXT NOT NULL, 
                            Age INTEGER,
                            Address TEXT,
                         CourseID INTEGER,UserID INTEGER,
                         FOREIGN KEY (UserID) REFERENCES Users(UserID)
                         FOREIGN KEY (CourseID) REFERENCES Courses (CourseID));",

                @"CREATE TABLE IF NOT EXISTS Lecturers
                         (LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                            FullnameName TEXT NOT NULL, 
                            Age INTEGER,
                            Address TEXT,
                         SubjectID INTEGER,UserID INTEGER,
                         FOREIGN KEY (UserID) REFERENCES Users(UserID)
                         FOREIGN KEY (SubjectID) REFERENCES Subjects (SubjectID));",
             

                @"CREATE TABLE IF NOT EXISTS Exams
                         (ExamID INTEGER PRIMARY KEY,
                          ExamName TEXT NOT NULL ,
                          SubjectID INTEGER,
                          FOREIGN KEY (SubjectID)  REFERENCES Subjects (SubjectID) );",

                @"CREATE TABLE IF NOT EXISTS Marks
                         (MarkID INTEGER PRIMARY KEY, 
                          StudentID INTEGER, 
                          ExamID INTEGER, 
                          Score INTEGER, 
                          FOREIGN KEY (StudentId)  REFERENCES Students (StudentId),
                          FOREIGN KEY (ExamID)  REFERENCES Exams (ExamID));",

                @"CREATE TABLE IF NOT EXISTS Rooms
                         (RoomID INTEGER PRIMARY KEY, RoomName TEXT NOT NULL, RoomType TEXT NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS Timetables
                         (TimetableID INTEGER PRIMARY KEY, 
                          SubjectID INTEGER, 
                          TimeSlot TEXT NOT NULL,
                          RoomID INTEGER,
                          FOREIGN KEY (SubjectID)  REFERENCES Subjects (SubjectID), 
                          FOREIGN KEY (RoomID)  REFERENCES Rooms (RoomID));",
            
             
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
