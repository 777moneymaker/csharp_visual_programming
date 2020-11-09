namespace PC_Shop {
    partial class AddCPU_Form {
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
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddCPUButton = new System.Windows.Forms.Button();
            this.DeleteCPUButton = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(47, 105);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(68, 24);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(48, 166);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(103, 24);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Price PLN";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(191, 108);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(162, 22);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(191, 169);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(162, 22);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // AddCPUButton
            // 
            this.AddCPUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCPUButton.Location = new System.Drawing.Point(130, 270);
            this.AddCPUButton.Name = "AddCPUButton";
            this.AddCPUButton.Size = new System.Drawing.Size(160, 40);
            this.AddCPUButton.TabIndex = 4;
            this.AddCPUButton.Text = "Add";
            this.AddCPUButton.UseVisualStyleBackColor = true;
            this.AddCPUButton.Click += new System.EventHandler(this.AddCPUButton_Click);
            // 
            // DeleteCPUButton
            // 
            this.DeleteCPUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCPUButton.Location = new System.Drawing.Point(130, 360);
            this.DeleteCPUButton.Name = "DeleteCPUButton";
            this.DeleteCPUButton.Size = new System.Drawing.Size(160, 40);
            this.DeleteCPUButton.TabIndex = 5;
            this.DeleteCPUButton.Text = "Delete";
            this.DeleteCPUButton.UseVisualStyleBackColor = true;
            this.DeleteCPUButton.Click += new System.EventHandler(this.DeleteCPUButton_Click);
            // 
            // Divider
            // 
            this.Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider.Location = new System.Drawing.Point(12, 438);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(410, 2);
            this.Divider.TabIndex = 6;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(130, 479);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(159, 36);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddCPU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.DeleteCPUButton);
            this.Controls.Add(this.AddCPUButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "AddCPU_Form";
            this.Text = "Add CPU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddCPUButton;
        private System.Windows.Forms.Button DeleteCPUButton;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.Button CloseButton;
    }
}