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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World Again Again ...";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been canceld";
        }
    }
}
