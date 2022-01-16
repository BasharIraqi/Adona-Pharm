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
    public partial class Form1 : Form
    {
        public static string userName = "", password = "";
        public Form1()
        {
            InitializeComponent();
            if (userName == "" && password == "")
            {
                LoginPanel.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(LoginPanel);
            }
            else
            {
                LoginPanel.Visible = false;
                if (userName == "Director" && password == "ddd123456")
                {
                    lblLoginType.Text = "Login User: Director";
                }
                else
                {
                    if (userName == "Department Manager" && password == "d123456")
                    {
                        lblLoginType.Text = "Login User: Department Manager";
                    }
                    else
                    {
                        if (userName == "Shift Manager" && password == "sm123")
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
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            UCOrders uCOrders = new UCOrders();
            uCOrders.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uCOrders);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            UCEmployees uCEmployees = new UCEmployees();
            uCEmployees.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uCEmployees);
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            UCCustomers uCCustomers = new UCCustomers();
            uCCustomers.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uCCustomers);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = txtPassword.Text;
            if (txtUserName.Text == "Director" && txtPassword.Text == "ddd123456")
            {
                btnCustomers.Visible = true;
                btnEmployees.Visible = true;
                btnOrders.Visible = true;
                LoginPanel.Visible = false;
                lblLoginType.Text = "Login User: Director";
                this.Controls.Add(lblLoginType);
                this.Controls.Add(btnOrders);
                this.Controls.Add(btnEmployees);
                this.Controls.Add(btnCustomers);
                this.Controls.Add(label1);
            }
            else
            {
                userName = txtUserName.Text;
                password = txtPassword.Text;
                if (txtUserName.Text == "Department Manager" && txtPassword.Text == "d123456")
                {
                    lblLoginType.Text = "Department Manager";

                    btnCustomers.Visible = true;
                    btnEmployees.Enabled = false;
                    btnOrders.Visible = true;
                    LoginPanel.Visible = false;

                    lblLoginType.Text = "Login User: Department Manager";
                    this.Controls.Add(lblLoginType);
                    this.Controls.Add(btnOrders);
                    this.Controls.Add(btnEmployees);
                    this.Controls.Add(btnCustomers);
                    this.Controls.Add(label1);
                }
                else
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;
                    if (txtUserName.Text == "Shift Manager" && txtPassword.Text == "sm123")
                    {
                        lblLoginType.Text = "Shift Manager";
                        btnCustomers.Visible = true;
                        btnEmployees.Enabled = false;
                        btnOrders.Visible = true;
                        LoginPanel.Visible = false;

                        lblLoginType.Text = "Login User: Shift Manager";
                        this.Controls.Add(lblLoginType);
                        this.Controls.Add(btnOrders);
                        this.Controls.Add(btnEmployees);
                        this.Controls.Add(btnCustomers);
                        this.Controls.Add(label1);
                    }
                    else
                    {
                        userName = txtUserName.Text;
                        password = txtPassword.Text;

                        if (txtUserName.Text == "General" && txtPassword.Text == "g123")
                        {
                            lblLoginType.Text = "Login User: General";
                            btnCustomers.Enabled = false;
                            btnEmployees.Enabled = false;
                            btnOrders.Visible = true;
                            LoginPanel.Visible = false;
                            lblLoginType.Text = "General";
                            this.Controls.Add(lblLoginType);
                            this.Controls.Add(btnOrders);
                            this.Controls.Add(btnEmployees);
                            this.Controls.Add(btnCustomers);
                            this.Controls.Add(label1);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username Or Password");
                            txtUserName.Clear();
                            txtPassword.Clear();
                        }


                    }

                }

            }
        }
    }
}


