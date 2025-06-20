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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadTimetable();
        }
        private void LoadDropdowns()
        {
            cmbDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });

            cmbTime.Items.AddRange(new string[]
            {
                "08:00 AM", "10:00 AM", "12:00 PM", "02:00 PM", "04:00 PM"
            });

            cmbSubject.DataSource = TimetableController.GetSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";

            cmbRoom.DataSource = TimetableController.GetRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";

            cmbLecturer.DataSource = TimetableController.GetLecturers();
            cmbLecturer.DisplayMember = "FullName";
            cmbLecturer.ValueMember = "LecturerID";
        }
        private void LoadTimetable()
        {
            dgvTimetable.DataSource = TimetableController.GetAllTimetables();
        }
        private void TimetableForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
            int roomId = Convert.ToInt32(cmbRoom.SelectedValue);
            int lecturerId = Convert.ToInt32(cmbLecturer.SelectedValue);
            string day = cmbDay.SelectedItem?.ToString();
            string time = cmbTime.SelectedItem?.ToString();
            string className = txtClass.Text.Trim();

            string error;
            if (TimetableController.AddTimetable(subjectId, roomId, lecturerId, day, time, className, out error))
            {
                MessageBox.Show("Timetable entry added.");
                LoadTimetable();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvTimetable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a timetable entry to delete.");
                return;
            }

            int timetableId = Convert.ToInt32(dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value);
            string error;
            if (TimetableController.DeleteTimetable(timetableId, out error))
            {
                MessageBox.Show("Entry deleted.");
                LoadTimetable();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void dgvTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
