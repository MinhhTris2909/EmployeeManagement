using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmAddSalary : Form
    {
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        ISalaryRepository salaryRepository = new SalaryRepository();
        public Salary SalaryInfor { get; set; }
        public bool FromEmp { get; set; }
        public Employee EmployeeInfor { get; set; }
        public frmAddSalary()
        {
            InitializeComponent();
        }

        private void frmAddSalary_Load(object sender, EventArgs e)
        {
            if (FromEmp == false) { 
                LoadEmployee(); 
            } 
            else
            {
                LoadEmployee();
                txtEmpID.SelectedValue = EmployeeInfor.EmpId;
                txtEmpID.Enabled = false;
            }
            
        }
       

       
        private void LoadEmployee()
        {
            var employees = employeeRepository.GetEmployees();
            txtEmpID.DataSource = employees;
            txtEmpID.ValueMember = "EmpId";

        }

        private void txtEmpID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var index = txtEmpID.SelectedIndex;
            var employees = employeeRepository.GetEmployees();
            txtEmpName.Text = employees[index].EmpName.ToString();
        }

        

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            if (!Regex.Match(txtBaseIncome.Text, "^\\d+$").Success
                || (txtBaseIncome.Text=="")) {
                MessageBox.Show("Income must be number");                     
            }else if (d.Month>int.Parse(txtMonth.Text))
            {
                MessageBox.Show("Month must in the current month or in the following months !!!");
            } 
            else {
                var salary = new Salary
                {
                    EmpId = int.Parse(txtEmpID.SelectedValue.ToString()),
                    Income = decimal.Parse(txtBaseIncome.Text),
                    MonthInYear = int.Parse(txtMonth.Text.ToString()),
                    Year = int.Parse(txtYear.Text.ToString()),
                    Status = txtStatus.Text.Equals("Active") ? true : false
                };
                var sal = salaryRepository.GetSalaryByEmpID(salary.EmpId.Value).Where(s=>s.MonthInYear==salary.MonthInYear&&s.Year==salary.Year);
                if (sal.Count() == 0) {
                    frmSalaryDetail frmSalaryDetail = new frmSalaryDetail
                    {
                        EmpID = int.Parse(txtEmpID.SelectedValue.ToString()).ToString(),
                        SalaryInfor = salary
                    };
                    frmSalaryDetail.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Salary already exist !!!");
                }
                
            }
        }
    }
}
