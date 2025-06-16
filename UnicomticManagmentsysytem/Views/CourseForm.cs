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
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Views
{
    public partial class CourseForm : Form
    {

        private void LoadCourseDropdown()
        {
            var conn = DatabaseManager.GetConnection();
            string query = "SELECT CourseID, CourseName FROM Courses";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbcourse.DataSource = dt;
                cmbcourse.DisplayMember = "CourseName";
                cmbcourse.ValueMember = "CourseID";
            }
        }

        public CourseForm()
        {
            InitializeComponent();
            LoadCoursesWithSubjects();
            LoadCourseDropdown();
        }

        private void lblcourse_Click(object sender, EventArgs e)
        {

        }

        private void cmcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadCoursesWithSubjects()
        {
            var conn = DatabaseManager.GetConnection();

            string query = @"
        SELECT 
            
            c.CourseName,
            
            s.SubjectName
        FROM 
        Courses_Subject cs
        JOIN Courses c ON cs.CourseID = c.CourseID
        JOIN Subjects s ON cs.SubjectID = s.SubjectID
        ORDER BY c.CourseName, s.SubjectName";

            using (var adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvco.DataSource = dt;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text.Trim();
            string subjectName = txtsub.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("Enter a course name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Enter a subject name.");
                return;
            }

            var conn = DatabaseManager.GetConnection();

            try
            {
                // 1. Insert course
                string insertCourse = "INSERT INTO Courses (CourseName) VALUES (@cname)";
                long courseId;
                using (var cmd = new SQLiteCommand(insertCourse, conn))
                {
                    cmd.Parameters.AddWithValue("@cname", courseName);
                    cmd.ExecuteNonQuery();
                    courseId = conn.LastInsertRowId;
                }

                // 2. Insert subject
                string insertSubject = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@sname, @cid)";
                long subjectId;
                using (var cmd = new SQLiteCommand(insertSubject, conn))
                {
                    cmd.Parameters.AddWithValue("@sname", subjectName);
                    cmd.Parameters.AddWithValue("@cid", courseId);
                    cmd.ExecuteNonQuery();
                    subjectId = conn.LastInsertRowId;
                }

                // 3. Link course + subject
                string insertLink = "INSERT INTO Courses_Subject (CourseID, SubjectID) VALUES (@cid, @sid)";
                using (var cmd = new SQLiteCommand(insertLink, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", courseId);
                    cmd.Parameters.AddWithValue("@sid", subjectId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Course and Subject added successfully.");
                txtCourseName.Clear();
                txtsub.Clear();
                LoadCoursesWithSubjects(); // Refresh table
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subjectName = txtsub.Text.Trim();

            if (cmbcourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            if (string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Enter a subject name.");
                return;
            }

            int courseId = Convert.ToInt32(cmbcourse.SelectedValue);
            var conn = DatabaseManager.GetConnection();

            try
            {
                // Optional: check for duplicate subject name under this course
                string checkQuery = "SELECT COUNT(*) FROM Subjects WHERE SubjectName = @sname AND CourseID = @cid";
                using (var checkCmd = new SQLiteCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@sname", subjectName);
                    checkCmd.Parameters.AddWithValue("@cid", courseId);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This subject already exists for the selected course.");
                        return;
                    }
                }

                // 1. Insert subject WITH CourseID
                string insertSubject = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@sname, @cid)";
                long subjectId;
                using (var cmd = new SQLiteCommand(insertSubject, conn))
                {
                    cmd.Parameters.AddWithValue("@sname", subjectName);
                    cmd.Parameters.AddWithValue("@cid", courseId);
                    cmd.ExecuteNonQuery();
                    subjectId = conn.LastInsertRowId;
                }

                // 2. Link subject to course in Courses_Subject
                string insertLink = "INSERT INTO Courses_Subject (CourseID, SubjectID) VALUES (@cid, @sid)";
                using (var cmd = new SQLiteCommand(insertLink, conn))
                {
                    cmd.Parameters.AddWithValue("@cid", courseId);
                    cmd.Parameters.AddWithValue("@sid", subjectId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Subject added to existing course.");
                txtsub.Clear();
                LoadCoursesWithSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
