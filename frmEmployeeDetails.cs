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
    public partial class frmEmployeeDetails : Form
    {
        public bool InsertOrUpdate { get; set; } //False: Insert; True: Update
        public Employee EmployeeInfor { get; set; }

        public bool HideTextBox { get; set; }

        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            dtpDayOfBirth.CustomFormat= "dd/MM/yyyy";
            dtpDayOfBirth.Format = DateTimePickerFormat.Custom;
            dtpJoinDate.Format = DateTimePickerFormat.Custom;
            LoadDepartment();
            txtEmpID.Enabled = !InsertOrUpdate;
            txtEmpID.Visible = InsertOrUpdate;
            lbEmpID.Visible = InsertOrUpdate;
            if (EmployeeInfor != null)
            {
                if (InsertOrUpdate == true) //Update Mode
                {
                    txtEmpID.Text = EmployeeInfor.EmpId.ToString();
                    txtEmpName.Text = EmployeeInfor.EmpName.ToString();
                    txtGender.Text = EmployeeInfor.EmpGender.Value ? "Male" : "Female";
                    dtpDayOfBirth.Value = EmployeeInfor.EmpDayOfBirth.Value;
                    txtPhone.Text = EmployeeInfor.EmpPhone.ToString();
                    txtBankAccount.Text = EmployeeInfor.BankAccount.ToString();
                    dtpJoinDate.Value = EmployeeInfor.JoinDate.Value;
                    cbDepartment.Text = GetDapartmentName();
                    txtPassword.Text = EmployeeInfor.Password.ToString();
                    txtStatus.Text = EmployeeInfor.Status.Value ? "Active" : "Inactive";
                    if (HideTextBox == true)
                    {
                        lbEmpID.Visible = false;
                        txtEmpID.Visible = false;
                        label5.Visible = false;
                        txtStatus.Visible = false;
                        btnViewCertificate.Visible = false;
                        btnViewSalary.Visible = false;
                    }

                }

            }
            else
            {
                btnViewCertificate.Visible = false;
                btnViewCertificate.Enabled = false;
                btnViewSalary.Enabled = false;
                btnViewSalary.Visible = false;
            }
        }
        private void LoadDepartment()
        {
            try
            {
                var departments = employeeRepository.GetDepartments();
                cbDepartment.DataSource = departments;
                cbDepartment.ValueMember = "DepID";
                cbDepartment.DisplayMember = "DepName";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private String GetDapartmentName()
        {
            string depName = null;
            var departments = employeeRepository.GetDepartments();
            var department = departments.SingleOrDefault(dep => dep.DepId == EmployeeInfor.DepId);
            depName = department.DepName;
            return depName;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.Match(txtPhone.Text.Trim(), @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$").Success)
                {

                    throw new Exception("Please input a valid Phone number !!!");
                }
                else
                {
                    if (txtBankAccount.Text == "" || txtEmpName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "")
                    {
                        throw new Exception("All field are required !!!");
                    }
                    else
                    {
                        if (InsertOrUpdate == false)
                        {
                            var employee = new Employee
                            {
                                EmpName = txtEmpName.Text,
                                EmpGender = txtGender.Text == "Male" ? true : false,
                                BankAccount = txtBankAccount.Text,
                                EmpDayOfBirth = dtpDayOfBirth.Value,
                                EmpPhone = txtPhone.Text,
                                JoinDate = dtpJoinDate.Value,
                                DepId = cbDepartment.SelectedValue.ToString(),
                                Password = txtPassword.Text,
                                Status=txtStatus.Text=="Active"?true:false
                            };
                        var employees = employeeRepository.GetEmployees();
                        Employee employee1 = employees.FirstOrDefault(emp => emp.EmpPhone.Equals(employee.EmpPhone.Trim()));
                        if (employee1 == null)
                        {
                            employeeRepository.AddEmployee(employee);
                            MessageBox.Show("Add Successfull !!!", "Add Rule", MessageBoxButtons.OK);
                        }
                        else
                        {
                            throw new Exception("Phone is valid !!!");
                        }
                        Close();
                    }
                        else
                        {
                            var employee = new Employee
                            {
                                EmpId = int.Parse(txtEmpID.Text),
                                EmpName = txtEmpName.Text,
                                EmpGender = txtGender.Text == "Male" ? true : false,
                                BankAccount = txtBankAccount.Text,
                                EmpDayOfBirth = dtpDayOfBirth.Value,
                                EmpPhone = txtPhone.Text,
                                JoinDate = dtpJoinDate.Value,
                                DepId = cbDepartment.SelectedValue.ToString(),
                                Password = txtPassword.Text,
                                Status = txtStatus.Text == "Active" ? true : false
                            };
                        var employees = employeeRepository.GetEmployees();
                        var employee2 = employees.Where(emp => !emp.EmpPhone.Equals(EmployeeInfor.EmpPhone));
                        Employee employee1 = employee2.FirstOrDefault(emp => emp.EmpPhone.Equals(employee.EmpPhone.Trim()));

                        if (employee1 == null)
                        {
                            employeeRepository.UpdateEmployee(employee);
                            MessageBox.Show("Update Successfull !!!", "Add Rule", MessageBoxButtons.OK);
                        }
                        else
                        {
                            throw new Exception("Phone is valid !!!");
                        }
                        Close();
                    }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            frmViewCertificate frmViewCertificate = new frmViewCertificate {            
                EmployeeInfor=EmployeeInfor
            };
            frmViewCertificate.ShowDialog();

        }

        private void dtpDayOfBirth_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now.Subtract(dtpDayOfBirth.Value);
            if (time.TotalDays < 6570 || time.TotalDays>21900)
            {
                MessageBox.Show("Employees must be older than 18 years old and younger than 60 years old !!!");
            }
            
        }

        private void btnViewSalary_Click(object sender, EventArgs e)
        {
            frmSalary frmSalary = new frmSalary { 
                EmployeeInfor=EmployeeInfor,
                FromEmp=true
            
            };
            frmSalary.ShowDialog();
        }
    }
}
