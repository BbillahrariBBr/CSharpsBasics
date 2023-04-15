using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VpApp2
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFname.Text = frmSignUp.fName;
            lblLname.Text = frmSignUp.lName;
            lblEmail.Text = frmSignUp.email;    

            if(frmSignUp.sms)
            {
                lblSms.Text = "✓";
            }
            if (frmSignUp.reports)
            {
                lblReports.Text = "✓";
            }
            if (frmSignUp.transection)
            {
                lblTransections.Text = "✓";
            }
        }
    }
}
