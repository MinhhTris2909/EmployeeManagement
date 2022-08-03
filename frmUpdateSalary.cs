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
    public partial class frmUpdateSalary : Form
    {
        public Salary SalaryInfor { get; set; }
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        ISalaryRepository salaryRepository = new SalaryRepository();
        public frmUpdateSalary()
        {
            InitializeComponent();
        }

        private void frmUpdateSalary_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            txtEmpID.Text = SalaryInfor.EmpId.ToString();
            txtBaseIncome.Text = SalaryInfor.Income.ToString();
            txtMonth.Text = SalaryInfor.MonthInYear.ToString();
            txtYear.Text = SalaryInfor.Year.ToString();
            txtStatus.Text = SalaryInfor.Status.Value?"Active":"Inactive";
        }
        private void LoadEmployee()
        {
            var employees = employeeRepository.GetEmployees();
            txtEmpID.DataSource = employees;
            txtEmpID.ValueMember = "EmpId";

        }

        private void txtEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = txtEmpID.SelectedIndex;
            var employees = employeeRepository.GetEmployees();
            txtEmpName.Text = employees[index].EmpName.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var salary = new Salary { 
                    SalaryId=SalaryInfor.SalaryId,
                    EmpId=int.Parse(txtEmpID.SelectedValue.ToString()),
                    Income=decimal.Parse(txtBaseIncome.Text),
                    MonthInYear=int.Parse(txtMonth.Text.ToString()),
                    Year=int.Parse(txtYear.Text.ToString()),
                    Status=txtStatus.Text.Equals("Active")?true:false                               
                };
                salaryRepository.UpdateSalary(salary);
                MessageBox.Show("Update Successfull !!!", "Add Rule", MessageBoxButtons.OK);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
