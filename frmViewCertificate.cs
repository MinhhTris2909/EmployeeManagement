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
    public partial class frmViewCertificate : Form
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        ICertificateRepository certificateRepository = new CertificateRepository();
        public Employee EmployeeInfor { get; set; }
        BindingSource source;
        public frmViewCertificate()
        {
            InitializeComponent();
        }

        private void frmViewCertificate_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = EmployeeInfor.EmpId.ToString();
            txtEmpName.Text = EmployeeInfor.EmpName.ToString();
            LoadCertificateList();
        }

        private Certificate GetCertificate()
        {
            Certificate certificate = null;
            try
            {
                 certificate = certificateRepository.GetCertificateByID(int.Parse(txtCertificateID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return certificate;
        }
        private void LoadCertificateList()
        {
            try
            {
                var certificates = certificateRepository.GetCertificatesByEmpID(EmployeeInfor.EmpId);
                source = new BindingSource();
                source.DataSource = certificates;

                txtCertificateID.DataBindings.Clear();
                txtCertificateName.DataBindings.Clear();
                txtDate.DataBindings.Clear();

                txtCertificateID.DataBindings.Add("Text",source,"CerId");
                txtCertificateName.DataBindings.Add("Text", source, "CerName");
                txtDate.DataBindings.Add("Text", source, "CerDate");

                dgvCertificates.DataSource = source;
                dgvCertificates.Columns["Emp"].Visible = false;
                dgvCertificates.Columns["EmpId"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Update Certificate",
                InsertOrUpdate = true,
                FromViewUpdate=true,
                CertificateInfor = GetCertificate(),
            };
            frmCertificateDetail.ShowDialog();
            LoadCertificateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Add Certificate",
                CertificateInfor = GetCertificate(),
                FromViewUpdate = true,
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
                FromViewUpdate = true,
                CertificateInfor = GetCertificate(),
            };
            frmCertificateDetail.ShowDialog();
            LoadCertificateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var certificate = GetCertificate();
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
    }
}
