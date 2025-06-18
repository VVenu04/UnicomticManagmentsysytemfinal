using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Controller;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Views
{
    public partial class UsersForm : Form
    {
        private string _currentUserRole;
        public UsersForm(string currentUserRole)
        {
            InitializeComponent();
            _currentUserRole = currentUserRole;
            LoadRoleOptions();
            LoadUsers();
        }
        private void LoadSubjects()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT SubjectID, SubjectName FROM Subjects";
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbSubjects.DataSource = dt;
                cmbSubjects.DisplayMember = "SubjectName";
                cmbSubjects.ValueMember = "SubjectID";
            }
        }
        private void LoadRoleOptions()
        {
            cmbrole.Items.Clear();

            if (_currentUserRole == "Staff")
            {
                cmbrole.Items.AddRange(new string[] { "Student", "Lecturer" });
            }
            else if (_currentUserRole == "Admin")
            {
                cmbrole.Items.AddRange(new string[] { "select the role","Admin", "Staff", "Student", "Lecturer" });
            }

            cmbrole.SelectedIndex = 0;
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = UsersController.GetAllUsers();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (_currentUserRole == "Staff" && (_currentUserRole == "Admin" || _currentUserRole == "Staff"))
            {
                MessageBox.Show("Staff can only add Students or Lecturers.");
                return;
            }

            string username = txtusername.Text.Trim();
            string password = "password@123"; // set default password
            string role = cmbrole.SelectedItem.ToString();
            string fullName = txtfname.Text.Trim();

            int age;
            if (!int.TryParse(txtage.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid number for age.");
                return;
            }

            string address = txtaddress.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string gender = rdbMalee.Checked ? "Male" : rdbFEMalee.Checked ? "Female" : "";
            if (gender == "")
            {
                MessageBox.Show("Please select gender.");
                return;
            }
            string className = txtclass.Text.Trim(); 

            string error;
            bool success = UsersController.AddUser(username, password, role, fullName, age, address, nic, gender, className, out error);

            if (success)
            {
                long userId = UsersController.GetUserIdByUsername(username);
                int subjectId = Convert.ToInt32(cmbSubjects.SelectedValue);

                if (role == "Student")
                {
                    int studentId = UsersController.GetStudentIdByUserId(userId);
                    UsersController.AssignSubjectToStudent(studentId, subjectId, out error);
                }
                else if (role == "Lecturer")
                {
                    int lecturerId = UsersController.GetLecturerIdByUserId(userId);
                    UsersController.AssignSubjectToLecturer(lecturerId, subjectId, out error);
                }

                MessageBox.Show("User added. Default password is: password@123");
                LoadUsers();

                // Clear fields
                txtusername.Clear();
                txtaddress.Clear();
                txtage.Clear();
                txtfname.Clear();
                txtNIC.Clear();
                txtclass.Clear();
            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
        }
        

        private void btndel_Click(object sender, EventArgs e)
        {
            if(dgvUsers.SelectedRows.Count == 0)
    {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string error;
                if (UsersController.DeleteUser(userId, out error))
                {
                    MessageBox.Show("User deleted.");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }

        private void btnalluser_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCourses();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMalee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadCourses()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT CourseID, CourseName FROM Courses";
            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "CourseID";
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
