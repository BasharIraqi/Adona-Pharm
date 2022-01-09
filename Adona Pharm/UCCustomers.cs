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
        }

        private void showCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel.Visible = true;
            ShowAllPanel.Visible = false;
            ShowPanel.Dock = DockStyle.Fill;
            this.Controls.Add(ShowPanel);
        }

        private void showCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowPanel.Visible = false;
            ShowAllPanel.Visible = true;
            ShowAllPanel.Dock = DockStyle.Fill;
            this.Controls.Add((ShowAllPanel));
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
        }
    }
}
