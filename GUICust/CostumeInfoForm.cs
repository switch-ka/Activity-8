using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICust
{
    public partial class CostumeInfoForm : Form
    {

        public CostumeInfoForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void SetCostumeInfo(string name, string description, string imagePath)
        {
            labelName.Text = "Name: " + name;
            labelDescription.Text = "Description: " + description;

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
