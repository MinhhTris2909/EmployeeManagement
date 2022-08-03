
namespace EmployeeManagement
{
    partial class frmSalary
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
            this.lbError = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbError.Location = new System.Drawing.Point(12, 172);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 20);
            this.lbError.TabIndex = 75;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(71, 249);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Input Employee ID ...";
            this.txtSearch.Size = new System.Drawing.Size(157, 27);
            this.txtSearch.TabIndex = 73;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(12, 252);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 72;
            this.lbSearch.Text = "Search";
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(12, 282);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowTemplate.Height = 29;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(660, 188);
            this.dgvSalary.TabIndex = 71;
            this.dgvSalary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Year";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(453, 249);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(85, 28);
            this.cbMonth.TabIndex = 80;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbYear.Location = new System.Drawing.Point(587, 249);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(85, 28);
            this.cbYear.TabIndex = 81;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(525, 77);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(164, 27);
            this.txtYear.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Year";
            // 
            // txtBaseIncome
            // 
            this.txtBaseIncome.Enabled = false;
            this.txtBaseIncome.Location = new System.Drawing.Point(166, 118);
            this.txtBaseIncome.Name = "txtBaseIncome";
            this.txtBaseIncome.Size = new System.Drawing.Size(164, 27);
            this.txtBaseIncome.TabIndex = 89;
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(525, 29);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(164, 27);
            this.txtMonth.TabIndex = 88;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.Enabled = false;
            this.txtSalaryID.Location = new System.Drawing.Point(166, 73);
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.Size = new System.Drawing.Size(164, 27);
            this.txtSalaryID.TabIndex = 87;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(166, 26);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 27);
            this.txtEmpID.TabIndex = 86;
            // 
            // lbDayOfBirth
            // 
            this.lbDayOfBirth.AutoSize = true;
            this.lbDayOfBirth.Location = new System.Drawing.Point(26, 121);
            this.lbDayOfBirth.Name = "lbDayOfBirth";
            this.lbDayOfBirth.Size = new System.Drawing.Size(93, 20);
            this.lbDayOfBirth.TabIndex = 85;
            this.lbDayOfBirth.Text = "Base Income";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(385, 32);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 20);
            this.lbGender.TabIndex = 84;
            this.lbGender.Text = "Month";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(26, 76);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(68, 20);
            this.lbEmpName.TabIndex = 83;
            this.lbEmpName.Text = "Salary ID";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(26, 29);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 82;
            this.lbEmpID.Text = "Employee ID";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(678, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 99;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(678, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 97;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(678, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 98;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(525, 121);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(164, 27);
            this.txtStatus.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Status";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(337, 182);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 27);
            this.txtTotal.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 102;
            this.label5.Text = "Total";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 482);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dgvSalary);
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
    }
}