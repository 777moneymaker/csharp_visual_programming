namespace PC_Shop {
    partial class AddMonitor_Form {
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Label();
            this.DeleteMonitorButton = new System.Windows.Forms.Button();
            this.AddMonitorButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(130, 449);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(159, 36);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider.Location = new System.Drawing.Point(12, 408);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(410, 2);
            this.Divider.TabIndex = 14;
            // 
            // DeleteMonitorButton
            // 
            this.DeleteMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMonitorButton.Location = new System.Drawing.Point(130, 330);
            this.DeleteMonitorButton.Name = "DeleteMonitorButton";
            this.DeleteMonitorButton.Size = new System.Drawing.Size(160, 40);
            this.DeleteMonitorButton.TabIndex = 13;
            this.DeleteMonitorButton.Text = "Delete";
            this.DeleteMonitorButton.UseVisualStyleBackColor = true;
            this.DeleteMonitorButton.Click += new System.EventHandler(this.DeleteMonitorButton_Click);
            // 
            // AddMonitorButton
            // 
            this.AddMonitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMonitorButton.Location = new System.Drawing.Point(130, 240);
            this.AddMonitorButton.Name = "AddMonitorButton";
            this.AddMonitorButton.Size = new System.Drawing.Size(160, 40);
            this.AddMonitorButton.TabIndex = 12;
            this.AddMonitorButton.Text = "Add";
            this.AddMonitorButton.UseVisualStyleBackColor = true;
            this.AddMonitorButton.Click += new System.EventHandler(this.AddMonitorButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(191, 139);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(162, 22);
            this.PriceTextBox.TabIndex = 11;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(191, 78);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(162, 22);
            this.ModelTextBox.TabIndex = 10;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(48, 136);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(103, 24);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price PLN";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(47, 75);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(68, 24);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // AddMonitor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.DeleteMonitorButton);
            this.Controls.Add(this.AddMonitorButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "AddMonitor_Form";
            this.Text = "Add Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.Button DeleteMonitorButton;
        private System.Windows.Forms.Button AddMonitorButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
    }
}