namespace DB_Overlay {
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.JobLabel = new System.Windows.Forms.Label();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.BirthDaysComboBox = new System.Windows.Forms.ComboBox();
            this.BirthMonthsComboBox = new System.Windows.Forms.ComboBox();
            this.BirthYearsComboBox = new System.Windows.Forms.ComboBox();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(166, 92);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(296, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.WordWrap = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 145);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(124, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(166, 149);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(296, 20);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.WordWrap = false;
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.Location = new System.Drawing.Point(12, 204);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(50, 25);
            this.JobLabel.TabIndex = 4;
            this.JobLabel.Text = "Job";
            // 
            // JobComboBox
            // 
            this.JobComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Items.AddRange(new object[] {
            "Student",
            "Doctor",
            "Professor",
            "Other"});
            this.JobComboBox.Location = new System.Drawing.Point(166, 205);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(296, 24);
            this.JobComboBox.TabIndex = 5;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(12, 263);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(52, 25);
            this.SexLabel.TabIndex = 6;
            this.SexLabel.Text = "Sex";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLabel.Location = new System.Drawing.Point(12, 327);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(117, 25);
            this.BirthLabel.TabIndex = 9;
            this.BirthLabel.Text = "Birth Date";
            // 
            // BirthDaysComboBox
            // 
            this.BirthDaysComboBox.FormattingEnabled = true;
            this.BirthDaysComboBox.Location = new System.Drawing.Point(166, 327);
            this.BirthDaysComboBox.Name = "BirthDaysComboBox";
            this.BirthDaysComboBox.Size = new System.Drawing.Size(50, 21);
            this.BirthDaysComboBox.TabIndex = 10;
            // 
            // BirthMonthsComboBox
            // 
            this.BirthMonthsComboBox.FormattingEnabled = true;
            this.BirthMonthsComboBox.Location = new System.Drawing.Point(252, 327);
            this.BirthMonthsComboBox.Name = "BirthMonthsComboBox";
            this.BirthMonthsComboBox.Size = new System.Drawing.Size(50, 21);
            this.BirthMonthsComboBox.TabIndex = 11;
            // 
            // BirthYearsComboBox
            // 
            this.BirthYearsComboBox.FormattingEnabled = true;
            this.BirthYearsComboBox.Location = new System.Drawing.Point(342, 327);
            this.BirthYearsComboBox.Name = "BirthYearsComboBox";
            this.BirthYearsComboBox.Size = new System.Drawing.Size(120, 21);
            this.BirthYearsComboBox.TabIndex = 12;
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(85, 470);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 166);
            this.PrevButton.TabIndex = 13;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(352, 470);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 166);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(166, 470);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 50);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(166, 526);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 50);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(166, 582);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(180, 50);
            this.NewButton.TabIndex = 17;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SexComboBox
            // 
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexComboBox.Location = new System.Drawing.Point(166, 267);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(296, 21);
            this.SexComboBox.TabIndex = 18;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(165, 26);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(181, 29);
            this.StatusLabel.TabIndex = 19;
            this.StatusLabel.Text = "Status: Editing";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(170, 687);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(176, 50);
            this.saveFileButton.TabIndex = 20;
            this.saveFileButton.Text = "Save to File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 761);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.BirthYearsComboBox);
            this.Controls.Add(this.BirthMonthsComboBox);
            this.Controls.Add(this.BirthDaysComboBox);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "MainWindow";
            this.Text = "Database Overlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.ComboBox BirthDaysComboBox;
        private System.Windows.Forms.ComboBox BirthMonthsComboBox;
        private System.Windows.Forms.ComboBox BirthYearsComboBox;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button saveFileButton;
    }
}

