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
            ShowPanel.Visible = false;
            ShowAllPanel.Visible = false;
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
            ShowPanel.Visible = true;
            ShowAllPanel.Visible = false;
            ShowPanel.Dock = DockStyle.Fill;
            this.Controls.Add(ShowPanel);
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
            ShowPanel.Visible = false;
            ShowAllPanel.Visible = true;
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
            using (var db=new AdonaPharmContext())
            {
                var getCustomer = db.Customers.Find(int.Parse(txtCustomerId.Text));
                if (getCustomer == null)
                {
                    MessageBox.Show("Invalid Customer Id");
                }
                else
                {
                    var customerList = db.Customers.Where(w => w.CustomerId == int.Parse(txtCustomerId.Text)).Select(s => new
                    {
                        s.CustomerId,
                        s.FirstName,
                        s.LastName,
                        s.Email,
                        s.City,
                        s.Address,
                        s.PhoneNumber,
                        s.CreditCardNumber,
                        s.OrderId
                    }).ToList();
                    dgvShow.DataSource = customerList;
                    dgvShow.Dock = DockStyle.Bottom;
                }
            }
            txtCustomerId.Clear();  
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (var db=new AdonaPharmContext())
            {
                var getCustomer = db.Customers.Find(int.Parse(txtShowAll.Text));
                if (getCustomer == null)
                {
                    MessageBox.Show("Invalid Customer Id");
                }
                else
                {
                    var customerList = db.Customers.Where(w => w.CustomerId == int.Parse(txtShowAll.Text)).Select(s => new
                    {
                        s.CustomerId,
                        s.FirstName,
                        s.LastName,
                        s.Email,
                        s.City,
                        s.Address,
                        s.PhoneNumber,
                        s.CreditCardNumber,
                        s.Order.OrderId,
                        s.Order.NumberOfProducts,
                        s.Order.Price,
                        s.Order.ResieveDate,
                        s.Order.NumberOfOrders
                    }).ToList();
                    dvgShowAll.DataSource = customerList;
                    dvgShowAll.Dock = DockStyle.Bottom;
                }
            }
            txtShowAll.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            var form1 = new Form1();
            form1.Visible = true;
        }
    }
}
