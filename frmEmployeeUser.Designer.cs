
namespace EmployeeManagement
{
    partial class frmEmployeeUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegulations = new System.Windows.Forms.Button();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.txtDepID = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.txtJoinDate = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpDayOfBirth = new System.Windows.Forms.TextBox();
            this.txtEmpGender = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbDepID = new System.Windows.Forms.Label();
            this.lbBankAccount = new System.Windows.Forms.Label();
            this.lbJoinDate = new System.Windows.Forms.Label();
            this.lbEmpDayOfBirth = new System.Windows.Forms.Label();
            this.lbEmpGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(427, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 39);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegulations
            // 
            this.btnRegulations.Location = new System.Drawing.Point(781, 383);
            this.btnRegulations.Name = "btnRegulations";
            this.btnRegulations.Size = new System.Drawing.Size(147, 53);
            this.btnRegulations.TabIndex = 41;
            this.btnRegulations.Text = "View Regulation";
            this.btnRegulations.UseVisualStyleBackColor = true;
            this.btnRegulations.Click += new System.EventHandler(this.btnRegulations_Click);
            // 
            // btnCertificate
            // 
            this.btnCertificate.Location = new System.Drawing.Point(569, 383);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(147, 53);
            this.btnCertificate.TabIndex = 40;
            this.btnCertificate.Text = "View Certificate";
            this.btnCertificate.UseVisualStyleBackColor = true;
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(253, 383);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(147, 53);
            this.btnSalary.TabIndex = 39;
            this.btnSalary.Text = "View Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // txtDepID
            // 
            this.txtDepID.Enabled = false;
            this.txtDepID.Location = new System.Drawing.Point(711, 264);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(217, 27);
            this.txtDepID.TabIndex = 37;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Enabled = false;
            this.txtBankAccount.Location = new System.Drawing.Point(711, 208);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(217, 27);
            this.txtBankAccount.TabIndex = 36;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Enabled = false;
            this.txtJoinDate.Location = new System.Drawing.Point(711, 151);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(217, 27);
            this.txtJoinDate.TabIndex = 35;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Enabled = false;
            this.txtEmpPhone.Location = new System.Drawing.Point(183, 319);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(217, 27);
            this.txtEmpPhone.TabIndex = 34;
            // 
            // txtEmpDayOfBirth
            // 
            this.txtEmpDayOfBirth.Enabled = false;
            this.txtEmpDayOfBirth.Location = new System.Drawing.Point(183, 264);
            this.txtEmpDayOfBirth.Name = "txtEmpDayOfBirth";
            this.txtEmpDayOfBirth.Size = new System.Drawing.Size(217, 27);
            this.txtEmpDayOfBirth.TabIndex = 33;
            // 
            // txtEmpGender
            // 
            this.txtEmpGender.Enabled = false;
            this.txtEmpGender.Location = new System.Drawing.Point(183, 208);
            this.txtEmpGender.Name = "txtEmpGender";
            this.txtEmpGender.Size = new System.Drawing.Size(217, 27);
            this.txtEmpGender.TabIndex = 32;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(183, 158);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(217, 27);
            this.txtEmpName.TabIndex = 31;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Location = new System.Drawing.Point(43, 319);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(50, 20);
            this.lbEmpPhone.TabIndex = 30;
            this.lbEmpPhone.Text = "Phone";
            // 
            // lbDepID
            // 
            this.lbDepID.AutoSize = true;
            this.lbDepID.Location = new System.Drawing.Point(523, 264);
            this.lbDepID.Name = "lbDepID";
            this.lbDepID.Size = new System.Drawing.Size(160, 20);
            this.lbDepID.TabIndex = 29;
            this.lbDepID.Text = "Belong To Department";
            // 
            // lbBankAccount
            // 
            this.lbBankAccount.AutoSize = true;
            this.lbBankAccount.Location = new System.Drawing.Point(523, 208);
            this.lbBankAccount.Name = "lbBankAccount";
            this.lbBankAccount.Size = new System.Drawing.Size(99, 20);
            this.lbBankAccount.TabIndex = 28;
            this.lbBankAccount.Text = "Bank Account";
            // 
            // lbJoinDate
            // 
            this.lbJoinDate.AutoSize = true;
            this.lbJoinDate.Location = new System.Drawing.Point(523, 158);
            this.lbJoinDate.Name = "lbJoinDate";
            this.lbJoinDate.Size = new System.Drawing.Size(71, 20);
            this.lbJoinDate.TabIndex = 27;
            this.lbJoinDate.Text = "Join Date";
            // 
            // lbEmpDayOfBirth
            // 
            this.lbEmpDayOfBirth.AutoSize = true;
            this.lbEmpDayOfBirth.Location = new System.Drawing.Point(43, 264);
            this.lbEmpDayOfBirth.Name = "lbEmpDayOfBirth";
            this.lbEmpDayOfBirth.Size = new System.Drawing.Size(90, 20);
            this.lbEmpDayOfBirth.TabIndex = 26;
            this.lbEmpDayOfBirth.Text = "Day Of Birth";
            // 
            // lbEmpGender
            // 
            this.lbEmpGender.AutoSize = true;
            this.lbEmpGender.Location = new System.Drawing.Point(43, 208);
            this.lbEmpGender.Name = "lbEmpGender";
            this.lbEmpGender.Size = new System.Drawing.Size(57, 20);
            this.lbEmpGender.TabIndex = 25;
            this.lbEmpGender.Text = "Gender";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(43, 158);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(119, 20);
            this.lbEmpName.TabIndex = 24;
            this.lbEmpName.Text = "Employee Name";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.Location = new System.Drawing.Point(397, 32);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(225, 45);
            this.lbWelcome.TabIndex = 22;
            this.lbWelcome.Text = "Welcome !!!";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(183, 111);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(217, 27);
            this.txtEmpID.TabIndex = 50;
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(43, 114);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 49;
            this.lbEmpID.Text = "Employee ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(43, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 58);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update Personal Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmEmployeeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 494);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegulations);
            this.Controls.Add(this.btnCertificate);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.txtDepID);
            this.Controls.Add(this.txtBankAccount);
            this.Controls.Add(this.txtJoinDate);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpDayOfBirth);
            this.Controls.Add(this.txtEmpGender);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lbEmpPhone);
            this.Controls.Add(this.lbDepID);
            this.Controls.Add(this.lbBankAccount);
            this.Controls.Add(this.lbJoinDate);
            this.Controls.Add(this.lbEmpDayOfBirth);
            this.Controls.Add(this.lbEmpGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmEmployeeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployeeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRegulations;
        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.TextBox txtDepID;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.TextBox txtJoinDate;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpDayOfBirth;
        private System.Windows.Forms.TextBox txtEmpGender;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbDepID;
        private System.Windows.Forms.Label lbBankAccount;
        private System.Windows.Forms.Label lbJoinDate;
        private System.Windows.Forms.Label lbEmpDayOfBirth;
        private System.Windows.Forms.Label lbEmpGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.Button btnUpdate;
    }
}