using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUICust;
using MySql.Data.MySqlClient;

namespace GUICust
{

    public partial class Login : Form
    {
        public static string LoggedInUsername { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //this is the Username_TextChanged
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim(); // Get the entered username
            string password = Password.Text.Trim(); // Get the entered password

            DBConnection db = new DBConnection(); // Create an instance of DBConnection

            // Validate the user credentials
            if (db.ValidateUser(username, password))
            {
                // Store the logged-in username globally
                LoggedInUsername = username;

                // If credentials are correct, open CustRentGUI
                CostumeRental dashboard = new CostumeRental();
                dashboard.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // If credentials are invalid, show an error message
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SignUpLblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp(); // create instance of SignUp form
            signUpForm.Show();                // show the SignUp form
            this.Hide();                      // hide the current (Login) form
        }

        private void ForgotPassLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Step 1: Prompt for the user's username
            string username = Microsoft.VisualBasic.Interaction.InputBox("Please enter your username to recover your password.", "Password Recovery", "");

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a valid username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();

                    // Step 2: Check if the username exists in the database
                    string query = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Step 3: If username is found, ask for agreement to proceed with password recovery
                        string userInput = Microsoft.VisualBasic.Interaction.InputBox("To recover your password, type 'I Agree' below and click OK.", "Password Recovery", "");

                        if (userInput.Trim().ToLower() != "i agree")
                        {
                            MessageBox.Show("You must agree to proceed with password recovery.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Step 4: If user agrees, retrieve the password from the database
                        string passwordQuery = "SELECT Password FROM users WHERE Username = @Username";
                        MySqlCommand passwordCmd = new MySqlCommand(passwordQuery, db.connection);
                        passwordCmd.Parameters.AddWithValue("@Username", username);

                        object result = passwordCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string password = result.ToString();
                            MessageBox.Show($"Your password is: {password}", "Password Recovered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving password. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No account found with that username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
