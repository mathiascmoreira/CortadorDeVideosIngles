namespace CortadorDeVideosIngles
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SeekerTrackBar = new System.Windows.Forms.TrackBar();
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.VolumetrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SeekerTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumetrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(16, 113);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(110, 113);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(191, 113);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // SeekerTrackBar
            // 
            this.SeekerTrackBar.AutoSize = false;
            this.SeekerTrackBar.Location = new System.Drawing.Point(12, 46);
            this.SeekerTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeekerTrackBar.Maximum = 10000;
            this.SeekerTrackBar.Name = "SeekerTrackBar";
            this.SeekerTrackBar.Size = new System.Drawing.Size(588, 26);
            this.SeekerTrackBar.TabIndex = 4;
            this.SeekerTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SeekerTrackBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SeekerTrackBar_KeyDown);
            this.SeekerTrackBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SeekerTrackBar_KeyUp);
            this.SeekerTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SeekerTrackBar_MouseDown);
            this.SeekerTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SeekerTrackBar_MouseUp);
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(452, 115);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(117, 17);
            this.timeLabel.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(612, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuItemOpen});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // stripMenuItemOpen
            // 
            this.stripMenuItemOpen.Name = "stripMenuItemOpen";
            this.stripMenuItemOpen.Size = new System.Drawing.Size(117, 26);
            this.stripMenuItemOpen.Text = "Abrir";
            this.stripMenuItemOpen.Click += new System.EventHandler(this.StripMenuItemOpen_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(271, 113);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // VolumetrackBar
            // 
            this.VolumetrackBar.Location = new System.Drawing.Point(16, 151);
            this.VolumetrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.VolumetrackBar.Name = "VolumetrackBar";
            this.VolumetrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumetrackBar.Size = new System.Drawing.Size(56, 128);
            this.VolumetrackBar.TabIndex = 8;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 354);
            this.Controls.Add(this.VolumetrackBar);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.SeekerTrackBar);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SeekerTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumetrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar SeekerTrackBar;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemOpen;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.TrackBar VolumetrackBar;
    }
}

