
namespace EmployeeManagement
{
    partial class frmViewCertificate
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lbEmpName = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCertificateName = new System.Windows.Forms.TextBox();
            this.txtCertificateID = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCerID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCertificates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(165, 65);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(164, 27);
            this.txtEmpName.TabIndex = 50;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(165, 26);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(164, 27);
            this.txtEmpID.TabIndex = 49;
            // 
            // lbEmpName
            // 
            this.lbEmpName.AutoSize = true;
            this.lbEmpName.Location = new System.Drawing.Point(25, 68);
            this.lbEmpName.Name = "lbEmpName";
            this.lbEmpName.Size = new System.Drawing.Size(119, 20);
            this.lbEmpName.TabIndex = 48;
            this.lbEmpName.Text = "Employee Name";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(25, 29);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(94, 20);
            this.lbEmpID.TabIndex = 47;
            this.lbEmpID.Text = "Employee ID";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(165, 150);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 27);
            this.txtDate.TabIndex = 83;
            // 
            // txtCertificateName
            // 
            this.txtCertificateName.Enabled = false;
            this.txtCertificateName.Location = new System.Drawing.Point(165, 187);
            this.txtCertificateName.Name = "txtCertificateName";
            this.txtCertificateName.Size = new System.Drawing.Size(379, 27);
            this.txtCertificateName.TabIndex = 82;
            // 
            // txtCertificateID
            // 
            this.txtCertificateID.Enabled = false;
            this.txtCertificateID.Location = new System.Drawing.Point(165, 111);
            this.txtCertificateID.Name = "txtCertificateID";
            this.txtCertificateID.Size = new System.Drawing.Size(164, 27);
            this.txtCertificateID.TabIndex = 81;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(25, 150);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(41, 20);
            this.lbGender.TabIndex = 80;
            this.lbGender.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Certificate Name";
            // 
            // lbCerID
            // 
            this.lbCerID.AutoSize = true;
            this.lbCerID.Location = new System.Drawing.Point(25, 114);
            this.lbCerID.Name = "lbCerID";
            this.lbCerID.Size = new System.Drawing.Size(96, 20);
            this.lbCerID.TabIndex = 78;
            this.lbCerID.Text = "Certificate ID";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(450, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 88;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 87;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCertificates
            // 
            this.dgvCertificates.AllowUserToAddRows = false;
            this.dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificates.Location = new System.Drawing.Point(25, 227);
            this.dgvCertificates.Name = "dgvCertificates";
            this.dgvCertificates.ReadOnly = true;
            this.dgvCertificates.RowHeadersWidth = 51;
            this.dgvCertificates.RowTemplate.Height = 29;
            this.dgvCertificates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCertificates.Size = new System.Drawing.Size(419, 188);
            this.dgvCertificates.TabIndex = 84;
            this.dgvCertificates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCertificates_CellDoubleClick);
            // 
            // frmViewCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCertificates);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCertificateName);
            this.Controls.Add(this.txtCertificateID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCerID);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lbEmpName);
            this.Controls.Add(this.lbEmpID);
            this.Name = "frmViewCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Certificate";
            this.Load += new System.EventHandler(this.frmViewCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lbEmpName;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCertificateName;
        private System.Windows.Forms.TextBox txtCertificateID;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCerID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCertificates;
    }
}