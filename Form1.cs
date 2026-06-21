using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PathManager.CreateDefaultIfNotExists();
            ThemeManager.ApplyTheme(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Configure layout behaviors at runtime only (does not affect visual designer)
            if (pnlCurrent != null)
            {
                pnlCurrent.Dock = DockStyle.Bottom;
                pnlCurrent.Height = 120;
            }

            // Adjust form size to screen working area
            int targetWidth = Math.Min(1920, Screen.PrimaryScreen.WorkingArea.Width);
            int targetHeight = Math.Min(1000, Screen.PrimaryScreen.WorkingArea.Height);
            this.Size = new Size(targetWidth, targetHeight);

            // Center form
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int centerX = this.ClientSize.Width / 2;

            if (btnPlay != null && btnSkipPrevious != null && btnSkipNext != null && pnlCurrent != null)
            {
                int buttonsY = this.ClientSize.Height - pnlCurrent.Height - btnPlay.Height - 20;
                btnPlay.Location = new Point(centerX - btnPlay.Width / 2, buttonsY);
                btnSkipPrevious.Location = new Point(btnPlay.Left - btnSkipPrevious.Width - 34, buttonsY);
                btnSkipNext.Location = new Point(btnPlay.Right + 34, buttonsY);

                if (pnlSongs != null)
                {
                    int leftSongs = (this.ClientSize.Width - 1207) / 2;
                    if (leftSongs < 0) leftSongs = 0;

                    int widthSongs = Math.Min(1207, this.ClientSize.Width);
                    int heightSongs = buttonsY - 73 - 15;
                    if (heightSongs < 100) heightSongs = 100;

                    pnlSongs.Location = new Point(leftSongs, 73);
                    pnlSongs.Size = new Size(widthSongs, heightSongs);
                }
            }

            if (lblStartDuration != null && lblEndDuration != null && pnlCurrent != null)
            {
                lblStartDuration.Location = new Point(centerX - 240, (pnlCurrent.Height - lblStartDuration.Height) / 2);
                lblEndDuration.Location = new Point(centerX + 240 - lblEndDuration.Width, (pnlCurrent.Height - lblEndDuration.Height) / 2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
