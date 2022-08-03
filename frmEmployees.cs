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
    public partial class frmEmployees : Form
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        BindingSource source;
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            
            LoadDepList();
            LoadEmployeeList();
            cbSearch.SelectedIndex = 0;
        }
        private void LoadDepList()
        {
            var department = employeeRepository.GetDepartments();
            department.Add(new Department { DepId = "All", DepName = "All" });
            cbDepartment.DataSource = department;
            cbDepartment.DisplayMember = "DepName";
            cbDepartment.ValueMember = "DepId";
            cbDepartment.SelectedValue = "All";
        }
        private void LoadEmployeeList()
        {
            try
            {
                var employees = employeeRepository.GetEmployees();
                source = new BindingSource();
                source.DataSource = from e in employees
                                    select new
                                    {
                                        ID = e.EmpId,
                                        Name = e.EmpName,
                                        Gender = (e.EmpGender.Value ? "Male" : "Female"),
                                        DayOfBirth = e.EmpDayOfBirth.Value.ToString("dd/MM/yyyy"),
                                        Phone = e.EmpPhone,
                                        JoinDate = e.JoinDate.Value.ToString("dd/MM/yyyy"),
                                        BankAccount = e.BankAccount,
                                        DepID = e.DepId,
                                        Status=e.Status.Value?"Active":"Inactive"
                                    };


                txtEmpID.DataBindings.Clear();
                txtEmpName.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtDayOfBirth.DataBindings.Clear();
                txtBankAccount.DataBindings.Clear();
                txtDepID.DataBindings.Clear();
                txtJoinDate.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text", source, "ID");
                txtEmpName.DataBindings.Add("Text", source, "Name");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtDayOfBirth.DataBindings.Add("Text", source, "DayOfBirth");
                txtBankAccount.DataBindings.Add("Text", source, "BankAccount");
                txtDepID.DataBindings.Add("Text", source, "DepId");
                txtJoinDate.DataBindings.Add("Text", source, "JoinDate");
                txtStatus.DataBindings.Add("Text", source, "Status");


                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = source;



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Employee List");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
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

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails
            {
                Text = "Update Employee",
                InsertOrUpdate = true,
                EmployeeInfor = GetEmployeeObject(),
            };
            frmEmployeeDetails.ShowDialog();
            LoadEmployeeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails
            {
                Text = "Add Employee",
                InsertOrUpdate = false,
            };
            frmEmployeeDetails.ShowDialog();
            LoadEmployeeList();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployeeDetails frmEmployeeDetails = new frmEmployeeDetails
            {
                Text = "Update Employee",
                InsertOrUpdate = true,
                EmployeeInfor = GetEmployeeObject(),
            };
            frmEmployeeDetails.ShowDialog();
            LoadEmployeeList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == 0)
            {
                if (!Regex.Match(txtSearch.Text, "^\\d+$").Success)
                {
                    lbError.Text = "ID must be a number !!!";
                }
                else
                {
                    lbError.Text = "";
                    try
                    {
                        var employees = employeeRepository.GetEmployees();
                        List<Employee> listEmp = new List<Employee>();
                        foreach (var emp in employees)
                        {
                            if (emp.EmpId == int.Parse(txtSearch.Text.Trim()))
                            {
                                listEmp.Add(emp);
                            }
                        }
                        source = new BindingSource();
                        source.DataSource = from emp in listEmp
                                            select new
                                            {
                                                ID = emp.EmpId,
                                                Name = emp.EmpName,
                                                Gender = (emp.EmpGender.Value ? "Male" : "Female"),
                                                DayOfBirth = emp.EmpDayOfBirth.Value.ToString("dd/MM/yyyy"),
                                                Phone = emp.EmpPhone,
                                                JoinDate = emp.JoinDate.Value.ToString("dd/MM/yyyy"),
                                                BankAccount = emp.BankAccount,
                                                DepID = emp.DepId
                                            };


                        txtEmpID.DataBindings.Clear();
                        txtEmpName.DataBindings.Clear();
                        txtGender.DataBindings.Clear();
                        txtPhone.DataBindings.Clear();
                        txtDayOfBirth.DataBindings.Clear();
                        txtBankAccount.DataBindings.Clear();
                        txtDepID.DataBindings.Clear();
                        txtJoinDate.DataBindings.Clear();

                        txtEmpID.DataBindings.Add("Text", source, "ID");
                        txtEmpName.DataBindings.Add("Text", source, "Name");
                        txtGender.DataBindings.Add("Text", source, "Gender");
                        txtPhone.DataBindings.Add("Text", source, "Phone");
                        txtDayOfBirth.DataBindings.Add("Text", source, "DayOfBirth");
                        txtBankAccount.DataBindings.Add("Text", source, "BankAccount");
                        txtDepID.DataBindings.Add("Text", source, "DepId");
                        txtJoinDate.DataBindings.Add("Text", source, "JoinDate");


                        dgvEmployees.DataSource = null;
                        dgvEmployees.DataSource = source;



                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Load Employee List");
                    }

                }
            }
            else
            {
                lbError.Text = "";
                try
                {
                    var employees = employeeRepository.GetEmployees();
                    List<Employee> listEmp = new List<Employee>();
                    foreach (var emp in employees)
                    {
                        if (emp.EmpName.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            listEmp.Add(emp);
                        }
                    }
                    source = new BindingSource();
                    source.DataSource = from emp in listEmp
                                        select new
                                        {
                                            ID = emp.EmpId,
                                            Name = emp.EmpName,
                                            Gender = (emp.EmpGender.Value ? "Male" : "Female"),
                                            DayOfBirth = emp.EmpDayOfBirth.Value.ToString("dd/MM/yyyy"),
                                            Phone = emp.EmpPhone,
                                            JoinDate = emp.JoinDate.Value.ToString("dd/MM/yyyy"),
                                            BankAccount = emp.BankAccount,
                                            DepID = emp.DepId
                                        };


                    txtEmpID.DataBindings.Clear();
                    txtEmpName.DataBindings.Clear();
                    txtGender.DataBindings.Clear();
                    txtPhone.DataBindings.Clear();
                    txtDayOfBirth.DataBindings.Clear();
                    txtBankAccount.DataBindings.Clear();
                    txtDepID.DataBindings.Clear();
                    txtJoinDate.DataBindings.Clear();

                    txtEmpID.DataBindings.Add("Text", source, "ID");
                    txtEmpName.DataBindings.Add("Text", source, "Name");
                    txtGender.DataBindings.Add("Text", source, "Gender");
                    txtPhone.DataBindings.Add("Text", source, "Phone");
                    txtDayOfBirth.DataBindings.Add("Text", source, "DayOfBirth");
                    txtBankAccount.DataBindings.Add("Text", source, "BankAccount");
                    txtDepID.DataBindings.Add("Text", source, "DepId");
                    txtJoinDate.DataBindings.Add("Text", source, "JoinDate");


                    dgvEmployees.DataSource = null;
                    dgvEmployees.DataSource = source;



                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Employee List");
                }
            }
        }

        

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedValue.Equals("All"))
            {
                LoadEmployeeList();
            }
            else
            {
                try
                {
                    var employees = employeeRepository.GetEmployees();
                    List<Employee> employeesList = new List<Employee>();
                    foreach (var emp in employees)
                    {
                        if (emp.DepId.Equals(cbDepartment.SelectedValue))
                        {
                            employeesList.Add(emp);
                        }
                    }
                    source = new BindingSource();
                    source.DataSource = from emp in employeesList
                                        select new
                                        {
                                            ID = emp.EmpId,
                                            Name = emp.EmpName,
                                            Gender = (emp.EmpGender.Value ? "Male" : "Female"),
                                            DayOfBirth = emp.EmpDayOfBirth.Value.ToString("dd/MM/yyyy"),
                                            Phone = emp.EmpPhone,
                                            JoinDate = emp.JoinDate.Value.ToString("dd/MM/yyyy"),
                                            BankAccount = emp.BankAccount,
                                            DepID = emp.DepId
                                        };


                    txtEmpID.DataBindings.Clear();
                    txtEmpName.DataBindings.Clear();
                    txtGender.DataBindings.Clear();
                    txtPhone.DataBindings.Clear();
                    txtDayOfBirth.DataBindings.Clear();
                    txtBankAccount.DataBindings.Clear();
                    txtDepID.DataBindings.Clear();
                    txtJoinDate.DataBindings.Clear();

                    txtEmpID.DataBindings.Add("Text", source, "ID");
                    txtEmpName.DataBindings.Add("Text", source, "Name");
                    txtGender.DataBindings.Add("Text", source, "Gender");
                    txtPhone.DataBindings.Add("Text", source, "Phone");
                    txtDayOfBirth.DataBindings.Add("Text", source, "DayOfBirth");
                    txtBankAccount.DataBindings.Add("Text", source, "BankAccount");
                    txtDepID.DataBindings.Add("Text", source, "DepId");
                    txtJoinDate.DataBindings.Add("Text", source, "JoinDate");


                    dgvEmployees.DataSource = null;
                    dgvEmployees.DataSource = source;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Employee List");
                }
            }
        }
    }
}
