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
    public partial class frmRuleDetail : Form
    {
        public RewardPunishment RuleInfor { get; set; }
        public bool InsertOrUpdate { get; set; }
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        public frmRuleDetail()
        {
            InitializeComponent();
        }

        private void frmRuleDetail_Load(object sender, EventArgs e)
        {
            txtRuleID.Enabled = !InsertOrUpdate;
            txtRuleID.Visible = InsertOrUpdate;
            lbRuleID.Visible = InsertOrUpdate;
            if (InsertOrUpdate == true) //Update Mode
            {
                txtRuleID.Text = RuleInfor.RewardpunishId.ToString();
                txtRuleName.Text = RuleInfor.RewardpunishName.ToString();
                txtType.Text = RuleInfor.RewardpunishType.Value ? "Bonus" : "Penalty";
                txtAmount.Text = RuleInfor.MoneyAmount.ToString();
                txtStatus.Text = RuleInfor.Status.Value ? "Active" : "Inactive";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtRuleName.Text == "" || txtAmount.Text == "")
                {
                    throw new Exception("All field are required !!!");
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        var rule = new RewardPunishment
                        {
                            RewardpunishName=txtRuleName.Text,
                            RewardpunishType=txtType.SelectedItem.Equals("Bonus")?true:false,
                            MoneyAmount=decimal.Parse(txtAmount.Text),
                            Status = txtStatus.Text.Equals("Active") ? true : false
                        };
                        rewardPunishmentRepository.AddRule(rule);
                        MessageBox.Show("Add Successfull !!!", "Add Rule", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        var rule = new RewardPunishment
                        {
                            RewardpunishId = int.Parse(txtRuleID.Text),
                            RewardpunishName = txtRuleName.Text,
                            RewardpunishType = txtType.SelectedItem.Equals("Bonus") ? true : false,
                            MoneyAmount = decimal.Parse(txtAmount.Text),
                            Status=txtStatus.Text.Equals("Active")?true:false
                        };
                        rewardPunishmentRepository.UpdateRule(rule);
                        MessageBox.Show("Update Successfull !!!", "Update Rule", MessageBoxButtons.OK);
                        Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
