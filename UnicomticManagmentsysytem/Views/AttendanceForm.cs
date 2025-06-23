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
using UnicomticManagmentsysytem.Repositories;


namespace UnicomticManagmentsysytem.Views
{
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "Present", "Absent" });

            cmbStudent.DataSource = AttendanceController.GetStudents();
            cmbStudent.DisplayMember = "FullName";
            cmbStudent.ValueMember = "StudentID";

            cmbSubject.DataSource = AttendanceController.GetSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }
        private void LoadAttendanceRecords()
        {
            dgvAttendance.DataSource = AttendanceController.GetAllAttendance();
        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex == -1 || cmbSubject.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all fields.");
                return;
            }

            int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string status = cmbStatus.SelectedItem.ToString();

            string error;
            if (AttendanceController.MarkAttendance(studentId, subjectId, date, status, out error))
            {
                MessageBox.Show("Attendance marked successfully.");
                LoadAttendanceRecords();
            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
