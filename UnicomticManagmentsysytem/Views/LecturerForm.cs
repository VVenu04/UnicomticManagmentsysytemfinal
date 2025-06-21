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
using static System.Net.Mime.MediaTypeNames;

namespace UnicomticManagmentsysytem.Views
{
    public partial class LecturerForm : Form
    {
        private int editingLecturerId = -1;

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
            int age;
            if (!int.TryParse(tnumAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Username and Full Name are required.");
                return;
            }

            string error;
            if (editingLecturerId == -1)
            {
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
            else
            {
                if (LecturerController.UpdateLecturer(editingLecturerId, fullName, age, address, nic, gender, className, subjectId, out error))
                {
                    MessageBox.Show("Lecturer updated successfully.");
                    LoadLecturers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(error);
                }
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
            tnumAge.Clear();
            editingLecturerId = -1;
        }

        private void numAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvLecturers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lecturer to edit.");
                return;
            }

            var row = dgvLecturers.SelectedRows[0];
            editingLecturerId = Convert.ToInt32(row.Cells["LecturerID"].Value);
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtNIC.Text = row.Cells["NIC"].Value.ToString();
            cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
            txtClass.Text = row.Cells["Class"].Value.ToString();
            cmbSubject.Text = row.Cells["SubjectName"].Value.ToString();
            //tnumAge.Value = Convert.ToDecimal(row.Cells["Age"].Value);
        }
    }
}

