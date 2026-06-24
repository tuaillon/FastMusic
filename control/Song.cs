using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastMusic.control
{
    public partial class Song : UserControl
    {
        public Song()
        {
            InitializeComponent();
            picSongCover.Image = Properties.Resources.questionMark;
        }

        public Song(int num, String name, String artist, String imagePath)
        {
            InitializeComponent();
            lblSongName.Text = name;
            lblSongAuthor.Text = artist;
            picSongCover.Image = Image.FromFile(imagePath);
            lblNumSong.Text = num.ToString();
        }

        public Song(int num, String name, String artist)
        {
            InitializeComponent();
            lblSongName.Text = name;
            lblSongAuthor.Text = artist;
            picSongCover.Image = Properties.Resources.questionMark;
            lblNumSong.Text = num.ToString();
        }
    }
}
