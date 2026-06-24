namespace FastMusic.control
{
    partial class Song
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumSong = new System.Windows.Forms.Label();
            this.picSongCover = new System.Windows.Forms.PictureBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblSongAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSongCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumSong
            // 
            this.lblNumSong.AutoSize = true;
            this.lblNumSong.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSong.Location = new System.Drawing.Point(20, 28);
            this.lblNumSong.Name = "lblNumSong";
            this.lblNumSong.Size = new System.Drawing.Size(57, 31);
            this.lblNumSong.TabIndex = 0;
            this.lblNumSong.Text = "label1";
            // 
            // picSongCover
            // 
            this.picSongCover.Location = new System.Drawing.Point(100, 3);
            this.picSongCover.Name = "picSongCover";
            this.picSongCover.Size = new System.Drawing.Size(90, 65);
            this.picSongCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSongCover.TabIndex = 1;
            this.picSongCover.TabStop = false;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(226, 16);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(57, 31);
            this.lblSongName.TabIndex = 2;
            this.lblSongName.Text = "label1";
            // 
            // lblSongAuthor
            // 
            this.lblSongAuthor.AutoSize = true;
            this.lblSongAuthor.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongAuthor.Location = new System.Drawing.Point(226, 52);
            this.lblSongAuthor.Name = "lblSongAuthor";
            this.lblSongAuthor.Size = new System.Drawing.Size(57, 31);
            this.lblSongAuthor.TabIndex = 3;
            this.lblSongAuthor.Text = "label1";
            // 
            // song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSongAuthor);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.picSongCover);
            this.Controls.Add(this.lblNumSong);
            this.Name = "song";
            this.Size = new System.Drawing.Size(481, 89);
            ((System.ComponentModel.ISupportInitialize)(this.picSongCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumSong;
        private System.Windows.Forms.PictureBox picSongCover;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSongAuthor;
    }
}
