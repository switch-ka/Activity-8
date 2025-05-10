namespace GUICust
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            SignUpLblLink = new LinkLabel();
            ForgotPassLbl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Username
            // 
            Username.Location = new Point(286, 173);
            Username.Name = "Username";
            Username.Size = new Size(245, 27);
            Username.TabIndex = 1;
            Username.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(286, 241);
            Password.Name = "Password";
            Password.Size = new Size(245, 27);
            Password.TabIndex = 2;
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(286, 150);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(286, 218);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(286, 292);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(245, 45);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignUpLblLink
            // 
            SignUpLblLink.AutoSize = true;
            SignUpLblLink.BackColor = Color.Transparent;
            SignUpLblLink.Location = new Point(299, 340);
            SignUpLblLink.Name = "SignUpLblLink";
            SignUpLblLink.Size = new Size(219, 20);
            SignUpLblLink.TabIndex = 6;
            SignUpLblLink.TabStop = true;
            SignUpLblLink.Text = "Dont have an account? Sign Up.";
            SignUpLblLink.LinkClicked += SignUpLblLink_LinkClicked;
            // 
            // ForgotPassLbl
            // 
            ForgotPassLbl.AutoSize = true;
            ForgotPassLbl.Location = new Point(328, 360);
            ForgotPassLbl.Name = "ForgotPassLbl";
            ForgotPassLbl.Size = new Size(160, 20);
            ForgotPassLbl.TabIndex = 7;
            ForgotPassLbl.TabStop = true;
            ForgotPassLbl.Text = "Forgot your password?";
            ForgotPassLbl.LinkClicked += ForgotPassLbl_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ForgotPassLbl);
            Controls.Add(SignUpLblLink);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private LinkLabel SignUpLblLink;
        private LinkLabel ForgotPassLbl;
    }
}