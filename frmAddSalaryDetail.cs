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
    public partial class frmAddSalaryDetail : Form
    {
        public RewardPunishment RuleInfo { get; set; }
        public bool InsertOrUpdate { get; set; }
        public SalaryDetail SalDetail { get; set; }
        public Salary SalaryInfor { get; set; }
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        ISalaryRepository salaryRepository = new SalaryRepository();
        public frmAddSalaryDetail()
        {
            InitializeComponent();
        }

        private void frmAddSalaryDetail_Load(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            LoadRuleList();
            if (InsertOrUpdate == true) //Update Mode
            {
                txtRuleName.Text = RuleInfo.RewardpunishName.ToString();
                txtAmount.Text = RuleInfo.MoneyAmount.ToString();
                txtType.Text = RuleInfo.RewardpunishType.Value ? "Bonus" : "Penalty";
                txtAmount.Text = SalDetail.Amount.ToString();
                dtpDate.Value = SalDetail.Date.Value;
                txtAmountMoney.Text = RuleInfo.MoneyAmount.ToString();
            }
        }
        private void LoadRuleList()
        {
            var rules = rewardPunishmentRepository.GetRules();
            txtRuleName.DataSource = rules;
            txtRuleName.DisplayMember = "RewardpunishName";
            txtRuleName.ValueMember = "RewardpunishId";
        }

        private void txtRuleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = txtRuleName.SelectedIndex;
            var rules = rewardPunishmentRepository.GetRules();
            txtAmountMoney.Text = rules[index].MoneyAmount.ToString();
            txtType.Text = (rules[index].RewardpunishType.Value)?"Bonus":"Penalty";
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtAmount.Text == "")
                {
                    throw new Exception("All field are required !!!");
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        if (SalaryInfor == null)
                        {
                            var salaryDetail = new SalaryDetail
                            {
                                SalaryId = SalDetail.SalaryId,
                                RewardpunishId = int.Parse(txtRuleName.SelectedValue.ToString()),
                                Date = dtpDate.Value,
                                Amount = int.Parse(txtAmount.Text)
                            };
                            if (SalDetail.Date.Value.Month == salaryDetail.Date.Value.Month && SalDetail.Date.Value.Year==salaryDetail.Date.Value.Year)
                            {
                                salaryDetailRepository.AddSalaryDetail(salaryDetail);
                                MessageBox.Show("Add Successfull !!!", "Add Salary Detail", MessageBoxButtons.OK);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Input Date invalid !!!!");
                            }
                        }
                        else
                        {
                            if (SalaryInfor.MonthInYear == dtpDate.Value.Month && SalaryInfor.Year == dtpDate.Value.Year)
                            {
                                salaryRepository.AddSalary(SalaryInfor);
                            var salaryDetail = new SalaryDetail
                            {
                                SalaryId = SalaryInfor.SalaryId,
                                RewardpunishId = int.Parse(txtRuleName.SelectedValue.ToString()),
                                Date = dtpDate.Value,
                                Amount = int.Parse(txtAmount.Text)
                            };
                            
                                salaryDetailRepository.AddSalaryDetail(salaryDetail);
                                MessageBox.Show("Add Successfull !!!", "Add Salary Detail", MessageBoxButtons.OK);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Input Date invalid !!!!");
                            }
                        }
                    }
                    else
                    {
                        var salaryDetail = new SalaryDetail
                        {
                            SalaryDetailId=SalDetail.SalaryDetailId,
                            SalaryId = SalDetail.SalaryId,
                            RewardpunishId = int.Parse(txtRuleName.SelectedValue.ToString()),
                            Date = dtpDate.Value,
                            Amount = int.Parse(txtAmount.Text)
                        };
                        if (SalDetail.Date.Value.Month == salaryDetail.Date.Value.Month && SalDetail.Date.Value.Year == salaryDetail.Date.Value.Year)
                        {
                            salaryDetailRepository.UpdateSalaryDetail(salaryDetail);
                            MessageBox.Show("Update Successfull !!!", "Update Rule", MessageBoxButtons.OK);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Input Date invalid !!!!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
