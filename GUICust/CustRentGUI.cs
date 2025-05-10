using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using GUICust;

using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUICust
{

    public partial class CostumeRental : Form
    {
        private List<string> picturePaths = new List<string>();
        public static string LoggedInUsername { get; set; }

        public CostumeRental()
        {
            InitializeComponent();

        }
        private void ClearFields()
        {
            NameTxtBox.Clear();
            DescriptionTxtBox.Clear();
            PicturePathTxtBox.Clear();
            ComboBoxType.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            NameTxtBox = new TextBox();
            DescriptionTxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CostumeType = new DataGridViewTextBoxColumn();
            PicturePath = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ComboBoxType = new ComboBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            PicturePathTxtBox = new TextBox();
            DltBtn = new Button();
            UpdtBtn = new Button();
            CnclBtn = new Button();
            SaveBtn = new Button();
            AddBtn = new Button();
            BrowseBtn = new Button();
            CostumeInfoBtn = new Button();
            ChangePassBtn = new Button();
            ReportBtn = new Button();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 239);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 298);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Location = new Point(22, 262);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(357, 27);
            NameTxtBox.TabIndex = 3;
            NameTxtBox.TextChanged += NameTxtBox_TextChanged;
            // 
            // DescriptionTxtBox
            // 
            DescriptionTxtBox.Location = new Point(22, 321);
            DescriptionTxtBox.Multiline = true;
            DescriptionTxtBox.Name = "DescriptionTxtBox";
            DescriptionTxtBox.Size = new Size(357, 131);
            DescriptionTxtBox.TabIndex = 4;
            DescriptionTxtBox.TextChanged += DescriptionTxtBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Description, CostumeType, PicturePath });
            dataGridView1.Location = new Point(538, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(523, 535);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // CostumeType
            // 
            CostumeType.HeaderText = "CostumeType";
            CostumeType.MinimumWidth = 10;
            CostumeType.Name = "CostumeType";
            CostumeType.Width = 125;
            // 
            // PicturePath
            // 
            PicturePath.HeaderText = "PicturePath";
            PicturePath.MinimumWidth = 6;
            PicturePath.Name = "PicturePath";
            PicturePath.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 455);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 6;
            label1.Text = "Costume Type";
            label1.Click += label1_Click_1;
            // 
            // ComboBoxType
            // 
            ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Items.AddRange(new object[] { "Halloween", "Medieval", "Hero", "Fantasy", "Formal", "Gown" });
            ComboBoxType.Location = new Point(22, 478);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(357, 28);
            ComboBoxType.TabIndex = 7;
            ComboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 155);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 179);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Picture Path";
            label4.Click += label4_Click;
            // 
            // PicturePathTxtBox
            // 
            PicturePathTxtBox.Location = new Point(22, 209);
            PicturePathTxtBox.Name = "PicturePathTxtBox";
            PicturePathTxtBox.Size = new Size(256, 27);
            PicturePathTxtBox.TabIndex = 10;
            PicturePathTxtBox.TextChanged += PicturePathTxtBox_TextChanged;
            // 
            // DltBtn
            // 
            DltBtn.Location = new Point(400, 126);
            DltBtn.Name = "DltBtn";
            DltBtn.Size = new Size(132, 51);
            DltBtn.TabIndex = 12;
            DltBtn.Text = "Delete Costume";
            DltBtn.UseVisualStyleBackColor = true;
            DltBtn.Click += DltBtn_Click;
            // 
            // UpdtBtn
            // 
            UpdtBtn.Location = new Point(400, 69);
            UpdtBtn.Name = "UpdtBtn";
            UpdtBtn.Size = new Size(132, 51);
            UpdtBtn.TabIndex = 14;
            UpdtBtn.Text = "Update Costume";
            UpdtBtn.UseVisualStyleBackColor = true;
            UpdtBtn.Click += UpdtBtn_Click;
            // 
            // CnclBtn
            // 
            CnclBtn.Location = new Point(400, 183);
            CnclBtn.Name = "CnclBtn";
            CnclBtn.Size = new Size(132, 51);
            CnclBtn.TabIndex = 15;
            CnclBtn.Text = "Costume Count";
            CnclBtn.UseVisualStyleBackColor = true;
            CnclBtn.Click += CnclBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(400, 355);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(132, 51);
            SaveBtn.TabIndex = 16;
            SaveBtn.Text = "Load Costumes";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(400, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(132, 51);
            AddBtn.TabIndex = 17;
            AddBtn.Text = "Add Costume";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(285, 208);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.RightToLeft = RightToLeft.No;
            BrowseBtn.Size = new Size(94, 29);
            BrowseBtn.TabIndex = 18;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // CostumeInfoBtn
            // 
            CostumeInfoBtn.Location = new Point(400, 240);
            CostumeInfoBtn.Name = "CostumeInfoBtn";
            CostumeInfoBtn.Size = new Size(132, 51);
            CostumeInfoBtn.TabIndex = 19;
            CostumeInfoBtn.Text = "Costume Info";
            CostumeInfoBtn.UseVisualStyleBackColor = true;
            CostumeInfoBtn.Click += CostumeInfoBtn_Click;
            // 
            // ChangePassBtn
            // 
            ChangePassBtn.Location = new Point(400, 298);
            ChangePassBtn.Name = "ChangePassBtn";
            ChangePassBtn.Size = new Size(132, 51);
            ChangePassBtn.TabIndex = 20;
            ChangePassBtn.Text = "Change Password";
            ChangePassBtn.UseVisualStyleBackColor = true;
            ChangePassBtn.Click += ChangePassBtn_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.Location = new Point(400, 412);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(132, 51);
            ReportBtn.TabIndex = 21;
            ReportBtn.Text = "Generate Report";
            ReportBtn.UseVisualStyleBackColor = true;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // CostumeRental
            // 
            AutoSize = true;
            ClientSize = new Size(1061, 537);
            Controls.Add(ReportBtn);
            Controls.Add(ChangePassBtn);
            Controls.Add(CostumeInfoBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(AddBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CnclBtn);
            Controls.Add(UpdtBtn);
            Controls.Add(DltBtn);
            Controls.Add(PicturePathTxtBox);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(ComboBoxType);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(DescriptionTxtBox);
            Controls.Add(NameTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Text = " CostRental";
            Load += CostumeRental_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label2;
        private Label label3;
        private TextBox NameTxtBox;
        private TextBox DescriptionTxtBox;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CostumeType;
        private DataGridViewTextBoxColumn PicturePath;
        private Button CostumeInfoBtn;
        private Button ChangePassBtn;
        private Button ReportBtn;
        private DataGridView dataGridView1;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                // Populate other fields
                NameTxtBox.Text = row.Cells["Name"].Value?.ToString();
                DescriptionTxtBox.Text = row.Cells["Description"].Value?.ToString();
                ComboBoxType.SelectedItem = row.Cells["CostumeType"].Value?.ToString();

                string path = row.Cells["PicturePath"].Value?.ToString();
                PicturePathTxtBox.Text = path;

                // Clear the previous image before loading the new one
                pictureBox1.Image = null;

                // Load and display the picture if it exists
                if (System.IO.File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null; // No image found
                }
            }
        }







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private Label label1;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private ComboBox ComboBoxType;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox PicturePathTxtBox;
        private Button DltBtn;
        private Button UpdtBtn;
        private Button CnclBtn;
        private Button SaveBtn;
        private Button AddBtn;
        private void CostumeRental_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(PicturePathTxtBox.Text))
            {
                pictureBox1.Image = Image.FromFile(PicturePathTxtBox.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Create a new database connection and fetch data from the "Costume" table
            using (DBConnection db = new DBConnection())
            {
                try
                {
                    // Open the connection to the database
                    db.Open();

                    // Query to fetch all costumes from the database
                    string query = "SELECT Name, Description, CostumeType, PicturePath FROM Costume";

                    // Create the command and execute the query
                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Clear any existing rows in the DataGridView before adding new ones
                    dataGridView1.Rows.Clear();

                    // Loop through the data reader and add each row to the DataGridView
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        string costumeType = reader["CostumeType"].ToString();
                        string picturePath = reader["PicturePath"].ToString();

                        // Add a new row to the DataGridView with the costume details
                        dataGridView1.Rows.Add(name, description, costumeType, picturePath);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading costumes from the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void UpdtBtn_Click(object sender, EventArgs e)
        {
            string costumeName = NameTxtBox.Text;
            string description = DescriptionTxtBox.Text;
            string costumeType = ComboBoxType.SelectedItem.ToString();
            string picturePath = PicturePathTxtBox.Text;

            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();

                    // Create a command to execute the stored procedure
                    MySqlCommand cmd = new MySqlCommand("UpdateCostumeByName", db.connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@costumeName", costumeName);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@costumeType", costumeType);
                    cmd.Parameters.AddWithValue("@picturePath", picturePath);

                    // Execute the procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Costume updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCostumesToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating costume: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Close();
                }
            }
        }


        private void DltBtn_Click(object sender, EventArgs e)
        {
            // Ask for the costume name to delete
            string costumeName = Microsoft.VisualBasic.Interaction.InputBox("Enter the name of the costume to delete:", "Delete Costume");

            if (string.IsNullOrWhiteSpace(costumeName))
            {
                MessageBox.Show("Please enter a valid costume name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the method to delete the costume
            DeleteCostumeByName(costumeName);

            // Reload the data in DataGridView
            LoadCostumesToGrid();
        }

        private void DeleteCostumeByName(string costumeName)
        {
            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();
                    // Prepare the MySQL command to call the stored procedure
                    MySqlCommand cmd = new MySqlCommand("DeleteCostumeByName", db.connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the input parameter for the stored procedure
                    cmd.Parameters.AddWithValue("@costumeName", costumeName);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Inform the user that the costume has been deleted
                    MessageBox.Show($"Costume '{costumeName}' has been deleted.", "Costume Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting costume: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        private void LoadCostumesToGrid()
        {
            // Clear the DataGridView first to ensure fresh data
            dataGridView1.Rows.Clear();

            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();
                    // Query to get all costumes
                    string query = "SELECT Name, Description, CostumeType, PicturePath FROM costume";
                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Populate the DataGridView
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["Name"].ToString(),
                            reader["Description"].ToString(),
                            reader["CostumeType"].ToString(),
                            reader["PicturePath"].ToString()
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading costumes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Close();
                }
            }
        }





        private void CnclBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the database connection
                using (DBConnection db = new DBConnection())
                {
                    // Open the database connection
                    db.Open();

                    // SQL query to call the stored procedure
                    string query = "CALL CountCostumesByType()";

                    // Use a MySqlCommand to execute the query
                    using (MySqlCommand cmd = new MySqlCommand(query, db.connection))
                    {
                        // Create a DataTable to store the result of the query
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        // Fill the DataTable with the results from the stored procedure
                        dataAdapter.Fill(dt);

                        // Display the results (for example, in a message box)
                        StringBuilder resultMessage = new StringBuilder();
                        foreach (DataRow row in dt.Rows)
                        {
                            resultMessage.AppendLine($"Costume Type: {row["CostumeType"]}, Count: {row["CostumeCount"]}");
                        }

                        // Show the results in a message box
                        MessageBox.Show(resultMessage.ToString(), "Costume Count By Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might have occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PicturePathTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled out
            if (string.IsNullOrWhiteSpace(NameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(DescriptionTxtBox.Text) ||
                ComboBoxType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(PicturePathTxtBox.Text)) // Ensure the picture path is provided
            {
                MessageBox.Show("Please fill all the fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the database connection and call the stored procedure
            using (DBConnection db = new DBConnection())
            {
                try
                {
                    // Open database connection
                    db.Open();

                    // Create the command to call the stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("AddCostume", db.connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@costumeName", NameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@costumeDescription", DescriptionTxtBox.Text);
                        cmd.Parameters.AddWithValue("@costumeType", ComboBoxType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@picturePath", PicturePathTxtBox.Text);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding costume to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Optionally add the new costume data to the DataGridView (to display it)
            dataGridView1.Rows.Add(NameTxtBox.Text, DescriptionTxtBox.Text, ComboBoxType.SelectedItem.ToString(), PicturePathTxtBox.Text);

            // Clear the form fields
            ClearFields();
        }






        private Button BrowseBtn;

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filter for image files only
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Show the file dialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string selectedImagePath = openFileDialog.FileName;

                    // Set the file path to the textbox
                    PicturePathTxtBox.Text = selectedImagePath;

                    // Load and display the image in the PictureBox
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // fit image to box
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CostumeInfoBtn_Click(object sender, EventArgs e)
        {
            string inputName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter costume name:", "Find Costume", "");

            if (string.IsNullOrWhiteSpace(inputName))
                return;

            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();

                    MySqlCommand cmd = new MySqlCommand("GetCostumesByName", db.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@costumeName", inputName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string desc = reader["Description"].ToString();
                            string path = reader["PicturePath"].ToString();

                            CostumeInfoForm infoForm = new CostumeInfoForm();
                            infoForm.SetCostumeInfo(name, desc, path);
                            infoForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Costume not found.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            // Step 1: Prompt for the username
            string username = Microsoft.VisualBasic.Interaction.InputBox("Please enter your username.", "Change Password", "");

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (DBConnection db = new DBConnection())
            {
                try
                {
                    db.Open();

                    // Step 2: Check if the username exists in the database
                    string userQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand userCmd = new MySqlCommand(userQuery, db.connection);
                    userCmd.Parameters.AddWithValue("@username", username);

                    int userCount = Convert.ToInt32(userCmd.ExecuteScalar());

                    if (userCount == 0)
                    {
                        // If username is not found in the database
                        MessageBox.Show("Username not found.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 3: If the username exists, prompt for the current password
                    string currentPassword = Microsoft.VisualBasic.Interaction.InputBox("Please enter your current password.", "Change Password", "");

                    if (string.IsNullOrEmpty(currentPassword))
                    {
                        MessageBox.Show("Please enter your current password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 4: Validate the current password by querying the database
                    string query = "SELECT password FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, db.connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    Console.WriteLine($"Stored password: {result}");  // Debugging

                    // Step 5: If the current password matches, proceed to change the password
                    if (result != null && result.ToString() == currentPassword)
                    {
                        // Step 6: Prompt for a new password
                        string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Please enter your new password.", "Change Password", "");

                        if (string.IsNullOrEmpty(newPassword))
                        {
                            MessageBox.Show("Please enter a new password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Step 7: Update the password in the database
                        string updateQuery = "UPDATE users SET password = @NewPassword WHERE username = @username";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.connection);
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        // Step 8: If update is successful, show success message
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Your password has been successfully updated.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error updating password. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // If current password is wrong
                        MessageBox.Show("The current password you entered is incorrect.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;
                workSheet.Name = "ExportedData";

                // Add column headers
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Add rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // AutoFit columns
                workSheet.Columns.AutoFit();

                // Make Excel visible
                excelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
