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
    public partial class frmRule : Form
    {
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        BindingSource source;
        public frmRule()
        {
            InitializeComponent();
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            LoadRuleList();
        }
        private void LoadRuleList()
        {
            try
            {
                var rules = rewardPunishmentRepository.GetRules();
                source = new BindingSource();
                source.DataSource = from r in rules 
                                    select new { 
                                        RuleID=r.RewardpunishId,
                                        RuleName=r.RewardpunishName,
                                        Type=r.RewardpunishType.Value?"Bonus":"Penalty",
                                        MoneyAmount=r.MoneyAmount,
                                        Status=r.Status.Value?"Active":"Inactive"
                                    };

                txtRuleID.DataBindings.Clear();
                txtRuleName.DataBindings.Clear();
                txtType.DataBindings.Clear();
                txtAmount.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtRuleID.DataBindings.Add("Text",source,"RuleID");
                txtRuleName.DataBindings.Add("Text", source, "RuleName");
                txtType.DataBindings.Add("Text", source, "Type");
                txtAmount.DataBindings.Add("Text", source, "MoneyAmount");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvRules.DataSource = source;
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
        private RewardPunishment GetRuleObject()
        {
            RewardPunishment rewardPunishment = null;
            try
            {
                rewardPunishment = new RewardPunishment {
                    RewardpunishId = int.Parse(txtRuleID.Text),
                    RewardpunishName=txtRuleName.Text,
                    RewardpunishType=(txtType.Text.Equals("Bonus")?true:false),
                    MoneyAmount=decimal.Parse(txtAmount.Text),
                    Status=(txtStatus.Text.Equals("Active")?true:false)
                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rewardPunishment;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var rule = GetRuleObject();
                DialogResult d = MessageBox.Show("Are you sure want to delete ???", "Caution !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    rewardPunishmentRepository.RemoveRule(rule.RewardpunishId);
                    LoadRuleList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Rule");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRuleDetail frmRuleDetail  = new frmRuleDetail
            {
                Text = "Update Rule",
                InsertOrUpdate = true,
                RuleInfor = GetRuleObject(),
            };
            frmRuleDetail.ShowDialog();
            LoadRuleList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRuleDetail frmRuleDetail = new frmRuleDetail
            {
                Text = "Update Rule",
                InsertOrUpdate = false
            };
            frmRuleDetail.ShowDialog();
            LoadRuleList();
        }
    }
}
