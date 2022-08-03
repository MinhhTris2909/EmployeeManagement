using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmRulesCompany : Form
    {
        public frmRulesCompany()
        {
            InitializeComponent();
        }

        private void DisplayImage()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Height = 1000;
            pictureBox.Width = 750;
            pictureBox.Location = new Point(0, 0);
            Bitmap image = new Bitmap("D:/.NET Projects/EmployeeManagement/EmployeeManagement/images/Regulations.jpg");
            //Bitmap image = new Bitmap(@"C:\Users\Dell\Downloads\BlankComic.jpg"); //@"location"
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = (Image)image;
            Controls.Add(pictureBox);
        }

        private void frmRulesCompany_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }
    }
}
