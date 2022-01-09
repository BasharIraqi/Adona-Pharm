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
    public partial class UCUsers : UserControl
    {
        public UCUsers()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="manager"&&txtPassword.Text=="mmm123456")
            {
                
            }
            else
            {
                if (txtUserName.Text == "department Manager" && txtPassword.Text == "d123456")
                {

                }
                else
                {
                    if (txtUserName.Text == "Shift Manager" && txtPassword.Text == "sm123")
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
