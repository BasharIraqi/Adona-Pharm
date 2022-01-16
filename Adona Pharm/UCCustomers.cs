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
    public partial class UCCustomers : UserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
            AddPanel.Visible = false;
            ShowAllPanel.Visible = false;
            DeletePanel.Visible = false;
            this.Controls.Add(btnBack);
            if(Form1.userName=="Director"&&Form1.password=="ddd123456")
            {
                label4.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" &&Form1.password == "d123456")
                {
                    label4.Text = "Login User: Department Manager";
                }
                else
                {
                    if(Form1.userName =="Shift Manager"&&Form1.password =="sm123")
                    {
                        label4.Text="Login User: Shift Manager";
                    }
                    else
                    {
                        label4.Text = "Login User: General";
                    }
                }

            }
        }

        private void showCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            ShowAllPanel.Visible = false;
            DeletePanel.Visible=false;
            AddPanel.Dock = DockStyle.Fill;
            this.Controls.Add(AddPanel);

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

        private void showCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            ShowAllPanel.Visible = true;
            DeletePanel.Visible = false;
            ShowAllPanel.Dock = DockStyle.Fill;
            this.Controls.Add((ShowAllPanel));
            if (Form1.userName == "Director" && Form1.password == "ddd123456")
            {
                label3.Text = "Login User: Director";
            }
            else
            {
                if (Form1.userName == "Department Manager" && Form1.password == "d123456")
                {
                    label3.Text = "Login User: Department Manager";
                }
                else
                {
                    if (Form1.userName == "Shift Manager" && Form1.password == "sm123")
                    {
                        label3.Text = "Login User: Shift Manager";
                    }
                    else
                    {
                        label3.Text = "Login User: General";
                    }
                }

            }
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            using (var db=new AdonaPharmContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Customer Added Successfully");
            }
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtCreditCardNumber.Clear();
            txtOrderId.Clear();
            txtPhoneNumber.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            var form1 = new Form1();
            form1.Visible = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var customerList = db.Customers.Where(w=>w.CustomerId==int.Parse(txtSCustomerId.Text)).Select(s => new
                {
                    s.CustomerId,
                    s.FirstName,
                    s.LastName,
                    s.Email,
                    s.City,
                    s.Address,
                    s.PhoneNumber,
                    s.CreditCardNumber,
                    s.Orders,
                    s.Order.Products,
                }).ToList();
                var customerOrders = db.Customers.Where(w => w.Order.CustomerId == w.CustomerId).Select(s => new { s.Order.OrderId, s.Order.Price, s.Order.ReperationDate, s.Order.ResieveDate }).ToList();
                var orderProducts = db.Products.Where(w => w.OrderId == w.Order.OrderId).Select(s => new { s.ProductName,s.OrderId }).ToList();
                dvgShowAll.DataSource = customerList;
                dgvOrders.DataSource = customerOrders;
                dgvProducts.DataSource = orderProducts;
                
            }
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            ShowAllPanel.Visible = false;
            DeletePanel.Visible = true;
            DeletePanel.Dock = DockStyle.Fill;
            this.Controls.Add(DeletePanel);

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db=new AdonaPharmContext())
            {
                var customer = db.Customers.Find(int.Parse(txtDCustomerId.Text));
                if (customer != null)
                {
                    MessageBox.Show("Customer Does not Exist");
                }
                else
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    MessageBox.Show("Customer Deleted");
                }
            }
            txtDCustomerId.Clear();
        }
    }
}
