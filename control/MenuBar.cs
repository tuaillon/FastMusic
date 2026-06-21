using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastMusic.control
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Repositionner les boutons manuellement à droite du contrôle
            int margin = 15;
            int btnY = (this.Height - picCroix.Height) / 2;

            picCroix.Left = this.Width - margin - picCroix.Width;
            picCroix.Top = btnY;

            picMoins.Left = picCroix.Left - margin - picMoins.Width;
            picMoins.Top = btnY;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void picMoins_Click(object sender, EventArgs e)
        {
            Form parent = this.FindForm();
            parent.WindowState = FormWindowState.Minimized;
        }

        private void picCroix_Click(object sender, EventArgs e)
        {
            Form parent = this.FindForm();
            parent.Close();
        }

        private void hoverEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            this.Cursor = Cursors.Hand;
            pic.Size = new Size(pic.Size.Width + 2, pic.Size.Height + 2);
        }

        private void hoverLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            this.Cursor = Cursors.Default;
            pic.Size = new Size(pic.Size.Width - 2, pic.Size.Height - 2);

        }


    }
}
