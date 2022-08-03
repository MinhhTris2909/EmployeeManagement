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
    public partial class frmUserCertificate : Form
    {
        public Employee EmployeeInfor { get; set; }
        ICertificateRepository certificateRepository = new CertificateRepository();
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        BindingSource source;
        public frmUserCertificate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmUserCertificate_Load(object sender, EventArgs e)
        {
            LoadCertificate();
        }
        private void LoadCertificate()
        {
            try
            {
                var certificates = certificateRepository.GetCertificates();
                var userCer = certificates.Where(cer => cer.EmpId == EmployeeInfor.EmpId);
                source = new BindingSource();
                source.DataSource = userCer;


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


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Certificate List");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserAddCer frmUserAddCer = new frmUserAddCer
            {
                EmployeeInfor = employeeRepository.GetEmployeeByID(EmployeeInfor.EmpId),
            };
            frmUserAddCer.ShowDialog();
            LoadCertificate();

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCertificateDetail frmCertificateDetail = new frmCertificateDetail
            {
                Text = "Update Certificate",
                InsertOrUpdate = true,
                CertificateInfor = GetCertificateObject(),

            };
            frmCertificateDetail.ShowDialog();
            LoadCertificate();
        }
    }
}
