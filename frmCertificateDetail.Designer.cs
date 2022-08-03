
namespace EmployeeManagement
{
    partial class frmCertificateDetail
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtCertificateName = new System.Windows.Forms.TextBox();
            this.txtCertificateID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbCerID = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(213, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(32, 91);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(58, 20);
            this.lbEmpID.TabIndex = 86;
            this.lbEmpID.Text = "Emp ID";
            // 
            // txtCertificateName
            // 
            this.txtCertificateName.Location = new System.Drawing.Point(172, 221);
            this.txtCertificateName.Name = "txtCertificateName";
            this.txtCertificateName.Size = new System.Drawing.Size(198, 27);
            this.txtCertificateName.TabIndex = 84;
            // 
            // txtCertificateID
            // 
            this.txtCertificateID.Location = new System.Drawing.Point(172, 41);
            this.txtCertificateID.Name = "txtCertificateID";
            this.txtCertificateID.Size = new System.Drawing.Size(198, 27);
            this.txtCertificateID.TabIndex = 83;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(32, 181);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(41, 20);
            this.lbGender.TabIndex = 82;
            this.lbGender.Text = "Date";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(32, 224);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(121, 20);
            this.lbEmpName.TabIndex = 81;
            this.lbEmpName.Text = "Certificate Name";
            // 
            // lbCerID
            // 
            this.lbCerID.AutoSize = true;
            this.lbCerID.Location = new System.Drawing.Point(32, 44);
            this.lbCerID.Name = "lbCerID";
            this.lbCerID.Size = new System.Drawing.Size(96, 20);
            this.lbCerID.TabIndex = 80;
            this.lbCerID.Text = "Certificate ID";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(172, 176);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(198, 27);
            this.dtpDate.TabIndex = 88;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(172, 131);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(198, 27);
            this.txtEmpName.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Emp Name";
            // 
            // cbEmpID
            // 
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(172, 88);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(198, 28);
            this.cbEmpID.TabIndex = 91;
            this.cbEmpID.SelectedIndexChanged += new System.EventHandler(this.cbEmpID_SelectedIndexChanged);
            // 
            // frmCertificateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 342);
            this.Controls.Add(this.cbEmpID);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.txtCertificateName);
            this.Controls.Add(this.txtCertificateID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbCerID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmCertificateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Detail";
            this.Load += new System.EventHandler(this.frmCertificateDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.TextBox txtCertificateName;
        private System.Windows.Forms.TextBox txtCertificateID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbCerID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpID;
    }
}