namespace Calendar_Time
{
    partial class mainWindow
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
            if (disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.USHourStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EUHourStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.binStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.daysStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.generalTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(0, 53);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(396, 85);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "12:0:0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.USHourStrip,
            this.EUHourStrip,
            this.binStrip,
            this.timerStrip,
            this.daysStrip});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(408, 23);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // USHourStrip
            // 
            this.USHourStrip.Name = "USHourStrip";
            this.USHourStrip.Size = new System.Drawing.Size(38, 19);
            this.USHourStrip.Text = "12h";
            this.USHourStrip.Click += new System.EventHandler(this.USHourStrip_Click);
            // 
            // EUHourStrip
            // 
            this.EUHourStrip.Name = "EUHourStrip";
            this.EUHourStrip.Size = new System.Drawing.Size(38, 19);
            this.EUHourStrip.Text = "24h";
            this.EUHourStrip.Click += new System.EventHandler(this.EUHourStrip_Click);
            // 
            // binStrip
            // 
            this.binStrip.Name = "binStrip";
            this.binStrip.Size = new System.Drawing.Size(36, 19);
            this.binStrip.Text = "Bin";
            this.binStrip.Click += new System.EventHandler(this.binStrip_Click);
            // 
            // timerStrip
            // 
            this.timerStrip.Name = "timerStrip";
            this.timerStrip.Size = new System.Drawing.Size(67, 19);
            this.timerStrip.Text = "Minutnik";
            this.timerStrip.Click += new System.EventHandler(this.timerStrip_Click);
            // 
            // daysStrip
            // 
            this.daysStrip.Name = "daysStrip";
            this.daysStrip.Size = new System.Drawing.Size(73, 19);
            this.daysStrip.Text = "Liczba Dni";
            this.daysStrip.Click += new System.EventHandler(this.daysStrip_Click);
            // 
            // generalTimer
            // 
            this.generalTimer.Tick += new System.EventHandler(this.generalTimer_tick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 179);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainWindow";
            this.Text = "Zegar";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem USHourStrip;
        private System.Windows.Forms.ToolStripMenuItem EUHourStrip;
        private System.Windows.Forms.ToolStripMenuItem binStrip;
        private System.Windows.Forms.ToolStripMenuItem timerStrip;
        private System.Windows.Forms.ToolStripMenuItem daysStrip;
        private System.Windows.Forms.Timer generalTimer;
    }
}

