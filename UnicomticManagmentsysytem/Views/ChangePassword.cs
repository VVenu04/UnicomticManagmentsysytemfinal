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
    public partial class ChangePassword : Form
    {
        private int _userId;
        public ChangePassword(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = DatabaseManager.GetConnection();
            string oldPassword = txtoldpass.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword == "password@123")
            {
                MessageBox.Show("You cannot reuse the default password.");
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            string checkQuery = "SELECT Password FROM Users WHERE UserID = @userId";
            using (var checkCmd = new SQLiteCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@userId", _userId);
                string currentPassword = checkCmd.ExecuteScalar()?.ToString();

                if (currentPassword != oldPassword)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }
            }
            
            //var conn = DatabaseManager.GetConnection();
            string query = "UPDATE Users SET Password = @password WHERE UserID = @userId";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@userId", _userId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password changed successfully!");
            this.Hide();
            //new LoginForm().Show();
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    } 
}
    

