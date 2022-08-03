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
    public partial class frmRegulation : Form
    {
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();

        public frmRegulation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
        public void LoadRewardPunishment()
        {
            try
            {
                var RewardPunishmentList = rewardPunishmentRepository.GetRules().Where(re => re.Status == true);
                BindingSource source = new BindingSource();
                source.DataSource = RewardPunishmentList;
                source = new BindingSource();
                source.DataSource = from e in RewardPunishmentList
                                    select new
                                    {
                                        ID = e.RewardpunishId,
                                        Business_Rule = e.RewardpunishName,
                                        Business_Type = e.RewardpunishType.Value ? "Bonus" : "Punishment",
                                        Status = e.Status.Value ? "In Applied" : "In Discussion",
                                        money = e.MoneyAmount,
                                    };

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reward&Punishment Error!");
            }
        }

        private void frmRegulation_Load(object sender, EventArgs e)
        {
            LoadRewardPunishment();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmRulesCompany frmRulesCompany = new frmRulesCompany();
            frmRulesCompany.Show();
        }
    }
}
