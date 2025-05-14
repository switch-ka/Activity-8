namespace GUICust
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            lbl2 = new Label();
            label3 = new Label();
            SignUpbtn = new Button();
            LoginLbl = new LinkLabel();
            ForgotPassLbl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 453);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Username
            // 
            Username.Location = new Point(271, 167);
            Username.Name = "Username";
            Username.Size = new Size(262, 27);
            Username.TabIndex = 1;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(271, 233);
            Password.Name = "Password";
            Password.Size = new Size(262, 27);
            Password.TabIndex = 2;
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(271, 144);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Location = new Point(271, 210);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 20);
            lbl2.TabIndex = 5;
            lbl2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 275);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // SignUpbtn
            // 
            SignUpbtn.Location = new Point(271, 275);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(262, 42);
            SignUpbtn.TabIndex = 7;
            SignUpbtn.Text = "Sign Up";
            SignUpbtn.UseVisualStyleBackColor = true;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // LoginLbl
            // 
            LoginLbl.AutoSize = true;
            LoginLbl.BackColor = Color.Transparent;
            LoginLbl.Location = new Point(290, 320);
            LoginLbl.Name = "LoginLbl";
            LoginLbl.Size = new Size(226, 20);
            LoginLbl.TabIndex = 8;
            LoginLbl.TabStop = true;
            LoginLbl.Text = "Already have an account? Log In.";
            LoginLbl.LinkClicked += LoginLbl_LinkClicked;
            // 
            // ForgotPassLbl
            // 
            ForgotPassLbl.AutoSize = true;
            ForgotPassLbl.Location = new Point(338, 340);
            ForgotPassLbl.Name = "ForgotPassLbl";
            ForgotPassLbl.Size = new Size(125, 20);
            ForgotPassLbl.TabIndex = 9;
            ForgotPassLbl.TabStop = true;
            ForgotPassLbl.Text = "Forgot Password?";
            ForgotPassLbl.LinkClicked += ForgotPassLbl_LinkClicked;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ForgotPassLbl);
            Controls.Add(LoginLbl);
            Controls.Add(SignUpbtn);
            Controls.Add(label3);
            Controls.Add(lbl2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Name = "SignUp";
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
        private Label lbl2;
        private Label label3;
        private Button SignUpbtn;
        private LinkLabel LoginLbl;
        private LinkLabel ForgotPassLbl;
    }
}