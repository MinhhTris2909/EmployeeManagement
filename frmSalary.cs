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
    public partial class frmSalary : Form
    {
        public bool FromEmp { get; set; }
        public Employee EmployeeInfor { get; set; }
        ISalaryRepository salaryRepository = new SalaryRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        BindingSource source;
        public frmSalary()
        {
            InitializeComponent();
        }
        private void frmSalary_Load(object sender, EventArgs e)
        {
            if (FromEmp == true)
            {
                LoadSalaries_V2();
            }
            else
            {
                LoadSalaries();
            }
        }
        private void LoadSalaries()
        {
            try
            {
                var salaries = salaryRepository.GetSalaries();
                source = new BindingSource();
                source.DataSource = from s in salaries
                                    select new {
                                        EmpId = s.EmpId,
                                        SalaryId = s.SalaryId,
                                        Income = s.Income,
                                        MonthInYear = s.MonthInYear,
                                        Year = s.Year,
                                        Status = s.Status,
                                        Total = Total(s.SalaryId)+s.Income
                                    };

                txtEmpID.DataBindings.Clear();
                txtSalaryID.DataBindings.Clear();
                txtBaseIncome.DataBindings.Clear();
                txtMonth.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text",source,"EmpId");
                txtSalaryID.DataBindings.Add("Text", source, "SalaryId");
                txtBaseIncome.DataBindings.Add("Text", source, "Income");
                txtMonth.DataBindings.Add("Text", source, "MonthInYear");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtTotal.DataBindings.Add("Text", source, "Total");

                dgvSalary.DataSource = source;

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSalaries_V2()
        {
            try
            {
                var salaries = salaryRepository.GetSalaryByEmpID(EmployeeInfor.EmpId);
                source = new BindingSource();
                source.DataSource = from s in salaries
                                    select new
                                    {
                                        EmpId = s.EmpId,
                                        SalaryId = s.SalaryId,
                                        Income = s.Income,
                                        MonthInYear = s.MonthInYear,
                                        Year = s.Year,
                                        Status = s.Status,
                                        Total = Total(s.SalaryId) + s.Income
                                    };

                txtEmpID.DataBindings.Clear();
                txtSalaryID.DataBindings.Clear();
                txtBaseIncome.DataBindings.Clear();
                txtMonth.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text", source, "EmpId");
                txtSalaryID.DataBindings.Add("Text", source, "SalaryId");
                txtBaseIncome.DataBindings.Add("Text", source, "Income");
                txtMonth.DataBindings.Add("Text", source, "MonthInYear");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtTotal.DataBindings.Add("Text", source, "Total");

                dgvSalary.DataSource = source;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private decimal Total(int salID) {
            decimal total = 0;
            var salaries = salaryRepository.GetSalaries();
            var salary = salaries.SingleOrDefault(sal => sal.SalaryId == salID);
            var saldetail = salaryDetailRepository.GetSalaryDetailBySalID(salID);
            foreach(var s in saldetail)
            {
                decimal rulemoney = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).MoneyAmount.Value;
                bool check = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).RewardpunishType.Value;
                if (check == true)
                {
                    total +=  s.Amount.Value * rulemoney;
                }
                else
                {
                    total -=  s.Amount.Value * rulemoney;
                }


            }
            return total;

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var salaries = salaryRepository.GetSalaries();
            List<Salary> salary = new List<Salary>();
            foreach(var sal in salaries)
            {
                if(sal.MonthInYear==int.Parse(cbMonth.SelectedItem.ToString()) && sal.Year == int.Parse(cbYear.SelectedItem.ToString()))
                {
                    salary.Add(sal);
                }
            }
            if (salary.Count()!=0)
            {
                source = new BindingSource();
                source.DataSource = from s in salary
                                    select new
                                    {
                                        EmpId = s.EmpId,
                                        SalaryId = s.SalaryId,
                                        Income = s.Income,
                                        MonthInYear = s.MonthInYear,
                                        Year = s.Year,
                                        Status = s.Status,
                                        Total = Total(s.SalaryId) + s.Income
                                    };

                txtEmpID.DataBindings.Clear();
                txtSalaryID.DataBindings.Clear();
                txtBaseIncome.DataBindings.Clear();
                txtMonth.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtEmpID.DataBindings.Add("Text", source, "EmpId");
                txtSalaryID.DataBindings.Add("Text", source, "SalaryId");
                txtBaseIncome.DataBindings.Add("Text", source, "Income");
                txtMonth.DataBindings.Add("Text", source, "MonthInYear");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtTotal.DataBindings.Add("Text", source, "Total");

                dgvSalary.DataSource = source;
            }
            else
            {
                source = new BindingSource();
                source.DataSource = null;
                dgvSalary.DataSource = source;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
                    var salaries = salaryRepository.GetSalaries();
                    List<Salary> listSal = new List<Salary>();
                    foreach (var sal in salaries)
                    {
                        if (sal.EmpId == int.Parse(txtSearch.Text.Trim()))
                        {
                            listSal.Add(sal);
                        }
                    }
                    source = new BindingSource();
                    source.DataSource = from s in salaries
                                        select new
                                        {
                                            EmpId = s.EmpId,
                                            SalaryId = s.SalaryId,
                                            Income = s.Income,
                                            MonthInYear = s.MonthInYear,
                                            Year = s.Year,
                                            Status = s.Status,
                                            Total = Total(s.SalaryId) + s.Income
                                        };

                    txtEmpID.DataBindings.Clear();
                    txtSalaryID.DataBindings.Clear();
                    txtBaseIncome.DataBindings.Clear();
                    txtMonth.DataBindings.Clear();
                    txtYear.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();
                    txtTotal.DataBindings.Clear();

                    txtEmpID.DataBindings.Add("Text", source, "EmpId");
                    txtSalaryID.DataBindings.Add("Text", source, "SalaryId");
                    txtBaseIncome.DataBindings.Add("Text", source, "Income");
                    txtMonth.DataBindings.Add("Text", source, "MonthInYear");
                    txtYear.DataBindings.Add("Text", source, "Year");
                    txtStatus.DataBindings.Add("Text", source, "Status");
                    txtTotal.DataBindings.Add("Text", source, "Total");

                    dgvSalary.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
        private Salary GetSalaryObject()
        {
            Salary salary = null;
            try
            {
                salary = salaryRepository.GetSalaryByID(int.Parse(txtSalaryID.Text));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return salary;
        }

        private void dgvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSalaryDetail frmSalaryDetail = new frmSalaryDetail {     
                EmpID=txtEmpID.Text,
                SalID=txtSalaryID.Text
            };
            frmSalaryDetail.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateSalary frmUpdateSalary = new frmUpdateSalary { 
                SalaryInfor=GetSalaryObject()
                
            };
            frmUpdateSalary.ShowDialog();
            LoadSalaries();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (FromEmp == false)
            {
                frmAddSalary frmAddSalary = new frmAddSalary
                {
                    SalaryInfor = GetSalaryObject(),
                    FromEmp=false
                };
                frmAddSalary.ShowDialog();
                LoadSalaries();
            }
            else
            {
                frmAddSalary frmAddSalary = new frmAddSalary
                {
                    SalaryInfor = GetSalaryObject(),
                    FromEmp=true,
                    EmployeeInfor=EmployeeInfor
                };
                frmAddSalary.ShowDialog();
                LoadSalaries_V2();
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            if (int.Parse(txtMonth.Text) < d.Month)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }
    }
}
