
namespace EmployeeManagement
{
    partial class frmRuleDetail
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbRuleID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(167, 162);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(164, 27);
            this.txtAmount.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Amount";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(167, 66);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(164, 27);
            this.txtRuleName.TabIndex = 82;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Location = new System.Drawing.Point(167, 27);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(164, 27);
            this.txtRuleID.TabIndex = 81;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(27, 117);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(40, 20);
            this.lbGender.TabIndex = 80;
            this.lbGender.Text = "Type";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(27, 69);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(82, 20);
            this.lbEmpName.TabIndex = 79;
            this.lbEmpName.Text = "Rule Name";
            // 
            // lbRuleID
            // 
            this.lbRuleID.AutoSize = true;
            this.lbRuleID.Location = new System.Drawing.Point(27, 30);
            this.lbRuleID.Name = "lbRuleID";
            this.lbRuleID.Size = new System.Drawing.Size(57, 20);
            this.lbRuleID.TabIndex = 78;
            this.lbRuleID.Text = "Rule ID";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(185, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Bonus",
            "Penalty"});
            this.txtType.Location = new System.Drawing.Point(167, 114);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 28);
            this.txtType.TabIndex = 88;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.txtStatus.Location = new System.Drawing.Point(167, 215);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(164, 28);
            this.txtStatus.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Status";
            // 
            // frmRuleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 322);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRuleName);
            this.Controls.Add(this.txtRuleID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbRuleID);
            this.Name = "frmRuleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule Detail";
            this.Load += new System.EventHandler(this.frmRuleDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbRuleID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Label label1;
    }
}