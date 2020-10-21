namespace Calendar_Time
{
    partial class CountdownWindow
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
            this.subjectBox = new System.Windows.Forms.RichTextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.minutesBox = new System.Windows.Forms.RichTextBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.numberOfWindows_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subjectBox
            // 
            this.subjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectBox.Location = new System.Drawing.Point(167, 47);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(133, 88);
            this.subjectBox.TabIndex = 0;
            this.subjectBox.Text = "";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(191, 20);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(80, 24);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject";
            // 
            // minutesBox
            // 
            this.minutesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesBox.Location = new System.Drawing.Point(167, 181);
            this.minutesBox.Multiline = false;
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(133, 41);
            this.minutesBox.TabIndex = 2;
            this.minutesBox.Text = "";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(191, 154);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(83, 24);
            this.minutesLabel.TabIndex = 3;
            this.minutesLabel.Text = "Minutes";
            // 
            // startTimerButton
            // 
            this.startTimerButton.BackColor = System.Drawing.Color.Orange;
            this.startTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startTimerButton.Location = new System.Drawing.Point(167, 253);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(133, 59);
            this.startTimerButton.TabIndex = 4;
            this.startTimerButton.Text = "Start";
            this.startTimerButton.UseVisualStyleBackColor = false;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // numberOfWindows_textBox
            // 
            this.numberOfWindows_textBox.Location = new System.Drawing.Point(25, 50);
            this.numberOfWindows_textBox.Name = "numberOfWindows_textBox";
            this.numberOfWindows_textBox.Size = new System.Drawing.Size(119, 20);
            this.numberOfWindows_textBox.TabIndex = 5;
            // 
            // CountdownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 339);
            this.Controls.Add(this.numberOfWindows_textBox);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectBox);
            this.Name = "CountdownWindow";
            this.Text = "CountdownWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.RichTextBox minutesBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.RichTextBox subjectBox;
        private System.Windows.Forms.TextBox numberOfWindows_textBox;
    }
}