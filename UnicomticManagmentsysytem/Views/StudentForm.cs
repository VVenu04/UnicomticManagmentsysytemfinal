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
    public partial class StudentForm : Form
    {
        private int editingStudentId = -1;
        public StudentForm()
        {
            InitializeComponent();
            cmbGender.Items.AddRange(new string[] { "Male", "Female" });
            LoadCourses();
            LoadStudents();
        }
        private void LoadCourses()
        {
            cmbCourse.DataSource = StudentController.GetCourses();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentController.GetAllStudents();
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            txtNIC.Clear();
            txtClass.Clear();
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            //t/numAge.Value = 18;
            editingStudentId = -1;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
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
            int courseId = Convert.ToInt32(cmbCourse.SelectedValue);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Username and Full Name are required.");
                return;
            }

            string error;
            if (editingStudentId == -1)
            {
                if (StudentController.AddStudentWithUser(username, fullName, age, address, nic, gender, className, courseId, out error))
                {
                    MessageBox.Show("Student registered successfully.");
                    LoadStudents();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                if (StudentController.UpdateStudent(editingStudentId, fullName, age, address, nic, gender, className, courseId, out error))
                {
                    MessageBox.Show("Student updated.");
                    LoadStudents();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            var row = dgvStudents.SelectedRows[0];
            editingStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtNIC.Text = row.Cells["NIC"].Value.ToString();
            cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
            txtClass.Text = row.Cells["Class"].Value.ToString();
            cmbCourse.Text = row.Cells["CourseName"].Value.ToString();
            //tnumAge.Text = Convert.ToDecimal(row.Cells["Age"].Value);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
            string error;
            if (StudentController.DeleteStudent(studentId, out error))
            {
                MessageBox.Show("Student deleted.");
                LoadStudents();
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
    }
    

