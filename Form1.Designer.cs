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
            this.btnSkipNext = new RoundedButton();
            this.btnSkipPrevious = new RoundedButton();
            this.btnPlay = new RoundedButton();
            this.menuBar1 = new FastMusic.control.MenuBar();
            this.pnlCurrent.SuspendLayout();
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
            this.lblStartDuration.Location = new System.Drawing.Point(728, 26);
            this.lblStartDuration.Name = "lblStartDuration";
            this.lblStartDuration.Size = new System.Drawing.Size(36, 23);
            this.lblStartDuration.TabIndex = 5;
            this.lblStartDuration.Text = "0:00";
            // 
            // lblEndDuration
            // 
            this.lblEndDuration.AutoSize = true;
            this.lblEndDuration.Font = new System.Drawing.Font("Reem Kufi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDuration.Location = new System.Drawing.Point(1272, 26);
            this.lblEndDuration.Name = "lblEndDuration";
            this.lblEndDuration.Size = new System.Drawing.Size(36, 23);
            this.lblEndDuration.TabIndex = 6;
            this.lblEndDuration.Text = "0:00";
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.Controls.Add(this.lblEndDuration);
            this.pnlCurrent.Controls.Add(this.lblStartDuration);
            this.pnlCurrent.Location = new System.Drawing.Point(0, 1145);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(1953, 226);
            this.pnlCurrent.TabIndex = 7;
            // 
            // btnSkipNext
            // 
            this.btnSkipNext.BackgroundImage = global::FastMusic.Properties.Resources.sd;
            this.btnSkipNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkipNext.CornerRadius = 20;
            this.btnSkipNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipNext.Location = new System.Drawing.Point(1063, 1063);
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
            this.btnSkipPrevious.Location = new System.Drawing.Point(833, 1063);
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
            this.btnPlay.Location = new System.Drawing.Point(943, 1063);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 65);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // menuBar1
            // 
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1953, 56);
            this.menuBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1953, 1374);
            this.Controls.Add(this.pnlCurrent);
            this.Controls.Add(this.btnSkipNext);
            this.Controls.Add(this.btnSkipPrevious);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlSongs);
            this.Controls.Add(this.menuBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FastMusic";
            this.pnlCurrent.ResumeLayout(false);
            this.pnlCurrent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private control.MenuBar menuBar1;
        private System.Windows.Forms.Panel pnlSongs;
        private RoundedButton btnPlay;
        private RoundedButton btnSkipPrevious;
        private RoundedButton btnSkipNext;
        private System.Windows.Forms.Label lblStartDuration;
        private System.Windows.Forms.Label lblEndDuration;
        private System.Windows.Forms.Panel pnlCurrent;
    }
}
