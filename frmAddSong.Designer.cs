namespace FastMusic
{
    partial class frmAddSong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabChoose = new System.Windows.Forms.TabControl();
            this.tabYoutube = new System.Windows.Forms.TabPage();
            this.tabFromFile = new System.Windows.Forms.TabPage();
            this.lblFromFileName = new System.Windows.Forms.Label();
            this.lblFromSongAuthor = new System.Windows.Forms.Label();
            this.lblFromSongFile = new System.Windows.Forms.Label();
            this.lblSongLoaded = new System.Windows.Forms.Label();
            this.btnChoseFromFile = new FastMusic.RoundedButton();
            this.txtFromFileAuthor = new System.Windows.Forms.TextBox();
            this.txtFromFileName = new System.Windows.Forms.TextBox();
            this.btnExit = new FastMusic.RoundedButton();
            this.tabChoose.SuspendLayout();
            this.tabFromFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChoose
            // 
            this.tabChoose.Controls.Add(this.tabYoutube);
            this.tabChoose.Controls.Add(this.tabFromFile);
            this.tabChoose.Location = new System.Drawing.Point(25, 21);
            this.tabChoose.Name = "tabChoose";
            this.tabChoose.SelectedIndex = 0;
            this.tabChoose.Size = new System.Drawing.Size(791, 520);
            this.tabChoose.TabIndex = 0;
            // 
            // tabYoutube
            // 
            this.tabYoutube.Location = new System.Drawing.Point(4, 25);
            this.tabYoutube.Name = "tabYoutube";
            this.tabYoutube.Padding = new System.Windows.Forms.Padding(3);
            this.tabYoutube.Size = new System.Drawing.Size(783, 491);
            this.tabYoutube.TabIndex = 0;
            this.tabYoutube.Text = "From Youtube";
            this.tabYoutube.UseVisualStyleBackColor = true;
            // 
            // tabFromFile
            // 
            this.tabFromFile.Controls.Add(this.txtFromFileName);
            this.tabFromFile.Controls.Add(this.txtFromFileAuthor);
            this.tabFromFile.Controls.Add(this.lblSongLoaded);
            this.tabFromFile.Controls.Add(this.btnChoseFromFile);
            this.tabFromFile.Controls.Add(this.lblFromSongFile);
            this.tabFromFile.Controls.Add(this.lblFromSongAuthor);
            this.tabFromFile.Controls.Add(this.lblFromFileName);
            this.tabFromFile.Location = new System.Drawing.Point(4, 25);
            this.tabFromFile.Name = "tabFromFile";
            this.tabFromFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFromFile.Size = new System.Drawing.Size(783, 491);
            this.tabFromFile.TabIndex = 1;
            this.tabFromFile.Text = "From A File";
            this.tabFromFile.UseVisualStyleBackColor = true;
            // 
            // lblFromFileName
            // 
            this.lblFromFileName.AutoSize = true;
            this.lblFromFileName.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromFileName.Location = new System.Drawing.Point(100, 78);
            this.lblFromFileName.Name = "lblFromFileName";
            this.lblFromFileName.Size = new System.Drawing.Size(61, 31);
            this.lblFromFileName.TabIndex = 0;
            this.lblFromFileName.Text = "Name";
            // 
            // lblFromSongAuthor
            // 
            this.lblFromSongAuthor.AutoSize = true;
            this.lblFromSongAuthor.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromSongAuthor.Location = new System.Drawing.Point(100, 141);
            this.lblFromSongAuthor.Name = "lblFromSongAuthor";
            this.lblFromSongAuthor.Size = new System.Drawing.Size(66, 31);
            this.lblFromSongAuthor.TabIndex = 1;
            this.lblFromSongAuthor.Text = "Author";
            // 
            // lblFromSongFile
            // 
            this.lblFromSongFile.AutoSize = true;
            this.lblFromSongFile.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromSongFile.Location = new System.Drawing.Point(100, 195);
            this.lblFromSongFile.Name = "lblFromSongFile";
            this.lblFromSongFile.Size = new System.Drawing.Size(41, 31);
            this.lblFromSongFile.TabIndex = 2;
            this.lblFromSongFile.Text = "File";
            // 
            // lblSongLoaded
            // 
            this.lblSongLoaded.AutoSize = true;
            this.lblSongLoaded.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongLoaded.Location = new System.Drawing.Point(281, 206);
            this.lblSongLoaded.Name = "lblSongLoaded";
            this.lblSongLoaded.Size = new System.Drawing.Size(131, 31);
            this.lblSongLoaded.TabIndex = 3;
            this.lblSongLoaded.Text = "Nothing loaded";
            // 
            // btnChoseFromFile
            // 
            this.btnChoseFromFile.CornerRadius = 20;
            this.btnChoseFromFile.IsCircle = false;
            this.btnChoseFromFile.Location = new System.Drawing.Point(536, 206);
            this.btnChoseFromFile.Name = "btnChoseFromFile";
            this.btnChoseFromFile.Size = new System.Drawing.Size(140, 71);
            this.btnChoseFromFile.TabIndex = 1;
            this.btnChoseFromFile.Text = "Choose";
            this.btnChoseFromFile.UseVisualStyleBackColor = true;
            // 
            // txtFromFileAuthor
            // 
            this.txtFromFileAuthor.Location = new System.Drawing.Point(258, 141);
            this.txtFromFileAuthor.Name = "txtFromFileAuthor";
            this.txtFromFileAuthor.Size = new System.Drawing.Size(257, 22);
            this.txtFromFileAuthor.TabIndex = 4;
            // 
            // txtFromFileName
            // 
            this.txtFromFileName.Location = new System.Drawing.Point(258, 86);
            this.txtFromFileName.Name = "txtFromFileName";
            this.txtFromFileName.Size = new System.Drawing.Size(257, 22);
            this.txtFromFileName.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.CornerRadius = 20;
            this.btnExit.Font = new System.Drawing.Font("Reem Kufi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IsCircle = false;
            this.btnExit.Location = new System.Drawing.Point(646, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 63);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 616);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabChoose);
            this.Name = "frmAddSong";
            this.Text = "Add a new Song";
            this.tabChoose.ResumeLayout(false);
            this.tabFromFile.ResumeLayout(false);
            this.tabFromFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChoose;
        private System.Windows.Forms.TabPage tabYoutube;
        private System.Windows.Forms.TabPage tabFromFile;
        private System.Windows.Forms.Label lblFromFileName;
        private System.Windows.Forms.Label lblFromSongFile;
        private System.Windows.Forms.Label lblFromSongAuthor;
        private RoundedButton btnChoseFromFile;
        private System.Windows.Forms.Label lblSongLoaded;
        private System.Windows.Forms.TextBox txtFromFileName;
        private System.Windows.Forms.TextBox txtFromFileAuthor;
        private RoundedButton btnExit;
    }
}