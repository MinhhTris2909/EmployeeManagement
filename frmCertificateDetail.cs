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
    public partial class frmCertificateDetail : Form
    {
        public bool InsertOrUpdate { get; set; } //False: Insert; True: Update
        public bool FromViewUpdate { get; set; }
        public Certificate CertificateInfor { get; set; }
        ICertificateRepository certificateRepository = new CertificateRepository();
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public frmCertificateDetail()
        {
            InitializeComponent();
        }

        private void frmCertificateDetail_Load(object sender, EventArgs e)
        {
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            txtCertificateID.Enabled = !InsertOrUpdate;
            txtCertificateID.Visible = InsertOrUpdate;
            lbCerID.Visible = InsertOrUpdate;
            LoadEmployees();
            if (FromViewUpdate == true)
            {
                cbEmpID.Enabled = false;
                cbEmpID.Text = CertificateInfor.EmpId.ToString();

            }
            if (InsertOrUpdate == true) //Update Mode
            {
                cbEmpID.Text = CertificateInfor.EmpId.ToString();
                txtCertificateID.Text = CertificateInfor.CerId.ToString();
                txtCertificateName.Text = CertificateInfor.CerName.ToString();
                dtpDate.Value = CertificateInfor.CerDate.Value;               
            }
        }
        private void LoadEmployees()
        {
            var employees = employeeRepository.GetEmployees();
            cbEmpID.DataSource = employees;
            cbEmpID.ValueMember = "EmpId";
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbEmpID.SelectedIndex;
            var employees = employeeRepository.GetEmployees();
            txtEmpName.Text = employees[index].EmpName.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCertificateName.Text == "" || txtEmpName.Text == "" )
                {
                    throw new Exception("All field are required !!!");
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        var certificate = new Certificate
                        {
                            CerName=txtCertificateName.Text,
                            CerDate=dtpDate.Value,
                            EmpId=int.Parse(cbEmpID.SelectedValue.ToString())
                        };
                        certificateRepository.AddCertificate(certificate);
                        MessageBox.Show("Add Successfull !!!", "Add Certificate", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        var certificate = new Certificate
                        {
                            CerId=int.Parse(txtCertificateID.Text),
                            CerName = txtCertificateName.Text,
                            CerDate = dtpDate.Value,
                            EmpId = int.Parse(cbEmpID.SelectedValue.ToString())
                        };
                        certificateRepository.UpdateCertificate(certificate);
                        MessageBox.Show("Save Successfull !!!", "Update Certificate", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
