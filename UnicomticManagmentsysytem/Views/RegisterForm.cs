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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0;
            cmbRole.Enabled = false; // Only allow Admin for first-time setup

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = Txtcpassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (username == "" || password == "")  // Check if username and password are not empty
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))   // Check if any field is empty
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            if (password != confirmPassword)   // Check if password and confirm password match
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (password.Length < 6)   // Check if password is at least 6 characters long
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            using (var conn = DatabaseManager.GetConnection())
            {
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();// Execute the insert command
                    MessageBox.Show("Admin account created successfully!");

                    // Go to LoginForm after  registration
                    this.Hide();
                    LoginForm loginForm = new LoginForm(); // Create a new instance of LoginForm
                    loginForm.ShowDialog(); // Waits until it's closed before exiting
                    this.Close(); // Properly close the register form

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !show;
            Txtcpassword.UseSystemPasswordChar = !show;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}