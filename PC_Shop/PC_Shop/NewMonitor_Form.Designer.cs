namespace PC_Shop {
    partial class NewMonitor_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MonitorsListBox = new System.Windows.Forms.ListBox();
            this.MonitorPriceLabel = new System.Windows.Forms.Label();
            this.MonitorPriceTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.AcceptMonitorButton = new System.Windows.Forms.Button();
            this.CancelMonitorButton = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonitorsListBox
            // 
            this.MonitorsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorsListBox.FormattingEnabled = true;
            this.MonitorsListBox.ItemHeight = 24;
            this.MonitorsListBox.Location = new System.Drawing.Point(39, 45);
            this.MonitorsListBox.Name = "MonitorsListBox";
            this.MonitorsListBox.Size = new System.Drawing.Size(350, 268);
            this.MonitorsListBox.TabIndex = 0;
            this.MonitorsListBox.SelectedIndexChanged += new System.EventHandler(this.MonitorsListBox_SelectedIndexChanged);
            // 
            // MonitorPriceLabel
            // 
            this.MonitorPriceLabel.AutoSize = true;
            this.MonitorPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorPriceLabel.Location = new System.Drawing.Point(36, 413);
            this.MonitorPriceLabel.Name = "MonitorPriceLabel";
            this.MonitorPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.MonitorPriceLabel.TabIndex = 2;
            this.MonitorPriceLabel.Text = "Price";
            // 
            // MonitorPriceTextBox
            // 
            this.MonitorPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonitorPriceTextBox.Location = new System.Drawing.Point(131, 411);
            this.MonitorPriceTextBox.Name = "MonitorPriceTextBox";
            this.MonitorPriceTextBox.ReadOnly = true;
            this.MonitorPriceTextBox.Size = new System.Drawing.Size(170, 26);
            this.MonitorPriceTextBox.TabIndex = 3;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(340, 411);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 24);
            this.CurrencyLabel.TabIndex = 4;
            this.CurrencyLabel.Text = "PLN";
            // 
            // AcceptMonitorButton
            // 
            this.AcceptMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptMonitorButton.Location = new System.Drawing.Point(60, 484);
            this.AcceptMonitorButton.Name = "AcceptMonitorButton";
            this.AcceptMonitorButton.Size = new System.Drawing.Size(120, 35);
            this.AcceptMonitorButton.TabIndex = 5;
            this.AcceptMonitorButton.Text = "OK";
            this.AcceptMonitorButton.UseVisualStyleBackColor = true;
            this.AcceptMonitorButton.Click += new System.EventHandler(this.AcceptMonitorButton_Click);
            // 
            // CancelMonitorButton
            // 
            this.CancelMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelMonitorButton.Location = new System.Drawing.Point(255, 484);
            this.CancelMonitorButton.Name = "CancelMonitorButton";
            this.CancelMonitorButton.Size = new System.Drawing.Size(120, 35);
            this.CancelMonitorButton.TabIndex = 6;
            this.CancelMonitorButton.Text = "Cancel";
            this.CancelMonitorButton.UseVisualStyleBackColor = true;
            this.CancelMonitorButton.Click += new System.EventHandler(this.CancelMonitorButton_Click);
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider.Location = new System.Drawing.Point(1, 349);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(430, 2);
            this.Divider.TabIndex = 7;
            // 
            // NewMonitor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.CancelMonitorButton);
            this.Controls.Add(this.AcceptMonitorButton);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.MonitorPriceTextBox);
            this.Controls.Add(this.MonitorPriceLabel);
            this.Controls.Add(this.MonitorsListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "NewMonitor_Form";
            this.Text = "Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MonitorsListBox;
        private System.Windows.Forms.Label MonitorPriceLabel;
        private System.Windows.Forms.TextBox MonitorPriceTextBox;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Button AcceptMonitorButton;
        private System.Windows.Forms.Button CancelMonitorButton;
        private System.Windows.Forms.Label Divider;
    }
}