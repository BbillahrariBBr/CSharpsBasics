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
    public partial class frmSignUp : Form
    {
        public static string fName;
        public static string lName;
        public static string email;

        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transection;

        Confirmation confirmation = new Confirmation();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fName = tbxFirstName.Text;
            lName = tbxLastName.Text;
            email = tbxEmail.Text;
            this.Hide();
            confirmation.Show();


        }

        private void chbxSms_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxSms.Checked)
            {
                sms = true;
                lblSmsMsg.Text = "Service charge may be apply for Sms.";
            }
            else
            {
                sms=false;
                lblSmsMsg.Text = "........";
            }
        }

        private void chbxReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxReports.Checked)
            {
                reports = true;
             
            }
            else
            {
                reports = false;
               
            }

        }

        private void chbxTransection_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTransection.Checked)
            {
               transection=true;
                lblTransMsg.Text = "Service charge may be apply for transection.";
            }
            else
            {
                transection = false;
                lblTransMsg.Text = "........";
            }
        }
    }
}
