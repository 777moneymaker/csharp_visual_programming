namespace PC_Shop {
    partial class MainWindow {
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
            this.TabNew = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.NewPCButton = new System.Windows.Forms.Button();
            this.NewMonitorButton = new System.Windows.Forms.Button();
            this.TabUpdate = new System.Windows.Forms.TabPage();
            this.UpdateMonitorButton = new System.Windows.Forms.Button();
            this.UpdateCPUButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TabNew.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.TabUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabNew
            // 
            this.TabNew.Controls.Add(this.MainTabPage);
            this.TabNew.Controls.Add(this.TabUpdate);
            this.TabNew.Location = new System.Drawing.Point(12, 12);
            this.TabNew.Name = "TabNew";
            this.TabNew.SelectedIndex = 0;
            this.TabNew.Size = new System.Drawing.Size(760, 437);
            this.TabNew.TabIndex = 0;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.ResetButton);
            this.MainTabPage.Controls.Add(this.PriceLabel);
            this.MainTabPage.Controls.Add(this.PriceTextBox);
            this.MainTabPage.Controls.Add(this.NewPCButton);
            this.MainTabPage.Controls.Add(this.NewMonitorButton);
            this.MainTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(752, 411);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "New";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(576, 135);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(117, 25);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price PLN";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(535, 166);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(196, 29);
            this.PriceTextBox.TabIndex = 3;
            // 
            // NewPCButton
            // 
            this.NewPCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPCButton.Location = new System.Drawing.Point(15, 136);
            this.NewPCButton.Name = "NewPCButton";
            this.NewPCButton.Size = new System.Drawing.Size(240, 80);
            this.NewPCButton.TabIndex = 2;
            this.NewPCButton.Text = "Computer";
            this.NewPCButton.UseVisualStyleBackColor = true;
            this.NewPCButton.Click += new System.EventHandler(this.NewPCButton_Click);
            // 
            // NewMonitorButton
            // 
            this.NewMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMonitorButton.Location = new System.Drawing.Point(271, 135);
            this.NewMonitorButton.Name = "NewMonitorButton";
            this.NewMonitorButton.Size = new System.Drawing.Size(240, 80);
            this.NewMonitorButton.TabIndex = 1;
            this.NewMonitorButton.Text = "Monitor";
            this.NewMonitorButton.UseVisualStyleBackColor = true;
            this.NewMonitorButton.Click += new System.EventHandler(this.NewMonitorButton_Click);
            // 
            // TabUpdate
            // 
            this.TabUpdate.Controls.Add(this.UpdateMonitorButton);
            this.TabUpdate.Controls.Add(this.UpdateCPUButton);
            this.TabUpdate.Location = new System.Drawing.Point(4, 22);
            this.TabUpdate.Name = "TabUpdate";
            this.TabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.TabUpdate.Size = new System.Drawing.Size(752, 411);
            this.TabUpdate.TabIndex = 1;
            this.TabUpdate.Text = "Update";
            this.TabUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateMonitorButton
            // 
            this.UpdateMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMonitorButton.Location = new System.Drawing.Point(415, 130);
            this.UpdateMonitorButton.Name = "UpdateMonitorButton";
            this.UpdateMonitorButton.Size = new System.Drawing.Size(230, 80);
            this.UpdateMonitorButton.TabIndex = 1;
            this.UpdateMonitorButton.Text = "Monitor";
            this.UpdateMonitorButton.UseVisualStyleBackColor = true;
            this.UpdateMonitorButton.Click += new System.EventHandler(this.UpdateMonitorButton_Click);
            // 
            // UpdateCPUButton
            // 
            this.UpdateCPUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCPUButton.Location = new System.Drawing.Point(101, 130);
            this.UpdateCPUButton.Name = "UpdateCPUButton";
            this.UpdateCPUButton.Size = new System.Drawing.Size(230, 80);
            this.UpdateCPUButton.TabIndex = 0;
            this.UpdateCPUButton.Text = "CPU";
            this.UpdateCPUButton.UseVisualStyleBackColor = true;
            this.UpdateCPUButton.Click += new System.EventHandler(this.UpdateCPUButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(535, 21);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(196, 32);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TabNew);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainWindow";
            this.Text = "PC Calculator";
            this.TabNew.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.TabUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabNew;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage TabUpdate;
        private System.Windows.Forms.Button NewMonitorButton;
        private System.Windows.Forms.Button NewPCButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button UpdateCPUButton;
        private System.Windows.Forms.Button UpdateMonitorButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

