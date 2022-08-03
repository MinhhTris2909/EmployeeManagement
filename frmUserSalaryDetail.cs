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
    public partial class frmUserSalaryDetail : Form
    {
        public Employee EmployeeInfor { get; set; }
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        BindingSource source;
        public string SalID { get; set; }
        public frmUserSalaryDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmUserSalaryDetail_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = EmployeeInfor.EmpId.ToString();
            txtSalaryID.Text = SalID.ToString();
            txtEmpName.Text = employeeRepository.GetEmployeeByID(int.Parse(EmployeeInfor.EmpId.ToString())).EmpName.ToString();
            LoadSalaryDetail();
        }
        private void LoadSalaryDetail()
        {
            try
            {
                var salaryDetail = salaryDetailRepository.GetSalaryDetailBySalID(int.Parse(SalID));
                source = new BindingSource();
                source.DataSource = from s in salaryDetail
                                    select new
                                    {
                                        SalaryDetailID = s.SalaryDetailId,
                                        RuleName = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).RewardpunishName,
                                        RuleID = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).RewardpunishId,
                                        Type = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).RewardpunishType.Value ? "Bonus" : "Penalty",
                                        Date = s.Date,
                                        MoneyAmount = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value).MoneyAmount,
                                        Amount = s.Amount
                                    };

                txtRuleID.DataBindings.Clear();
                txtRuleName.DataBindings.Clear();
                txtType.DataBindings.Clear();
                txtAmount.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                txtAmountMoney.DataBindings.Clear();
                txtSalaryDetail.DataBindings.Clear();

                txtSalaryDetail.DataBindings.Add("Text", source, "SalaryDetailID");
                txtRuleName.DataBindings.Add("Text", source, "RuleName");
                txtType.DataBindings.Add("Text", source, "Type");
                txtAmountMoney.DataBindings.Add("Text", source, "MoneyAmount");
                txtAmount.DataBindings.Add("Text", source, "Amount");
                txtDate.DataBindings.Add("Text", source, "Date");
                txtRuleID.DataBindings.Add("Text", source, "RuleID");

                dgvSalaryDetail.DataSource = source;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
