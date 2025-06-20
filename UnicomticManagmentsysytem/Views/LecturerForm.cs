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
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
            cmbGender.Items.AddRange(new string[] { "Male", "Female" });
            LoadSubjects();
            LoadLecturers();
        }
        private void LoadSubjects()
        {
            cmbSubject.DataSource = LecturerController.GetSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private void LoadLecturers()
        {
            dgvLecturers.DataSource = LecturerController.GetAllLecturers();
        }


        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString();
            string className = txtClass.Text.Trim();
            int age = (int)numAge.Value;
            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Username and Full Name are required.");
                return;
            }

            string error;
            if (LecturerController.AddLecturerWithUser(username, fullName, age, address, nic, gender, className, subjectId, out error))
            {
                MessageBox.Show("Lecturer registered successfully.");
                LoadLecturers();
                ClearForm();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            txtNIC.Clear();
            txtClass.Clear();
            cmbGender.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            numAge.Value = 18;
        }
    }
}
