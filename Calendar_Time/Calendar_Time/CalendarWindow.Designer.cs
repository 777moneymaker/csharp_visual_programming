namespace Calendar_Time
{
    partial class CalendarWindow
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
            this.fromCalendar = new System.Windows.Forms.MonthCalendar();
            this.toCalendar = new System.Windows.Forms.MonthCalendar();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculatedDaysBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fromCalendar
            // 
            this.fromCalendar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromCalendar.Location = new System.Drawing.Point(18, 110);
            this.fromCalendar.MaxSelectionCount = 1;
            this.fromCalendar.Name = "fromCalendar";
            this.fromCalendar.TabIndex = 0;
            // 
            // toCalendar
            // 
            this.toCalendar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toCalendar.Location = new System.Drawing.Point(373, 110);
            this.toCalendar.MaxSelectionCount = 1;
            this.toCalendar.Name = "toCalendar";
            this.toCalendar.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(130, 71);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 20);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(493, 71);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 20);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "To";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Khaki;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(181, 313);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(284, 62);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculatedDaysBox
            // 
            this.calculatedDaysBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatedDaysBox.BackColor = System.Drawing.Color.White;
            this.calculatedDaysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedDaysBox.Location = new System.Drawing.Point(271, 397);
            this.calculatedDaysBox.Name = "calculatedDaysBox";
            this.calculatedDaysBox.ReadOnly = true;
            this.calculatedDaysBox.Size = new System.Drawing.Size(105, 29);
            this.calculatedDaysBox.TabIndex = 5;
            this.calculatedDaysBox.Text = "Days: 0";
            this.calculatedDaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalendarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 456);
            this.Controls.Add(this.calculatedDaysBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toCalendar);
            this.Controls.Add(this.fromCalendar);
            this.Name = "CalendarWindow";
            this.Text = "Calendar";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar fromCalendar;
        private System.Windows.Forms.MonthCalendar toCalendar;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox calculatedDaysBox;
    }
}