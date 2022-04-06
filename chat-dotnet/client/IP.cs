using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace client
{
    public partial class IP : Form
    {
        private int mov, movx, movy;

        private bool isValidIpv4Address(string address)
        {
            var check = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");
            return !string.IsNullOrEmpty(address) && check.IsMatch(address, 0);
        }
        public IP()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1) SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void closeBut_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtIP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isValidIpv4Address(txtIP.Text))
            {
                e.Cancel = true;
                txtIP.Focus();
                errorProvider1.SetError(txtIP, "Ip address is not valid.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIP,null);
            }
        }

        private void hideBut_Click_1(object sender, EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }
    }
}