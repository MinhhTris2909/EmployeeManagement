
namespace EmployeeManagement
{
    partial class frmUpdateSalary
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaseIncome = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lbDayOfBirth = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.ComboBox();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "Year";
            // 
            // txtBaseIncome
            // 
            this.txtBaseIncome.Location = new System.Drawing.Point(171, 119);
            this.txtBaseIncome.Name = "txtBaseIncome";
            this.txtBaseIncome.Size = new System.Drawing.Size(164, 27);
            this.txtBaseIncome.TabIndex = 109;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(171, 74);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(164, 27);
            this.txtEmpName.TabIndex = 107;
            // 
            // lbDayOfBirth
            // 
            this.lbDayOfBirth.AutoSize = true;
            this.lbDayOfBirth.Location = new System.Drawing.Point(31, 122);
            this.lbDayOfBirth.Name = "lbDayOfBirth";
            this.lbDayOfBirth.Size = new System.Drawing.Size(93, 20);
            this.lbDayOfBirth.TabIndex = 105;
            this.lbDayOfBirth.Text = "Base Income";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(31, 174);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 20);
            this.lbGender.TabIndex = 104;
            this.lbGender.Text = "Month";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(31, 77);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(119, 20);
            this.lbEmpName.TabIndex = 103;
            this.lbEmpName.Text = "Employee Name";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(31, 30);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 102;
            this.lbEmpID.Text = "Employee ID";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(171, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 115;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.FormattingEnabled = true;
            this.txtEmpID.Location = new System.Drawing.Point(171, 27);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 28);
            this.txtEmpID.TabIndex = 116;
            this.txtEmpID.SelectedIndexChanged += new System.EventHandler(this.txtEmpID_SelectedIndexChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Items.AddRange(new object[] {
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
            this.txtMonth.Location = new System.Drawing.Point(171, 171);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(164, 28);
            this.txtMonth.TabIndex = 117;
            // 
            // txtYear
            // 
            this.txtYear.FormattingEnabled = true;
            this.txtYear.Items.AddRange(new object[] {
            "2021",
            "2022"});
            this.txtYear.Location = new System.Drawing.Point(171, 219);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(164, 28);
            this.txtYear.TabIndex = 118;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.txtStatus.Location = new System.Drawing.Point(171, 263);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(164, 28);
            this.txtStatus.TabIndex = 119;
            // 
            // frmUpdateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 386);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaseIncome);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lbDayOfBirth);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbEmpID);
            this.Name = "frmUpdateSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Salary";
            this.Load += new System.EventHandler(this.frmUpdateSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaseIncome;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lbDayOfBirth;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtEmpID;
        private System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.ComboBox txtYear;
        private System.Windows.Forms.ComboBox txtStatus;
    }
}