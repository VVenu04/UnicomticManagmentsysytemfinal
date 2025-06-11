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
        private void LoadRoleOptions()
        {
            cmbrole.Items.Clear();

            if (_currentUserRole == "Staff")
            {
                cmbrole.Items.AddRange(new string[] { "Student", "Lecturer" });
            }
            else if (_currentUserRole == "Admin")
            {
                cmbrole.Items.AddRange(new string[] { "Admin", "Staff", "Student", "Lecturer" });
            }

            cmbrole.SelectedIndex = 0;
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = UsersController.GetAllUsers();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            
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
            string password = txtpassword.Text.Trim();
            string role = cmbrole.SelectedItem.ToString();

            string error;
            bool success = UsersController.AddUser(username, password, role, out error);

            if (success)
            {
                MessageBox.Show("User added.");
                LoadUsers();
                txtusername.Clear();
                txtpassword.Clear();
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
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
