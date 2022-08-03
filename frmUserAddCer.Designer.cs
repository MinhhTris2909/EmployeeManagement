
namespace EmployeeManagement
{
    partial class frmUserAddCer
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbCertificate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtCerName = new System.Windows.Forms.TextBox();
            this.lbCerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(831, 676);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(122, 29);
            this.btnUpload.TabIndex = 10;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(400, 676);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse File";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbCertificate
            // 
            this.lbCertificate.AutoSize = true;
            this.lbCertificate.Font = new System.Drawing.Font("Poor Richard", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCertificate.ForeColor = System.Drawing.Color.Blue;
            this.lbCertificate.Location = new System.Drawing.Point(464, 13);
            this.lbCertificate.Name = "lbCertificate";
            this.lbCertificate.Size = new System.Drawing.Size(349, 47);
            this.lbCertificate.TabIndex = 8;
            this.lbCertificate.Text = "Your Cerficate Here:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCerName
            // 
            this.txtCerName.Location = new System.Drawing.Point(552, 85);
            this.txtCerName.Name = "txtCerName";
            this.txtCerName.Size = new System.Drawing.Size(623, 27);
            this.txtCerName.TabIndex = 13;
            // 
            // lbCerName
            // 
            this.lbCerName.AutoSize = true;
            this.lbCerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCerName.Location = new System.Drawing.Point(90, 79);
            this.lbCerName.Name = "lbCerName";
            this.lbCerName.Size = new System.Drawing.Size(416, 31);
            this.lbCerName.TabIndex = 12;
            this.lbCerName.Text = "Input Certificate Name before upload";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 532);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserAddCer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 719);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lbCertificate);
            this.Controls.Add(this.txtCerName);
            this.Controls.Add(this.lbCerName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUserAddCer";
            this.Text = "frmUserAddCer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbCertificate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCerName;
        private System.Windows.Forms.Label lbCerName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}