namespace FastMusic.control
{
    partial class MenuBar
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
            this.picMoins = new System.Windows.Forms.PictureBox();
            this.picCroix = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCroix)).BeginInit();
            this.SuspendLayout();
            // 
            // picMoins
            // 
            this.picMoins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMoins.Image = global::FastMusic.Properties.Resources.moins;
            this.picMoins.Location = new System.Drawing.Point(1466, 14);
            this.picMoins.Name = "picMoins";
            this.picMoins.Size = new System.Drawing.Size(100, 50);
            this.picMoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoins.TabIndex = 1;
            this.picMoins.TabStop = false;
            this.picMoins.Click += new System.EventHandler(this.picMoins_Click);
            this.picMoins.MouseEnter += new System.EventHandler(this.hoverEnter);
            this.picMoins.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // picCroix
            // 
            this.picCroix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCroix.Image = global::FastMusic.Properties.Resources.croix;
            this.picCroix.Location = new System.Drawing.Point(1572, 14);
            this.picCroix.Name = "picCroix";
            this.picCroix.Size = new System.Drawing.Size(100, 50);
            this.picCroix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCroix.TabIndex = 0;
            this.picCroix.TabStop = false;
            this.picCroix.Click += new System.EventHandler(this.picCroix_Click);
            this.picCroix.MouseEnter += new System.EventHandler(this.hoverEnter);
            this.picCroix.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picMoins);
            this.Controls.Add(this.picCroix);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(1687, 67);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCroix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCroix;
        private System.Windows.Forms.PictureBox picMoins;
    }
}
