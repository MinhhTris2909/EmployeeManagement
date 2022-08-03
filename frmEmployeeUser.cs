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
    public partial class frmEmployeeUser : Form
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public IEmployeeRepository EmployeeRepository { get; set; }

        public Employee EmployeeInfo { get; set; }
        public frmEmployeeUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmEmployeeUser_Load(object sender, EventArgs e)
        {
            if (EmployeeInfo != null)
            {
                txtEmpID.Text = EmployeeInfo.EmpId.ToString();
                txtEmpName.Text = EmployeeInfo.EmpName;
                if (EmployeeInfo.EmpGender == true)
                {
                    txtEmpGender.Text = "Male";
                }
                else
                {
                    txtEmpGender.Text = "Female";
                }
                txtEmpDayOfBirth.Text = EmployeeInfo.EmpDayOfBirth.ToString();
                txtEmpPhone.Text = EmployeeInfo.EmpPhone;
                txtJoinDate.Text = EmployeeInfo.JoinDate.ToString();
                txtBankAccount.Text = EmployeeInfo.BankAccount;
                switch (EmployeeInfo.DepId)
                {
                    case "AD":
                        txtDepID.Text = "Accounting Department";
                        break;
                    case "BD":
                        txtDepID.Text = "Business Department";
                        break;
                    case "CD":
                        txtDepID.Text = "Contractors Department";
                        break;
                    case "RD":
                        txtDepID.Text = "Reception Department";
                        break;
                    case "TD":
                        txtDepID.Text = "Technical Department";
                        break;
                }

                
            }
            else
            {
                frmLogin frmLogin = new frmLogin();
                this.Close();
                frmLogin.Show();
            }
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            frmUserCertificate frmUserCertificate = new frmUserCertificate
            {
                EmployeeInfor=EmployeeInfo
            };
            frmUserCertificate.ShowDialog();

        }

        private void btnRegulations_Click(object sender, EventArgs e)
        {
            frmRegulation frmRegulation = new frmRegulation();
            frmRegulation.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmUserSalary frmUserSalary = new frmUserSalary {

                EmployeeInfor = EmployeeInfo
            };
            frmUserSalary.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails()
            {
                Text = "Update Employee",
                InsertOrUpdate = true,
                EmployeeInfor = GetEmployeeObject(),
                HideTextBox = true,
            };

            frmEmployeeDetails.Show();

        }

        private Employee GetEmployeeObject()
        {
            Employee employee = null;
            try
            {
                employee = employeeRepository.GetEmployeeByID(int.Parse(txtEmpID.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member ");
            }
            return employee;
        }
    }
}
