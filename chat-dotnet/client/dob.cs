using System;
using System.Windows.Forms;

namespace client
{
    public partial class dob : Form
    {
        public dob()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void dob_Load(object sender, EventArgs e)
        {
            dtbDOB.MaxDate = DateTime.Today.Date;
            dtbDOB.Value = DateTime.Today.Date;
        }
        private void closeBut_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void hideBut_Click(object sender, System.EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }

        private int mov, movx, movy;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
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