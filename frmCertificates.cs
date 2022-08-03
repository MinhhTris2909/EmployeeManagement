using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class frmCertificates : Form
    {
        ICertificateRepository certificateRepository = new CertificateRepository();
        BindingSource source;
        public frmCertificates()
        {
            InitializeComponent();
        }

        private void frmCertificates_Load(object sender, EventArgs e)
        {
            LoadCertificateList();

        }
        private void LoadCertificateList()
        {
            try
            {
                var certificates = certificateRepository.GetCertificates();
                source = new BindingSource();
                source.DataSource = certificates;


                txtEmpID.DataBindings.Clear();
                txtCertificateID.DataBindings.Clear();
                txtCertificateName.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                

                txtEmpID.DataBindings.Add("Text", source, "EmpId");
                txtCertificateID.DataBindings.Add("Text", source, "CerId");
                txtCertificateName.DataBindings.Add("Text", source, "CerName");
                txtDate.DataBindings.Add("Text", source, "CerDate");

                
                dgvCertificates.DataSource = null;
                dgvCertificates.DataSource = source;
                dgvCertificates.Columns["Emp"].Visible = false;


                if (certificates.Count() == 0)
                {
                    txtEmpID.Text = string.Empty;
                    txtCertificateID.Text = string.Empty;
                    txtCertificateName.Text = string.Empty;
                    txtDate.Text = string.Empty;                   
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Certificate List");
            }
        }
        private Certificate GetCertificateObject()
        {
            Certificate certificate = null;
            try
            {
                certificate = certificateRepository.GetCertificateByID(int.Parse(txtCertificateID.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Certificate ");
            }
            return certificate;
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var certificate = GetCertificateObject();
                DialogResult d = MessageBox.Show("Are you sure want to delete ???", "Caution !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    certificateRepository.RemoveCertificate(certificate.CerId);
                    LoadCertificateList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Certificate");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Update Certificate",
                InsertOrUpdate = true,
                CertificateInfor = GetCertificateObject(),
            };
            frmCertificateDetail.ShowDialog();
            LoadCertificateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Add Certificate",
                InsertOrUpdate = false
            };
            frmCertificateDetail.ShowDialog();
            LoadCertificateList();
        }

        private void dgvCertificates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Update Certificate",
                InsertOrUpdate = true,
                CertificateInfor = GetCertificateObject(),
            };
            frmCertificateDetail.ShowDialog();
            LoadCertificateList();
        }
    }
}
