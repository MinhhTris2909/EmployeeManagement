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
    public partial class frmStatistics : Form
    {
        ISalaryRepository salaryRepository = new SalaryRepository();
        ISalaryDetailRepository salaryDetailRepository = new SalaryDetailRepository();
        IRewardPunishmentRepository rewardPunishmentRepository = new RewardPunishmentRepository();
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtTotalSalary.Text = TotalSalary().ToString();
            txtAverage.Text = Math.Round(Average(),2).ToString();
            txtBonus.Text = BonusCount().ToString();
            txtPenalty.Text = PenaltyCount().ToString();
        }

        private decimal TotalSalary()
        {
            decimal total = 0;
            var salaries = salaryRepository.GetSalaries().Where(sal => sal.MonthInYear.Value == int.Parse(cbMonth.Text) && sal.Year.Value == int.Parse(cbYear.Text));
            foreach(var s in salaries)
            {
                decimal baseIncome = s.Income.Value;
                var salary = salaries.SingleOrDefault(sal => sal.SalaryId == s.SalaryId);
                var saldetail = salaryDetailRepository.GetSalaryDetailBySalID(s.SalaryId);
                foreach (var sa in saldetail)
                {
                    decimal rulemoney = rewardPunishmentRepository.GetRuleByID(sa.RewardpunishId.Value).MoneyAmount.Value;
                    bool check = rewardPunishmentRepository.GetRuleByID(sa.RewardpunishId.Value).RewardpunishType.Value;
                    if (check == true)
                    {
                        total += sa.Amount.Value * rulemoney;
                    }
                    else
                    {
                        total -= sa.Amount.Value * rulemoney;
                    }
                }
                total += baseIncome;
            }
            return total;
        }
        private decimal Average()
        {
            var count = employeeRepository.GetEmployees().Count();
            decimal average = 0;
            average = TotalSalary() / decimal.Parse(count.ToString());
            return average;
        }
        private int BonusCount()
        {
            int count = 0;
            var salaryDetails = salaryDetailRepository.GetSalaryDetail();
            foreach(var s in salaryDetails)
            {
                if ((s.Date.Value.Year == int.Parse(cbYear.Text)) && (s.Date.Value.Month == int.Parse(cbMonth.Text)))
                {
                    var rule = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value);
                    if (rule.RewardpunishType == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private int PenaltyCount()
        {
            int count = 0;
            var salaryDetails = salaryDetailRepository.GetSalaryDetail();
            foreach (var s in salaryDetails)
            {
                if ((s.Date.Value.Year == int.Parse(cbYear.Text)) && (s.Date.Value.Month == int.Parse(cbMonth.Text)))
                {
                    var rule = rewardPunishmentRepository.GetRuleByID(s.RewardpunishId.Value);
                    if (rule.RewardpunishType == false)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        
    }
}
