using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomticManagmentsysytem.Models;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Controller
{
    internal class RoomController
    {




        public static DataTable GetAllRooms()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT RoomID, RoomName, RoomType FROM Rooms ORDER BY RoomName";
            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }







        public static bool AddRoom(string roomName, string roomType, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(roomName) || string.IsNullOrWhiteSpace(roomType))
            {
                error = "Room name and type are required.";
                return false;
            }

            try
            {
                var conn = DatabaseManager.GetConnection();
                string insertQuery = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@name", roomName);
                    cmd.Parameters.AddWithValue("@type", roomType);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error: " + ex.Message;
                return false;
            }
        }





        public static bool DeleteRoom(int roomId, out string error)
        {
            error = "";
            try
            {
                var conn = DatabaseManager.GetConnection();
                string deleteQuery = "DELETE FROM Rooms WHERE RoomID = @id";
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", roomId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = "Error: " + ex.Message;
                return false;
            }
        }
    }
}
