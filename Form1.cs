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
    public enum SongState
    {
        PLAYING,
        PAUSED,
    }


    public partial class Form1 : Form
    {
        SongState m_state = SongState.PAUSED;
        public Form1()
        {
            InitializeComponent();
            PathManager.CreateDefaultIfNotExists();
            ThemeManager.ApplyTheme(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (pnlCurrent != null)
            {
                pnlCurrent.Dock = DockStyle.Bottom;
            }

            if (btnPlay != null && btnSkipPrevious != null && btnSkipNext != null)
            {
                btnPlay.Size = new Size(65, 65);
                btnPlay.IsCircle = true;

                btnSkipPrevious.Size = new Size(65, 65);
                btnSkipPrevious.IsCircle = true;

                btnSkipNext.Size = new Size(65, 65);
                btnSkipNext.IsCircle = true;
            }

            int designerWidth = this.Width;
            int designerHeight = this.Height;

            int targetWidth = Math.Min(designerWidth, Screen.PrimaryScreen.WorkingArea.Width);
            int targetHeight = Math.Min(designerHeight, Screen.PrimaryScreen.WorkingArea.Height);
            this.Size = new Size(targetWidth, targetHeight);

            // Center form
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );

            // Bind hover events to buttons at runtime
            foreach (RoundedButton rdb in this.Controls.OfType<RoundedButton>())
            {
                rdb.MouseEnter += hoverEnter;
                rdb.MouseLeave += hoverLeave;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int centerX = this.ClientSize.Width / 2;

            if (btnPlay != null && btnSkipPrevious != null && btnSkipNext != null && pnlCurrent != null)
            {
                int buttonsY = this.ClientSize.Height - pnlCurrent.Height - btnPlay.Height - 10;
                btnPlay.Location = new Point(centerX - btnPlay.Width / 2, buttonsY);
                btnSkipPrevious.Location = new Point(btnPlay.Left - btnSkipPrevious.Width - 34, buttonsY);
                btnSkipNext.Location = new Point(btnPlay.Right + 34, buttonsY);

                if (pnlCateg != null)
                {
                    int heightCateg = buttonsY - pnlCateg.Top - 10;
                    if (heightCateg < 100) heightCateg = 100;
                    pnlCateg.Size = new Size(pnlCateg.Width, heightCateg);
                }

                if (pnlSongs != null)
                {
                    int widthSongs = this.ClientSize.Width - pnlSongs.Left - 13;
                    if (widthSongs < 100) widthSongs = 100;

                    int heightSongs = buttonsY - pnlSongs.Top - 10;
                    if (heightSongs < 100) heightSongs = 100;

                    pnlSongs.Size = new Size(widthSongs, heightSongs);
                }
            }

            if (lblStartDuration != null && lblEndDuration != null && pnlCurrent != null)
            {
                lblStartDuration.Location = new Point(centerX - 240, (pnlCurrent.Height - lblStartDuration.Height) / 2);
                lblEndDuration.Location = new Point(centerX + 240 - lblEndDuration.Width, (pnlCurrent.Height - lblEndDuration.Height) / 2);
            }
        }


        private void hoverEnter(object sender, EventArgs e)
        {
            RoundedButton pic = sender as RoundedButton;
            this.Cursor = Cursors.Hand;
            pic.Size = new Size(pic.Size.Width + 2, pic.Size.Height + 2);
        }

        private void hoverLeave(object sender, EventArgs e)
        {
            RoundedButton pic = sender as RoundedButton;
            this.Cursor = Cursors.Default;
            pic.Size = new Size(pic.Size.Width - 2, pic.Size.Height - 2);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (m_state == SongState.PAUSED )
            {
                m_state = SongState.PLAYING;
                btnPlay.BackgroundImage = Properties.Resources.pause;
            }
            else
            {
                m_state = SongState.PAUSED;
                btnPlay.BackgroundImage = Properties.Resources.play;
            }
        }
    }
}
