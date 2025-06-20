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
                        (CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                         CourseName TEXT NOT NULL);",

                 @"CREATE TABLE IF NOT EXISTS Courses_Subject
                        (CourseID INTEGER ,
                        SubjectID INTEGER,
                        PRIMARY KEY(CourseID,SubjectID),
                        FOREIGN KEY (CourseID)  REFERENCES Courses (CourseID),
                    FOREIGN KEY (SubjectID) REFERENCES Subjects (SubjectID));",

                @"CREATE TABLE IF NOT EXISTS Admin
                        (AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL, 
                        Age INTEGER,
                        Address TEXT,
                        NIC TEXT,
                        Gender TEXT,
                        UserID INTEGER,
                        FOREIGN KEY (UserID) REFERENCES Users(UserID)
                                                       );",


                @"CREATE TABLE IF NOT EXISTS Staff
                        (StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL, 
                        Age INTEGER,
                        Address TEXT,
                        NIC TEXT,
                        Gender TEXT,
                        UserID INTEGER,
                        FOREIGN KEY (UserID) REFERENCES Users(UserID));",


                @"CREATE TABLE IF NOT EXISTS Subjects
                         (SubjectID INTEGER PRIMARY KEY AUTOINCREMENT, 
                          SubjectName TEXT NOT NULL,
                          CourseID INTEGER,
                          FOREIGN KEY (CourseID)  REFERENCES Courses (CourseID));",

                @"CREATE TABLE IF NOT EXISTS Students
                    (StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL, 
                    Age INTEGER,
                    Address TEXT,
                    NIC TEXT,
                    Gender TEXT,
                    Class TEXT,
                    CourseID INTEGER,
                    UserID INTEGER,
                    FOREIGN KEY (UserID) REFERENCES Users(UserID),
                    FOREIGN KEY (CourseID) REFERENCES Courses (CourseID));",

                @"CREATE TABLE IF NOT EXISTS Lecturers
                         (LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                            FullName TEXT NOT NULL, 
                            Age INTEGER,
                            Address TEXT,
                            NIC TEXT,
                            Gender TEXT,
                            Class TEXT,
                            SubjectID INTEGER,
                            UserID INTEGER,
                            FOREIGN KEY (UserID) REFERENCES Users(UserID),
                            FOREIGN KEY (SubjectID) REFERENCES Subjects (SubjectID));",


                @"CREATE TABLE IF NOT EXISTS Exams
                         (ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                          ExamName TEXT NOT NULL ,
                          SubjectID INTEGER,
                          ExamDate TEXT,
                          FOREIGN KEY (SubjectID)  REFERENCES Subjects (SubjectID) );",

                @"CREATE TABLE IF NOT EXISTS Marks
                         (MarkID INTEGER PRIMARY KEY AUTOINCREMENT, 
                          StudentID INTEGER, 
                          ExamID INTEGER, 
                          Score INTEGER, 
                          FOREIGN KEY (StudentId)  REFERENCES Students (StudentId),
                          FOREIGN KEY (ExamID)  REFERENCES Exams (ExamID));",

                @"CREATE TABLE IF NOT EXISTS Rooms
                     (RoomID INTEGER PRIMARY KEY AUTOINCREMENT, RoomName TEXT NOT NULL, RoomType TEXT NOT NULL);",

                @"CREATE TABLE IF NOT EXISTS Timetables
                         (TimetableID INTEGER PRIMARY KEY AUTOINCREMENT, 
                          SubjectID INTEGER, 
                          Class TEXT,
                          RoomID INTEGER,
                          LecturerID INTEGER,
                          FullName TEXT,
                          Day TEXT NOT NULL,            
                          Time TEXT NOT NULL,
                          FOREIGN KEY (SubjectID)  REFERENCES Subjects (SubjectID),
                          FOREIGN KEY (RoomID)  REFERENCES Rooms (RoomID),
                          FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID)
                          );",


                 @"CREATE TABLE IF NOT EXISTS Student_Subject (
                      StudentID INTEGER,
                      SubjectID INTEGER,
                      PRIMARY KEY(StudentID, SubjectID), 
                           
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                
            );"

                //@"CREATE TABLE IF NOT EXISTS Lecturer_Subject (
                //    LecturerID INTEGER,
                //    SubjectID INTEGER,
                //    PRIMARY KEY(LecturerID, SubjectID),
                //    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                //    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                //);"

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
