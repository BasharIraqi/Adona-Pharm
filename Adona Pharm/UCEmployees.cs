using Adona_Pharm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adona_Pharm
{
    public partial class UCEmployees : UserControl
    {
        public UCEmployees()
        {
            InitializeComponent();
            AddEmployeePanel.Visible = false;
            UpdateEmployeePanel.Visible = false;
            DeleteEmployeePanel.Visible = false;
            ShowEmployeePanel.Visible = false;
            this.Controls.Add(btnBack);
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                label40.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    label40.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        label40.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        label40.Text = "Login User: General";
                    }
                }

            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeePanel.Visible = true;
            UpdateEmployeePanel.Visible = false;
            DeleteEmployeePanel.Visible = false;
            ShowEmployeePanel.Visible = false;
            AddEmployeePanel.Dock = DockStyle.Fill;
            this.Controls.Add(AddEmployeePanel);
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                lblLoginType.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    lblLoginType.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        lblLoginType.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        lblLoginType.Text = "Login User: General";
                    }
                }

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeePanel.Visible = false;
            UpdateEmployeePanel.Visible = true;
            DeleteEmployeePanel.Visible = false;
            ShowEmployeePanel.Visible = false;
            UpdateEmployeePanel.Dock = DockStyle.Fill;
            this.Controls.Add(UpdateEmployeePanel);
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                label37.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    label37.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        label37.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        label37.Text = "Login User: General";
                    }
                }

            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeePanel.Visible = false;
            UpdateEmployeePanel.Visible = false;
            DeleteEmployeePanel.Visible = true;
            ShowEmployeePanel.Visible = false;
            DeleteEmployeePanel.Dock = DockStyle.Fill;
            this.Controls.Add(DeleteEmployeePanel);
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                label38.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    label38.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        label38.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        label38.Text = "Login User: General";
                    }
                }
            }
        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeePanel.Visible = false;
            UpdateEmployeePanel.Visible = false;
            DeleteEmployeePanel.Visible = false;
            ShowEmployeePanel.Visible = true;
            ShowEmployeePanel.Dock = DockStyle.Fill;
            this.Controls.Add(ShowEmployeePanel);
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                label39.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    label39.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        label39.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        label39.Text = "Login User: General";
                    }
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Amount = int.Parse(txtAmount.Text),
                DepartmentId = int.Parse(txtDepatmentId.Text),
                DepartmentName = txtDepartmentName.Text,
                Email = txtEmail.Text,
                City = txtCity.Text,
                Address = txtAddress.Text,
                StartedDate = dtpStartedDate.Value,
                EndDate = dtpEndDate.Value,
                RelationShip = txtRelationship.Text,
                BankAccount = txtBankAccount.Text,
                BankName = txtBankName.Text,
                JobId = int.Parse(txtJobId.Text),
            };
            using (var db = new AdonaPharmContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Employee Added Successfully");
            }
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAmount.Clear();
            txtDepatmentId.Clear();
            txtDepartmentName.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            dtpStartedDate.ResetText();
            dtpEndDate.ResetText();
            txtRelationship.Clear();
            txtBankAccount.Clear();
            txtBankName.Clear();
            txtJobId.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getEmployee = db.Employees.Find(int.Parse(txtUEmployeeId.Text));
                getEmployee.FirstName = txtUFirstName.Text;
                getEmployee.LastName = txtULastName.Text;
                getEmployee.Amount = decimal.Parse(txtUAmount.Text);
                getEmployee.DepartmentId = int.Parse(txtUDepartmentId.Text);
                getEmployee.DepartmentName = txtUDepartmentName.Text;
                getEmployee.Email = txtUEmail.Text;
                getEmployee.City = txtUCity.Text;
                getEmployee.Address = txtUAddress.Text;
                getEmployee.StartedDate = dtpUStartedDate.Value;
                getEmployee.EndDate = dtpUEndDate.Value;
                getEmployee.RelationShip = txtURelationship.Text;
                getEmployee.BankAccount = txtUBankAccount.Text;
                getEmployee.BankName = txtUBankName.Text;
                getEmployee.JobId = int.Parse(txtUJobId.Text);
                db.SaveChanges();
                var employeeList = db.Employees.Where(w => w.EmployeeId == int.Parse(txtUEmployeeId.Text)).Select(s => new
                {
                    s.EmployeeId,
                    s.FirstName,
                    s.LastName,
                    s.Amount,
                    s.DepartmentId,
                    s.DepartmentName,
                    s.Email,
                    s.City,
                    s.Address,
                    s.StartedDate,
                    s.EndDate,
                    s.RelationShip,
                    s.BankAccount,
                    s.BankName,
                    s.JobId
                }).ToList();
                dgvUpdate.DataSource = employeeList;
                dgvUpdate.Dock = DockStyle.Bottom;
            }
            txtUEmployeeId.Clear();
            txtUFirstName.Clear();
            txtULastName.Clear();
            txtUAmount.Clear();
            txtUDepartmentId.Clear();
            txtUDepartmentName.Clear();
            txtUEmail.Clear();
            txtUCity.Clear();
            txtUAddress.Clear();
            dtpUStartedDate.ResetText();
            dtpUEndDate.ResetText();
            txtURelationship.Clear();
            txtUBankAccount.Clear();
            txtUBankName.Clear();
            txtUJobId.Clear();
        }

        private void btnUShow_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getEmployee = db.Employees.Find(int.Parse(txtUEmployeeId.Text));
                if (getEmployee == null)
                {
                    MessageBox.Show("not exist Employee!!!!!");
                }
                else
                {
                    txtUFirstName.Text = getEmployee.FirstName;
                    txtULastName.Text = getEmployee.LastName;
                    txtUAmount.Text = getEmployee.Amount.ToString();
                    txtUDepartmentId.Text = getEmployee.DepartmentId.ToString();
                    txtUDepartmentName.Text = getEmployee.DepartmentName;
                    txtUEmail.Text = getEmployee.Email;
                    txtUCity.Text = getEmployee.City;
                    txtUAddress.Text = getEmployee.Address;
                    dtpUStartedDate.Value = getEmployee.StartedDate.GetValueOrDefault();
                    dtpUEndDate.Value = getEmployee.EndDate.GetValueOrDefault();
                    txtURelationship.Text = getEmployee.RelationShip;
                    txtUBankAccount.Text = getEmployee.BankAccount;
                    txtUBankName.Text = getEmployee.BankName;
                    txtUJobId.Text = getEmployee.JobId.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getEmployee = db.Employees.Find(int.Parse(txtDEmployeeId.Text));
                if (getEmployee != null)
                {
                    db.Employees.Remove(getEmployee);
                    db.SaveChanges();
                    MessageBox.Show("Employee Deleted Successfully");
                }
                else
                    MessageBox.Show("Invalid Employee Id");
            }
            txtDEmployeeId.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getEmployee = db.Employees.Find(int.Parse(txtEmployeeId.Text));
                if (getEmployee == null)
                {
                    MessageBox.Show("Invalid Employee Id");
                }
                else
                {
                    var employeeList = db.Employees.Where(w => w.EmployeeId == int.Parse(txtEmployeeId.Text)).Select(s => new
                    {
                        s.EmployeeId,
                        s.FirstName,
                        s.LastName,
                        s.Amount,
                        s.DepartmentId,
                        s.DepartmentName,
                        s.Email,
                        s.City,
                        s.Address,
                        s.StartedDate,
                        s.EndDate,
                        s.RelationShip,
                        s.BankAccount,
                        s.BankName,
                        s.JobId
                    }).ToList();
                    dgvShow.DataSource = employeeList;
                    dgvShow.Dock = DockStyle.Bottom;
                }
            }
            txtEmployeeId.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            var form1 = new Form1();
            form1.Visible = true;
        }
    }
}
