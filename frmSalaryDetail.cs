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
    public partial class frmSalaryDetail : Form
    {
        public String EmpID { get; set; }
        public String SalID { get; set; }
        public Salary SalaryInfor { get; set; }
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        ISalaryRepository salaryRepository = new SalaryRepository();
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        BindingSource source;
        public frmSalaryDetail()
        {
            InitializeComponent();
        }

        private void frmSalaryDetail_Load(object sender, EventArgs e)
        {
            if (SalaryInfor == null)
            {
                txtEmpID.Text = EmpID.ToString();
                txtSalaryID.Text = SalID.ToString();
                txtEmpName.Text = employeeRepository.GetEmployeeByID(int.Parse(EmpID)).EmpName.ToString();
                LoadSalaryDetail();
                DateTime d = DateTime.Now;
                var sal = salaryRepository.GetSalaryByID(int.Parse(SalID));
                if(sal.MonthInYear<d.Month || sal.Year < d.Year)
                {
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                txtEmpID.Text = EmpID.ToString();
                txtSalaryID.Text = SalaryInfor.SalaryId.ToString();
                txtEmpName.Text = employeeRepository.GetEmployeeByID(int.Parse(EmpID)).EmpName.ToString();
                lbSalaryID.Visible = false;
                txtSalaryID.Visible = false;
            }

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSalaryDetailV2()
        {
            try
            {

                var salaryDetail = salaryDetailRepository.GetSalaryDetailBySalID(SalaryInfor.SalaryId);
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var salaryDetail = salaryDetailRepository.GetSalaryDetailByID(int.Parse(txtSalaryDetail.Text));
                DialogResult d = MessageBox.Show("Are you sure want to delete ???", "Caution !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    salaryDetailRepository.RemoveSalaryDetail(salaryDetail.SalaryDetailId);
                    LoadSalaryDetail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete an Salary Detail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddSalaryDetail frmAddSalaryDetail = new frmAddSalaryDetail { 
                Name="Update",
                InsertOrUpdate=true,
                RuleInfo=rewardPunishmentRepository.GetRuleByID(int.Parse(txtRuleID.Text)),
                SalDetail=salaryDetailRepository.GetSalaryDetailByID(int.Parse(txtSalaryDetail.Text))
            };
            frmAddSalaryDetail.ShowDialog();
            LoadSalaryDetail();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SalaryInfor == null)
            {
                frmAddSalaryDetail frmAddSalaryDetail = new frmAddSalaryDetail
                {
                    Name = "Add",
                    InsertOrUpdate = false,
                    SalDetail = salaryDetailRepository.GetSalaryDetailByID(int.Parse(txtSalaryDetail.Text))
                };
                frmAddSalaryDetail.ShowDialog();
                LoadSalaryDetail();
            }
            else
            {
                frmAddSalaryDetail frmAddSalaryDetail = new frmAddSalaryDetail
                {
                    Name = "Add",
                    InsertOrUpdate = false,
                    SalaryInfor=SalaryInfor
                };
                frmAddSalaryDetail.ShowDialog();
                LoadSalaryDetailV2();
                txtEmpID.Text = EmpID.ToString();
                txtSalaryID.Text = SalaryInfor.SalaryId.ToString();
                txtEmpName.Text = employeeRepository.GetEmployeeByID(int.Parse(EmpID)).EmpName.ToString();
                lbSalaryID.Visible = true;
                txtSalaryID.Visible = true;
                SalID = SalaryInfor.SalaryId.ToString();
                SalaryInfor = null;
                
            }
        }

        
    }
}
