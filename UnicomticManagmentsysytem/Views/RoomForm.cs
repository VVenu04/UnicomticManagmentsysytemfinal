using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Controller;

namespace UnicomticManagmentsysytem.Views
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            cmbRoomType.Items.AddRange(new string[] { "Lab", "Lecture Hall" });
            LoadRooms();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadRooms()
        {
            dgvRooms.DataSource = RoomController.GetAllRooms();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = cmbRoomType.SelectedItem?.ToString();
            string error;

            if (RoomController.AddRoom(roomName, roomType, out error))
            {
                MessageBox.Show("Room added successfully.");
                txtRoomName.Clear();
                cmbRoomType.SelectedIndex = -1;
                LoadRooms();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            int roomId = Convert.ToInt32(dgvRooms.SelectedRows[0].Cells["RoomID"].Value);
            string error;

            if (RoomController.DeleteRoom(roomId, out error))
            {
                MessageBox.Show("Room deleted.");
                LoadRooms();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
