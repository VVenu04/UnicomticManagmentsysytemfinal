using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Models;

namespace UnicomticManagmentsysytem.Controller
{
    internal class RoomController
    {
        public List<Room> GetAllRooms()
        {
            var list = new List<Room>();
            string query = "SELECT * FROM Rooms";
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Room
                    {
                        RoomId = Convert.ToInt32(reader["RoomID"]),
                        RoomName = reader["RoomName"].ToString(),
                        RoomType = reader["RoomType"].ToString()
                    });
                }
            }
            return list;
        }

        public void AddRoom(string roomName, string roomType)
        {
            string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", roomName);
                cmd.Parameters.AddWithValue("@type", roomType);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
