
namespace EmployeeManagement
{
    partial class frmSalaryDetail
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSalaryDetail = new System.Windows.Forms.DataGridView();
            this.txtSalaryID = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lbSalaryID = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalaryDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(742, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 104;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(742, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 103;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(742, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 102;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(742, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 101;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSalaryDetail
            // 
            this.dgvSalaryDetail.AllowUserToAddRows = false;
            this.dgvSalaryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryDetail.Location = new System.Drawing.Point(12, 333);
            this.dgvSalaryDetail.Name = "dgvSalaryDetail";
            this.dgvSalaryDetail.ReadOnly = true;
            this.dgvSalaryDetail.RowHeadersWidth = 51;
            this.dgvSalaryDetail.RowTemplate.Height = 29;
            this.dgvSalaryDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryDetail.Size = new System.Drawing.Size(724, 188);
            this.dgvSalaryDetail.TabIndex = 100;
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.Enabled = false;
            this.txtSalaryID.Location = new System.Drawing.Point(152, 123);
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.Size = new System.Drawing.Size(164, 27);
            this.txtSalaryID.TabIndex = 108;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(152, 26);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 27);
            this.txtEmpID.TabIndex = 107;
            // 
            // lbSalaryID
            // 
            this.lbSalaryID.AutoSize = true;
            this.lbSalaryID.Location = new System.Drawing.Point(12, 126);
            this.lbSalaryID.Name = "lbSalaryID";
            this.lbSalaryID.Size = new System.Drawing.Size(68, 20);
            this.lbSalaryID.TabIndex = 106;
            this.lbSalaryID.Text = "Salary ID";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(12, 29);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 105;
            this.lbEmpID.Text = "Employee ID";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(152, 75);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(164, 27);
            this.txtEmpName.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Employee Name";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(572, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(164, 27);
            this.txtAmount.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Amount";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(572, 123);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 27);
            this.txtType.TabIndex = 116;
            // 
            // txtRuleName
            // 
            this.txtRuleName.Enabled = false;
            this.txtRuleName.Location = new System.Drawing.Point(572, 75);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(164, 27);
            this.txtRuleName.TabIndex = 115;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Enabled = false;
            this.txtRuleID.Location = new System.Drawing.Point(572, 29);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(164, 27);
            this.txtRuleID.TabIndex = 114;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(432, 126);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(40, 20);
            this.lbGender.TabIndex = 113;
            this.lbGender.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Rule Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "Rule ID";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(572, 272);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 27);
            this.txtDate.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Date";
            // 
            // txtAmountMoney
            // 
            this.txtAmountMoney.Enabled = false;
            this.txtAmountMoney.Location = new System.Drawing.Point(572, 171);
            this.txtAmountMoney.Name = "txtAmountMoney";
            this.txtAmountMoney.Size = new System.Drawing.Size(164, 27);
            this.txtAmountMoney.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 121;
            this.label6.Text = "Amount Money";
            // 
            // txtSalaryDetail
            // 
            this.txtSalaryDetail.Enabled = false;
            this.txtSalaryDetail.Location = new System.Drawing.Point(152, 174);
            this.txtSalaryDetail.Name = "txtSalaryDetail";
            this.txtSalaryDetail.Size = new System.Drawing.Size(164, 27);
            this.txtSalaryDetail.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 123;
            this.label7.Text = "Salary Detail ID";
            // 
            // frmSalaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 534);
            this.Controls.Add(this.txtSalaryDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtRuleName);
            this.Controls.Add(this.txtRuleID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalaryID);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lbSalaryID);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSalaryDetail);
            this.Name = "frmSalaryDetail";
            this.Text = "Salary Detail";
            this.Load += new System.EventHandler(this.frmSalaryDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSalaryDetail;
        private System.Windows.Forms.TextBox txtSalaryID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lbSalaryID;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalaryDetail;
        private System.Windows.Forms.Label label7;
    }
}