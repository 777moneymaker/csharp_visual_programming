namespace PC_Shop {
    partial class NewPC_Form {
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
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUPriceTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel1 = new System.Windows.Forms.Label();
            this.CPUsComboBox = new System.Windows.Forms.ComboBox();
            this.Divider1 = new System.Windows.Forms.Label();
            this.DiskLabel = new System.Windows.Forms.Label();
            this.DiskPriceTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel2 = new System.Windows.Forms.Label();
            this.DiskRadiosGroupBox = new System.Windows.Forms.GroupBox();
            this.DiskRadio3 = new System.Windows.Forms.RadioButton();
            this.DiskRadio2 = new System.Windows.Forms.RadioButton();
            this.DiskRadio1 = new System.Windows.Forms.RadioButton();
            this.Divider2 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SumPriceTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel3 = new System.Windows.Forms.Label();
            this.AcceptPCButton = new System.Windows.Forms.Button();
            this.CancelPCButton = new System.Windows.Forms.Button();
            this.DiskRadiosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.Location = new System.Drawing.Point(40, 85);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(51, 24);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "CPU";
            // 
            // CPUPriceTextBox
            // 
            this.CPUPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUPriceTextBox.Location = new System.Drawing.Point(143, 83);
            this.CPUPriceTextBox.Name = "CPUPriceTextBox";
            this.CPUPriceTextBox.ReadOnly = true;
            this.CPUPriceTextBox.Size = new System.Drawing.Size(175, 26);
            this.CPUPriceTextBox.TabIndex = 1;
            // 
            // CurrencyLabel1
            // 
            this.CurrencyLabel1.AutoSize = true;
            this.CurrencyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel1.Location = new System.Drawing.Point(343, 83);
            this.CurrencyLabel1.Name = "CurrencyLabel1";
            this.CurrencyLabel1.Size = new System.Drawing.Size(49, 24);
            this.CurrencyLabel1.TabIndex = 2;
            this.CurrencyLabel1.Text = "PLN";
            // 
            // CPUsComboBox
            // 
            this.CPUsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CPUsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUsComboBox.FormattingEnabled = true;
            this.CPUsComboBox.Location = new System.Drawing.Point(43, 139);
            this.CPUsComboBox.Name = "CPUsComboBox";
            this.CPUsComboBox.Size = new System.Drawing.Size(348, 28);
            this.CPUsComboBox.TabIndex = 3;
            this.CPUsComboBox.SelectedIndexChanged += new System.EventHandler(this.CPUsComboBox_SelectedIndexChanged);
            // 
            // Divider1
            // 
            this.Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divider1.Location = new System.Drawing.Point(4, 199);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(430, 2);
            this.Divider1.TabIndex = 4;
            // 
            // DiskLabel
            // 
            this.DiskLabel.AutoSize = true;
            this.DiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskLabel.Location = new System.Drawing.Point(40, 229);
            this.DiskLabel.Name = "DiskLabel";
            this.DiskLabel.Size = new System.Drawing.Size(49, 24);
            this.DiskLabel.TabIndex = 5;
            this.DiskLabel.Text = "Disk";
            // 
            // DiskPriceTextBox
            // 
            this.DiskPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskPriceTextBox.Location = new System.Drawing.Point(143, 231);
            this.DiskPriceTextBox.Name = "DiskPriceTextBox";
            this.DiskPriceTextBox.ReadOnly = true;
            this.DiskPriceTextBox.Size = new System.Drawing.Size(174, 26);
            this.DiskPriceTextBox.TabIndex = 6;
            // 
            // CurrencyLabel2
            // 
            this.CurrencyLabel2.AutoSize = true;
            this.CurrencyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel2.Location = new System.Drawing.Point(343, 233);
            this.CurrencyLabel2.Name = "CurrencyLabel2";
            this.CurrencyLabel2.Size = new System.Drawing.Size(49, 24);
            this.CurrencyLabel2.TabIndex = 7;
            this.CurrencyLabel2.Text = "PLN";
            // 
            // DiskRadiosGroupBox
            // 
            this.DiskRadiosGroupBox.Controls.Add(this.DiskRadio3);
            this.DiskRadiosGroupBox.Controls.Add(this.DiskRadio2);
            this.DiskRadiosGroupBox.Controls.Add(this.DiskRadio1);
            this.DiskRadiosGroupBox.Location = new System.Drawing.Point(47, 280);
            this.DiskRadiosGroupBox.Name = "DiskRadiosGroupBox";
            this.DiskRadiosGroupBox.Size = new System.Drawing.Size(344, 128);
            this.DiskRadiosGroupBox.TabIndex = 8;
            this.DiskRadiosGroupBox.TabStop = false;
            // 
            // DiskRadio3
            // 
            this.DiskRadio3.AutoSize = true;
            this.DiskRadio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskRadio3.Location = new System.Drawing.Point(32, 91);
            this.DiskRadio3.Name = "DiskRadio3";
            this.DiskRadio3.Size = new System.Drawing.Size(149, 24);
            this.DiskRadio3.TabIndex = 2;
            this.DiskRadio3.TabStop = true;
            this.DiskRadio3.Text = "1000 GB SATA";
            this.DiskRadio3.UseVisualStyleBackColor = true;
            this.DiskRadio3.CheckedChanged += new System.EventHandler(this.DiskRadio3_CheckedChanged);
            // 
            // DiskRadio2
            // 
            this.DiskRadio2.AutoSize = true;
            this.DiskRadio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskRadio2.Location = new System.Drawing.Point(32, 54);
            this.DiskRadio2.Name = "DiskRadio2";
            this.DiskRadio2.Size = new System.Drawing.Size(139, 24);
            this.DiskRadio2.TabIndex = 1;
            this.DiskRadio2.TabStop = true;
            this.DiskRadio2.Text = "500 GB SATA";
            this.DiskRadio2.UseVisualStyleBackColor = true;
            this.DiskRadio2.CheckedChanged += new System.EventHandler(this.DiskRadio2_CheckedChanged);
            // 
            // DiskRadio1
            // 
            this.DiskRadio1.AutoSize = true;
            this.DiskRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskRadio1.Location = new System.Drawing.Point(32, 17);
            this.DiskRadio1.Name = "DiskRadio1";
            this.DiskRadio1.Size = new System.Drawing.Size(130, 24);
            this.DiskRadio1.TabIndex = 0;
            this.DiskRadio1.TabStop = true;
            this.DiskRadio1.Text = "240 GB SSD";
            this.DiskRadio1.UseVisualStyleBackColor = true;
            this.DiskRadio1.CheckedChanged += new System.EventHandler(this.DiskRadio1_CheckedChanged);
            // 
            // Divider2
            // 
            this.Divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divider2.Location = new System.Drawing.Point(4, 423);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(430, 2);
            this.Divider2.TabIndex = 9;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.Location = new System.Drawing.Point(39, 466);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(52, 24);
            this.SumLabel.TabIndex = 10;
            this.SumLabel.Text = "Sum";
            // 
            // SumPriceTextBox
            // 
            this.SumPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumPriceTextBox.Location = new System.Drawing.Point(143, 464);
            this.SumPriceTextBox.Name = "SumPriceTextBox";
            this.SumPriceTextBox.ReadOnly = true;
            this.SumPriceTextBox.Size = new System.Drawing.Size(174, 26);
            this.SumPriceTextBox.TabIndex = 11;
            // 
            // CurrencyLabel3
            // 
            this.CurrencyLabel3.AutoSize = true;
            this.CurrencyLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel3.Location = new System.Drawing.Point(343, 464);
            this.CurrencyLabel3.Name = "CurrencyLabel3";
            this.CurrencyLabel3.Size = new System.Drawing.Size(49, 24);
            this.CurrencyLabel3.TabIndex = 12;
            this.CurrencyLabel3.Text = "PLN";
            // 
            // AcceptPCButton
            // 
            this.AcceptPCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptPCButton.Location = new System.Drawing.Point(64, 513);
            this.AcceptPCButton.Name = "AcceptPCButton";
            this.AcceptPCButton.Size = new System.Drawing.Size(120, 35);
            this.AcceptPCButton.TabIndex = 13;
            this.AcceptPCButton.Text = "OK";
            this.AcceptPCButton.UseVisualStyleBackColor = true;
            this.AcceptPCButton.Click += new System.EventHandler(this.AcceptPCButton_Click);
            // 
            // CancelPCButton
            // 
            this.CancelPCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPCButton.Location = new System.Drawing.Point(252, 513);
            this.CancelPCButton.Name = "CancelPCButton";
            this.CancelPCButton.Size = new System.Drawing.Size(120, 35);
            this.CancelPCButton.TabIndex = 14;
            this.CancelPCButton.Text = "Cancel";
            this.CancelPCButton.UseVisualStyleBackColor = true;
            this.CancelPCButton.Click += new System.EventHandler(this.CancelPCButton_Click);
            // 
            // NewPC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.CancelPCButton);
            this.Controls.Add(this.AcceptPCButton);
            this.Controls.Add(this.CurrencyLabel3);
            this.Controls.Add(this.SumPriceTextBox);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.DiskRadiosGroupBox);
            this.Controls.Add(this.CurrencyLabel2);
            this.Controls.Add(this.DiskPriceTextBox);
            this.Controls.Add(this.DiskLabel);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.CPUsComboBox);
            this.Controls.Add(this.CurrencyLabel1);
            this.Controls.Add(this.CPUPriceTextBox);
            this.Controls.Add(this.CPULabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 600);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "NewPC_Form";
            this.Text = "Computer";
            this.DiskRadiosGroupBox.ResumeLayout(false);
            this.DiskRadiosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.TextBox CPUPriceTextBox;
        private System.Windows.Forms.Label CurrencyLabel1;
        private System.Windows.Forms.ComboBox CPUsComboBox;
        private System.Windows.Forms.Label Divider1;
        private System.Windows.Forms.Label DiskLabel;
        private System.Windows.Forms.TextBox DiskPriceTextBox;
        private System.Windows.Forms.Label CurrencyLabel2;
        private System.Windows.Forms.GroupBox DiskRadiosGroupBox;
        private System.Windows.Forms.RadioButton DiskRadio3;
        private System.Windows.Forms.RadioButton DiskRadio2;
        private System.Windows.Forms.RadioButton DiskRadio1;
        private System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox SumPriceTextBox;
        private System.Windows.Forms.Label CurrencyLabel3;
        private System.Windows.Forms.Button AcceptPCButton;
        private System.Windows.Forms.Button CancelPCButton;
    }
}