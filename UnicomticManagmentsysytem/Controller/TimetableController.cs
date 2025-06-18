using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Models;

namespace UnicomticManagmentsysytem.Controller
{
    internal class TimetableController
    {
        public void AddTimetableEntry(int subjectId, string timeSlot, int roomId)
        {
            string query = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@sid, @time, @rid)";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@sid", subjectId);
                cmd.Parameters.AddWithValue("@time", timeSlot);
                cmd.Parameters.AddWithValue("@rid", roomId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Timetable> GetAllTimetables()
        {
            var list = new List<Timetable>();
            string query = @"
            SELECT t.TimetableID, s.SubjectName, t.TimeSlot, r.RoomName, r.RoomType
            FROM Timetables t
            JOIN Subjects s ON t.SubjectID = s.SubjectID
            JOIN Rooms r ON t.RoomID = r.RoomID";
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Timetable
                    {
                        SubjectName = reader["SubjectName"].ToString(),
                        TimeSlot = reader["TimeSlot"].ToString(),
                        RoomName = reader["RoomName"].ToString(),
                        RoomType = reader["RoomType"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
