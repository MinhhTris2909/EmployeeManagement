using BussinessObject.Models;
using DataAccess.Repository;
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
    public partial class frmUserSalary : Form
    {
        ISalaryRepository salaryRepository = new SalaryRepository();
        public Employee EmployeeInfor { get; set; }
        BindingSource source;
        public frmUserSalary()
        {
            InitializeComponent();
        }

        private void frmUserSalary_Load(object sender, EventArgs e)
        {
            LoadSalaries();
        }
        private void LoadSalaries()
        {
            try
            {
                var salaries = salaryRepository.GetSalaries().Where(sal=>sal.Status==true && sal.EmpId==EmployeeInfor.EmpId);
                source = new BindingSource();
                source.DataSource = salaries;

                txtEmpID.DataBindings.Clear();
                txtSalaryID.DataBindings.Clear();
                txtBaseIncome.DataBindings.Clear();
                txtMonth.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text", source, "EmpId");
                txtSalaryID.DataBindings.Add("Text", source, "SalaryId");
                txtBaseIncome.DataBindings.Add("Text", source, "Income");
                txtMonth.DataBindings.Add("Text", source, "MonthInYear");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvSalary.DataSource = source;

                dgvSalary.Columns["Emp"].Visible = false;
                dgvSalary.Columns["SalaryDetails"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserSalaryDetail frmUserSalaryDetail = new frmUserSalaryDetail
            {
                EmployeeInfor = EmployeeInfor,
                SalID = txtSalaryID.Text
            };
            frmUserSalaryDetail.Show();
        }
    }
}
