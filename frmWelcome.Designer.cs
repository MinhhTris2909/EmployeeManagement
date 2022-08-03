
namespace EmployeeManagement
{
    partial class frmEmployeeManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Adminastor !!!";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(317, 344);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "label2";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.Location = new System.Drawing.Point(56, 100);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(124, 47);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCertificate
            // 
            this.btnCertificate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCertificate.Location = new System.Drawing.Point(56, 172);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(124, 47);
            this.btnCertificate.TabIndex = 3;
            this.btnCertificate.Text = "Certificate";
            this.btnCertificate.UseVisualStyleBackColor = true;
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalary.Location = new System.Drawing.Point(225, 100);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(124, 47);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(152, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRule
            // 
            this.btnRule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRule.Location = new System.Drawing.Point(225, 172);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(124, 47);
            this.btnRule.TabIndex = 6;
            this.btnRule.Text = "Rule";
            this.btnRule.UseVisualStyleBackColor = true;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatistics.Location = new System.Drawing.Point(138, 235);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(124, 47);
            this.btnStatistics.TabIndex = 7;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 383);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnCertificate);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.Button btnStatistics;
    }
}

