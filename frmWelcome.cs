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
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbTime.Text = dateTime.ToString("dd/MM/yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.Show();
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            frmCertificates frmCertificates = new frmCertificates();
            frmCertificates.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalary frmSalary = new frmSalary();
            frmSalary.Show();
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            frmRule frmRule = new frmRule();
            frmRule.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            frmStatistics frmStatistics = new frmStatistics();
            frmStatistics.Show();
        }
    }
}
