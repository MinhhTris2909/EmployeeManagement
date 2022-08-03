using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmLogin : Form
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);

            var adminAccount = JsonSerializer.Deserialize<Employee>(json, null);

            string adPhone = adminAccount.EmpPhone;
            string adPassword = adminAccount.Password;
            try
            {
                if (txtPhone.Text.Equals(adPhone) && txtPassword.Text.Equals(adPassword))
                {
                    frmEmployeeManagement frmEmployeeManagement = new frmEmployeeManagement();
                    frmEmployeeManagement.Show();
                    this.Hide();
                }
                else
                {
                    
                        frmEmployeeUser frmEmployeeUser = new frmEmployeeUser
                        {
                            EmployeeInfo = GetEmployee(),
                            EmployeeRepository = employeeRepository,
                        };
                        frmEmployeeUser.Show();
                        this.Hide();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private Employee GetEmployee()
        {
            
                Employee employee = employeeRepository.GetEmployeeByPhone(txtPhone.Text);
                if (employee != null)
                {
                    if (employee.Status == false)
                {
                    MessageBox.Show("Your account is inactive, please contact with company for more information !", "Login Error");
                    return null;

                    
                    }
                    else if (employee.EmpPhone.Equals(txtPhone.Text.Trim()) && employee.Password.Equals(txtPassword.Text)) 
                    {
                    return employee;
                }
                    else
                    {
                        throw new Exception("Invalid Phone or Password !!!");
                        return null;
                    }
                }
                else
                {
                    throw new Exception("Invalid Phone or Password !!!");
                    return null;
                }
                return employee;
            
            
        }
    }
}

