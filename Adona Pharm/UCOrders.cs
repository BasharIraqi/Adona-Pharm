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
    public partial class UCOrders : UserControl
    {
        public UCOrders()
        {
            InitializeComponent();
            AddPanel.Visible = false;
            UpdatePanel.Visible = false;
            DeletePanel.Visible = false;
            ShowPanel.Visible = false;
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            UpdatePanel.Visible = false;
            DeletePanel.Visible = false;
            ShowPanel.Visible = false;
            AddPanel.Dock = DockStyle.Fill;
            this.Controls.Add(AddPanel);
        }

        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            UpdatePanel.Visible = true;
            DeletePanel.Visible = false;
            ShowPanel.Visible = false;
            UpdatePanel.Dock = DockStyle.Fill;
            this.Controls.Add(UpdatePanel);
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            UpdatePanel.Visible = false;
            DeletePanel.Visible = true;
            ShowPanel.Visible = false;
            DeletePanel.Dock = DockStyle.Fill;
            this.Controls.Add(DeletePanel);
        }

        private void showOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            UpdatePanel.Visible = false;
            DeletePanel.Visible = false;
            ShowPanel.Visible = true;
            ShowPanel.Dock = DockStyle.Fill;
            this.Controls.Add(ShowPanel);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                Address = txtAddress.Text,
                City = txtCity.Text,
                Price = decimal.Parse(txtPrice.Text),
                ReperationDate = dateTimePicker1.Value,
                ResieveDate = dateTimePicker2.Value,
                NumberOfProducts = int.Parse(txtNumberOfProducts.Text),
                NumberOfOrders = int.Parse(txtNumberOfOrders.Text),
                CustomerId = int.Parse(txtCustomerId.Text),
                EmployeeId = int.Parse(txtEmployeeId.Text)
            };
            using (var db = new AdonaPharmContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("order Added Successfully");
            }
        }

        private void btnUShow_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getOrder = db.Orders.Find(int.Parse(txtUOrderId.Text));
                if (getOrder == null)
                {
                    MessageBox.Show("not exist order!!!!!");
                }
                else
                {
                    txtUAddress.Text = getOrder.Address;
                    txtUCity.Text = getOrder.City;
                    txtUPrice.Text = getOrder.Price.ToString();
                    txtUNumberOfOrders.Text = getOrder.NumberOfOrders.ToString();
                    txtUNumberOfProducts.Text = getOrder.NumberOfProducts.ToString();
                    dateTimePicker3.Value = getOrder.ReperationDate.GetValueOrDefault();
                    dateTimePicker4.Value = getOrder.ResieveDate.GetValueOrDefault();
                    txtUCustomerId.Text = getOrder.CustomerId.ToString();
                    txtUEmployee.Text = getOrder.EmployeeId.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getOrder = db.Orders.Find(int.Parse(txtUOrderId.Text));
                getOrder.City = txtUCity.Text;
                getOrder.Address = txtUAddress.Text;
                getOrder.Price = decimal.Parse(txtUPrice.Text);
                getOrder.NumberOfProducts = int.Parse(txtUNumberOfProducts.Text);
                getOrder.NumberOfOrders = int.Parse(txtUNumberOfOrders.Text);
                getOrder.ReperationDate = dateTimePicker3.Value;
                getOrder.ResieveDate = dateTimePicker4.Value;
                getOrder.CustomerId = int.Parse(txtUCustomerId.Text);
                getOrder.EmployeeId = int.Parse(txtUEmployee.Text);
                db.SaveChanges();
                var orderList = db.Orders.Where(w => w.OrderId == int.Parse(txtUOrderId.Text)).Select(s => new { s.OrderId, s.City, s.Address, s.NumberOfProducts, s.NumberOfOrders, s.ReperationDate, s.ResieveDate, s.CustomerId, s.EmployeeId }).ToList();
                dgvUpdate.DataSource = orderList;
                dgvUpdate.Dock = DockStyle.Bottom;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getOrder = db.Orders.Find(int.Parse(txtDOrderId.Text));
                if (getOrder != null)
                {
                    db.Orders.Remove(getOrder);
                    db.SaveChanges();
                    MessageBox.Show("Order Deleted Successfully");
                }
                else
                    MessageBox.Show("Invalid Order");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var db = new AdonaPharmContext())
            {
                var getOrder = db.Orders.Find(int.Parse(txtSOrderId.Text));
                if (getOrder != null)
                {
                    var order = db.Orders.Where(w => w.OrderId == int.Parse(txtSOrderId.Text)).Select(s => new { s.OrderId, s.Address, s.City, s.NumberOfOrders, s.NumberOfProducts, s.ReperationDate, s.ResieveDate, s.CustomerId, s.EmployeeId }).ToList();
                    dgvShow.DataSource = order;
                    dgvShow.Dock=DockStyle.Bottom;
                }
                else
                    MessageBox.Show("Invalid Order Id");
            }
        }
    }
    
}

