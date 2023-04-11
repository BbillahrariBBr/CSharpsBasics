using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = tbxUserId.Text;
            string pass = tbxPassword.Text;


            if (id =="125" &&  pass =="12345")
            {
                frmHomePage form = new frmHomePage();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Password or Userid is incorrect");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxUserId.Text = "";
            tbxPassword.Text = "";
        }
    }
}
