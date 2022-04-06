using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace client
{
    public partial class login : Form
    {
        private int mov, movx, movy;

        public login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtTen.Text = string.Empty;
        }

        private void cmbLogIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLogIn.SelectedIndex == 0)
            {
                nametag.Text = "LOG IN";
                btnLogin.Text = "Log In";
                txtTen.Enabled = false;
                dtpNgaySinh.Enabled = false;
            }
            else
            {
                txtTen.Enabled = true;
                dtpNgaySinh.Enabled = true;
                nametag.Text = "SIGN UP";
                btnLogin.Text = "Sign Up";
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            cmbLogIn.Items.Add("Log In");
            cmbLogIn.Items.Add("Sign Up");
            cmbLogIn.SelectedIndex = 0;
            dtpNgaySinh.MaxDate = DateTime.Today.Date;
            dtpNgaySinh.Value = DateTime.Today.Date;
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

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username cant be empty.");
            }
            else if(Regex.Match(txtUsername.Text,@"^[a-zA-Z0-9]+$") == Match.Empty)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username only contain numbers, letter.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername,null);
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider2.SetError(txtPassword, "Password cant be empty.");
            }
            else if (Regex.Match(txtPassword.Text, @"^[a-zA-Z0-9]+$") == Match.Empty)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider2.SetError(txtPassword, "Password only contain numbers, letters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtPassword,null);
            }
        }

        private void txtTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTen.Text == string.Empty)
            {
                e.Cancel = true;
                txtTen.Focus();
                errorProvider3.SetError(txtTen, "Name cant be empty.");
            }
            else if (Regex.Match(txtTen.Text, @"^[a-zA-Z0-9]+$") == Match.Empty)
            {
                e.Cancel = true;
                txtTen.Focus();
                errorProvider3.SetError(txtTen, "Name only contain numbers, letters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtTen,null);
            }
        }

        private void hideBut_Click_1(object sender, EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}