
namespace EmployeeManagement
{
    partial class frmUserCertificate
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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCertificateName = new System.Windows.Forms.TextBox();
            this.txtCertificateID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbCerID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCertificates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(152, 83);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 27);
            this.txtEmpID.TabIndex = 90;
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(12, 86);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(54, 20);
            this.lbEmpID.TabIndex = 89;
            this.lbEmpID.Text = "EmpID";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(415, 35);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 27);
            this.txtDate.TabIndex = 88;
            // 
            // txtCertificateName
            // 
            this.txtCertificateName.Enabled = false;
            this.txtCertificateName.Location = new System.Drawing.Point(152, 130);
            this.txtCertificateName.Name = "txtCertificateName";
            this.txtCertificateName.Size = new System.Drawing.Size(427, 27);
            this.txtCertificateName.TabIndex = 87;
            // 
            // txtCertificateID
            // 
            this.txtCertificateID.Enabled = false;
            this.txtCertificateID.Location = new System.Drawing.Point(152, 41);
            this.txtCertificateID.Name = "txtCertificateID";
            this.txtCertificateID.Size = new System.Drawing.Size(164, 27);
            this.txtCertificateID.TabIndex = 86;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(368, 38);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(41, 20);
            this.lbGender.TabIndex = 85;
            this.lbGender.Text = "Date";
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(12, 133);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(121, 20);
            this.lbEmpName.TabIndex = 84;
            this.lbEmpName.Text = "Certificate Name";
            // 
            // lbCerID
            // 
            this.lbCerID.AutoSize = true;
            this.lbCerID.Location = new System.Drawing.Point(12, 44);
            this.lbCerID.Name = "lbCerID";
            this.lbCerID.Size = new System.Drawing.Size(96, 20);
            this.lbCerID.TabIndex = 83;
            this.lbCerID.Text = "Certificate ID";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(585, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 82;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(585, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCertificates
            // 
            this.dgvCertificates.AllowUserToAddRows = false;
            this.dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificates.Location = new System.Drawing.Point(12, 250);
            this.dgvCertificates.Name = "dgvCertificates";
            this.dgvCertificates.ReadOnly = true;
            this.dgvCertificates.RowHeadersWidth = 51;
            this.dgvCertificates.RowTemplate.Height = 29;
            this.dgvCertificates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCertificates.Size = new System.Drawing.Size(567, 188);
            this.dgvCertificates.TabIndex = 78;
            // 
            // frmUserCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCertificateName);
            this.Controls.Add(this.txtCertificateID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbCerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCertificates);
            this.Name = "frmUserCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Certificate";
            this.Load += new System.EventHandler(this.frmUserCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCertificateName;
        private System.Windows.Forms.TextBox txtCertificateID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbCerID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCertificates;
    }
}