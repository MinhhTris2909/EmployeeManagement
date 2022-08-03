using BussinessObject.Models;
using Microsoft.Data.SqlClient;
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
    public partial class frmUserAddCer : Form
    {
        public Employee EmployeeInfor { get; set; }
        SqlConnection con = new SqlConnection("data source=MINHTRIS\\MINHTRIS; database=EmployeeManagement; uid=sa; password=123;");
        public frmUserAddCer()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                {
                    if (txtCerName.Text == "")
                    {
                        MessageBox.Show("Please input Certificate Name field", "Upload Certificate Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string certificateName = txtCerName.Text;
                        DateTime now = DateTime.Now;
                        string datetime = now.ToString("yyyy-MM-dd");
                        //we already define our connection globaly. We are just calling the object of connection. 
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Certificate (cerName, cerDate, urlImage, empID) values ('" + certificateName + "','" + datetime + "'," + "'\\images\\" + filename + "'," + EmployeeInfor.EmpId + ")", con);
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                        System.IO.File.Copy(openFileDialog1.FileName, path + "\\images\\" + filename);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Image uploaded successfully.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Error");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C:\\Users\\Dell\\Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        //label1.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

