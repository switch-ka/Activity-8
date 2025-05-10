namespace GUICust
{
    partial class CostumeInfoForm
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
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(198, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 231);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(198, 260);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 20);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            // 
            // labelDescription
            // 
            labelDescription.Cursor = Cursors.No;
            labelDescription.Location = new Point(198, 304);
            labelDescription.Multiline = true;
            labelDescription.Name = "labelDescription";
            labelDescription.ReadOnly = true;
            labelDescription.ScrollBars = ScrollBars.Vertical;
            labelDescription.Size = new Size(382, 100);
            labelDescription.TabIndex = 2;
            // 
            // CostumeInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "CostumeInfoForm";
            Text = "CostumeInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelName;
        private TextBox labelDescription;
    }
}