using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace client
{
    public partial class name : Form
    {
        private int mov, movx, movy;

        public name()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBut_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void txbNewName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txbNewName.Text == string.Empty)
            {
                e.Cancel = true;
                txbNewName.Focus();
                errorProvider1.SetError(txbNewName, "Name cant be empty.");
            }
            else if (Regex.Match(txbNewName.Text, @"^[a-zA-Z0-9]+$") == Match.Empty)
            {
                e.Cancel = true;
                txbNewName.Focus();
                errorProvider1.SetError(txbNewName, "Name only contain numbers, letters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbNewName,null);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }
    }
}