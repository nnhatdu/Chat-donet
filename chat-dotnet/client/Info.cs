using System;
using System.Windows.Forms;

namespace client
{
    public partial class Info : Form
    {
        private int mov, movx, movy;

        public Info()
        {
            InitializeComponent();
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

       
        private void closeBut_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBut_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            WindowState = FormWindowState.Minimized;
        }
    }
}