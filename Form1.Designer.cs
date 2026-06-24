namespace FastMusic
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSongs = new System.Windows.Forms.Panel();
            this.lblStartDuration = new System.Windows.Forms.Label();
            this.lblEndDuration = new System.Windows.Forms.Label();
            this.pnlCurrent = new System.Windows.Forms.Panel();
            this.lblCurrentAuthor = new System.Windows.Forms.Label();
            this.lblCurrentSongName = new System.Windows.Forms.Label();
            this.picCurrentSong = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCateg = new System.Windows.Forms.Panel();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnAddSong = new FastMusic.RoundedButton();
            this.btnImportPlaylist = new FastMusic.RoundedButton();
            this.btnNewPlaylist = new FastMusic.RoundedButton();
            this.btnSkipNext = new FastMusic.RoundedButton();
            this.btnSkipPrevious = new FastMusic.RoundedButton();
            this.btnPlay = new FastMusic.RoundedButton();
            this.menuBar1 = new FastMusic.control.MenuBar();
            this.pnlCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentSong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSongs
            // 
            this.pnlSongs.Location = new System.Drawing.Point(562, 73);
            this.pnlSongs.Name = "pnlSongs";
            this.pnlSongs.Size = new System.Drawing.Size(874, 984);
            this.pnlSongs.TabIndex = 1;
            // 
            // lblStartDuration
            // 
            this.lblStartDuration.AutoSize = true;
            this.lblStartDuration.Font = new System.Drawing.Font("Reem Kufi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDuration.Location = new System.Drawing.Point(608, 81);
            this.lblStartDuration.Name = "lblStartDuration";
            this.lblStartDuration.Size = new System.Drawing.Size(36, 23);
            this.lblStartDuration.TabIndex = 5;
            this.lblStartDuration.Text = "0:00";
            // 
            // lblEndDuration
            // 
            this.lblEndDuration.AutoSize = true;
            this.lblEndDuration.Font = new System.Drawing.Font("Reem Kufi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDuration.Location = new System.Drawing.Point(1017, 81);
            this.lblEndDuration.Name = "lblEndDuration";
            this.lblEndDuration.Size = new System.Drawing.Size(36, 23);
            this.lblEndDuration.TabIndex = 6;
            this.lblEndDuration.Text = "0:00";
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.Controls.Add(this.lblCurrentAuthor);
            this.pnlCurrent.Controls.Add(this.lblCurrentSongName);
            this.pnlCurrent.Controls.Add(this.picCurrentSong);
            this.pnlCurrent.Controls.Add(this.lblEndDuration);
            this.pnlCurrent.Controls.Add(this.lblStartDuration);
            this.pnlCurrent.Location = new System.Drawing.Point(13, 1167);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(1471, 208);
            this.pnlCurrent.TabIndex = 7;
            // 
            // lblCurrentAuthor
            // 
            this.lblCurrentAuthor.AutoSize = true;
            this.lblCurrentAuthor.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAuthor.Location = new System.Drawing.Point(226, 93);
            this.lblCurrentAuthor.Name = "lblCurrentAuthor";
            this.lblCurrentAuthor.Size = new System.Drawing.Size(112, 27);
            this.lblCurrentAuthor.TabIndex = 10;
            this.lblCurrentAuthor.Text = "Unknow Author";
            // 
            // lblCurrentSongName
            // 
            this.lblCurrentSongName.AutoSize = true;
            this.lblCurrentSongName.Font = new System.Drawing.Font("Reem Kufi Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSongName.Location = new System.Drawing.Point(225, 31);
            this.lblCurrentSongName.Name = "lblCurrentSongName";
            this.lblCurrentSongName.Size = new System.Drawing.Size(121, 32);
            this.lblCurrentSongName.TabIndex = 9;
            this.lblCurrentSongName.Text = "Unknow Song";
            // 
            // picCurrentSong
            // 
            this.picCurrentSong.Image = global::FastMusic.Properties.Resources.questionMark;
            this.picCurrentSong.Location = new System.Drawing.Point(31, 31);
            this.picCurrentSong.Name = "picCurrentSong";
            this.picCurrentSong.Size = new System.Drawing.Size(160, 163);
            this.picCurrentSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCurrentSong.TabIndex = 7;
            this.picCurrentSong.TabStop = false;
            this.picCurrentSong.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Songs";
            // 
            // pnlCateg
            // 
            this.pnlCateg.Location = new System.Drawing.Point(13, 164);
            this.pnlCateg.Name = "pnlCateg";
            this.pnlCateg.Size = new System.Drawing.Size(514, 893);
            this.pnlCateg.TabIndex = 9;
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(1086, 12);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(193, 39);
            this.cmbTheme.TabIndex = 13;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // btnAddSong
            // 
            this.btnAddSong.CornerRadius = 20;
            this.btnAddSong.IsCircle = false;
            this.btnAddSong.Location = new System.Drawing.Point(394, 31);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(133, 55);
            this.btnAddSong.TabIndex = 12;
            this.btnAddSong.Text = "Add Sound";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnImportPlaylist
            // 
            this.btnImportPlaylist.CornerRadius = 20;
            this.btnImportPlaylist.IsCircle = false;
            this.btnImportPlaylist.Location = new System.Drawing.Point(13, 31);
            this.btnImportPlaylist.Name = "btnImportPlaylist";
            this.btnImportPlaylist.Size = new System.Drawing.Size(133, 55);
            this.btnImportPlaylist.TabIndex = 11;
            this.btnImportPlaylist.Text = "Import Playlist";
            this.btnImportPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.CornerRadius = 20;
            this.btnNewPlaylist.IsCircle = false;
            this.btnNewPlaylist.Location = new System.Drawing.Point(13, 93);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(133, 55);
            this.btnNewPlaylist.TabIndex = 10;
            this.btnNewPlaylist.Text = "New Playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnSkipNext
            // 
            this.btnSkipNext.BackgroundImage = global::FastMusic.Properties.Resources.sd;
            this.btnSkipNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkipNext.CornerRadius = 20;
            this.btnSkipNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipNext.IsCircle = false;
            this.btnSkipNext.Location = new System.Drawing.Point(816, 1074);
            this.btnSkipNext.Name = "btnSkipNext";
            this.btnSkipNext.Size = new System.Drawing.Size(76, 65);
            this.btnSkipNext.TabIndex = 4;
            this.btnSkipNext.UseVisualStyleBackColor = true;
            // 
            // btnSkipPrevious
            // 
            this.btnSkipPrevious.BackgroundImage = global::FastMusic.Properties.Resources.sg;
            this.btnSkipPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkipPrevious.CornerRadius = 20;
            this.btnSkipPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipPrevious.IsCircle = false;
            this.btnSkipPrevious.Location = new System.Drawing.Point(586, 1074);
            this.btnSkipPrevious.Name = "btnSkipPrevious";
            this.btnSkipPrevious.Size = new System.Drawing.Size(76, 65);
            this.btnSkipPrevious.TabIndex = 3;
            this.btnSkipPrevious.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::FastMusic.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.CornerRadius = 20;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IsCircle = false;
            this.btnPlay.Location = new System.Drawing.Point(696, 1074);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 65);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // menuBar1
            // 
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1496, 45);
            this.menuBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 1374);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnImportPlaylist);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.pnlCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCurrent);
            this.Controls.Add(this.btnSkipNext);
            this.Controls.Add(this.btnSkipPrevious);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlSongs);
            this.Controls.Add(this.menuBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FastMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCurrent.ResumeLayout(false);
            this.pnlCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private control.MenuBar menuBar1;
        private System.Windows.Forms.Panel pnlSongs;
        private FastMusic.RoundedButton btnPlay;
        private FastMusic.RoundedButton btnSkipPrevious;
        private FastMusic.RoundedButton btnSkipNext;
        private System.Windows.Forms.Label lblStartDuration;
        private System.Windows.Forms.Label lblEndDuration;
        private System.Windows.Forms.Panel pnlCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCateg;
        private FastMusic.RoundedButton btnNewPlaylist;
        private System.Windows.Forms.PictureBox picCurrentSong;
        private System.Windows.Forms.Label lblCurrentAuthor;
        private System.Windows.Forms.Label lblCurrentSongName;
        private FastMusic.RoundedButton btnImportPlaylist;
        private FastMusic.RoundedButton btnAddSong;
        private System.Windows.Forms.ComboBox cmbTheme;
    }
}
