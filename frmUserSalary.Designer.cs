
namespace EmployeeManagement
{
    partial class frmUserSalary
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseIncome = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtSalaryID = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lbDayOfBirth = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(533, 128);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(164, 27);
            this.txtStatus.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Status";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(351, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 121;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(533, 84);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(164, 27);
            this.txtYear.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Year";
            // 
            // txtBaseIncome
            // 
            this.txtBaseIncome.Enabled = false;
            this.txtBaseIncome.Location = new System.Drawing.Point(174, 125);
            this.txtBaseIncome.Name = "txtBaseIncome";
            this.txtBaseIncome.Size = new System.Drawing.Size(164, 27);
            this.txtBaseIncome.TabIndex = 116;
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(533, 36);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(164, 27);
            this.txtMonth.TabIndex = 115;
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.Enabled = false;
            this.txtSalaryID.Location = new System.Drawing.Point(174, 80);
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.Size = new System.Drawing.Size(164, 27);
            this.txtSalaryID.TabIndex = 114;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(174, 33);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 27);
            this.txtEmpID.TabIndex = 113;
            // 
            // lbDayOfBirth
            // 
            this.lbDayOfBirth.AutoSize = true;
            this.lbDayOfBirth.Location = new System.Drawing.Point(34, 128);
            this.lbDayOfBirth.Name = "lbDayOfBirth";
            this.lbDayOfBirth.Size = new System.Drawing.Size(93, 20);
            this.lbDayOfBirth.TabIndex = 112;
            this.lbDayOfBirth.Text = "Base Income";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(393, 39);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 20);
            this.lbGender.TabIndex = 111;
            this.lbGender.Text = "Month";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(34, 83);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(68, 20);
            this.lbEmpName.TabIndex = 110;
            this.lbEmpName.Text = "Salary ID";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(34, 36);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 109;
            this.lbEmpID.Text = "Employee ID";
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(12, 229);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowTemplate.Height = 29;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(776, 188);
            this.dgvSalary.TabIndex = 102;
            this.dgvSalary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellDoubleClick);
            // 
            // frmUserSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseIncome);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtSalaryID);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lbDayOfBirth);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.dgvSalary);
            this.Name = "frmUserSalary";
            this.Text = "frmUserSalary";
            this.Load += new System.EventHandler(this.frmUserSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseIncome;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtSalaryID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lbDayOfBirth;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.DataGridView dgvSalary;
    }
}