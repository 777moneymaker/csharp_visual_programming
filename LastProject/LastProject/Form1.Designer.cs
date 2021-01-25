
namespace LastProject {
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
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadCSVButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNumTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.OperationButton = new System.Windows.Forms.Button();
            this.TabsControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsControl
            // 
            this.TabsControl.Controls.Add(this.tabPage3);
            this.TabsControl.Controls.Add(this.tabPage4);
            this.TabsControl.Controls.Add(this.tabPage1);
            this.TabsControl.Location = new System.Drawing.Point(12, 12);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(300, 428);
            this.TabsControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LoadCSVButton);
            this.tabPage3.Controls.Add(this.MainDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 402);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(292, 402);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(-4, 69);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.Size = new System.Drawing.Size(300, 337);
            this.MainDataGridView.TabIndex = 0;
            // 
            // LoadCSVButton
            // 
            this.LoadCSVButton.Location = new System.Drawing.Point(72, 25);
            this.LoadCSVButton.Name = "LoadCSVButton";
            this.LoadCSVButton.Size = new System.Drawing.Size(129, 23);
            this.LoadCSVButton.TabIndex = 1;
            this.LoadCSVButton.Text = "Load CSV";
            this.LoadCSVButton.UseVisualStyleBackColor = true;
            this.LoadCSVButton.Click += new System.EventHandler(this.LoadCSVButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.OperationButton);
            this.tabPage4.Controls.Add(this.ModButton);
            this.tabPage4.Controls.Add(this.DivideButton);
            this.tabPage4.Controls.Add(this.MultiplyButton);
            this.tabPage4.Controls.Add(this.MinusButton);
            this.tabPage4.Controls.Add(this.AddButton);
            this.tabPage4.Controls.Add(this.SecondNumTextBox);
            this.tabPage4.Controls.Add(this.FirstNumTextBox);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(292, 402);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Calculator";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "First number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNumTextBox
            // 
            this.FirstNumTextBox.Location = new System.Drawing.Point(139, 53);
            this.FirstNumTextBox.Name = "FirstNumTextBox";
            this.FirstNumTextBox.Size = new System.Drawing.Size(150, 20);
            this.FirstNumTextBox.TabIndex = 3;
            // 
            // SecondNumTextBox
            // 
            this.SecondNumTextBox.Location = new System.Drawing.Point(139, 117);
            this.SecondNumTextBox.Name = "SecondNumTextBox";
            this.SecondNumTextBox.Size = new System.Drawing.Size(150, 20);
            this.SecondNumTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(17, 194);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(109, 194);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 23);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(203, 194);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(17, 241);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 8;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(109, 241);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(75, 23);
            this.ModButton.TabIndex = 9;
            this.ModButton.Text = "mod 4";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // OperationButton
            // 
            this.OperationButton.Location = new System.Drawing.Point(203, 241);
            this.OperationButton.Name = "OperationButton";
            this.OperationButton.Size = new System.Drawing.Size(75, 23);
            this.OperationButton.TabIndex = 10;
            this.OperationButton.Text = "n/(n+1)^1/2";
            this.OperationButton.UseVisualStyleBackColor = true;
            this.OperationButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 452);
            this.Controls.Add(this.TabsControl);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabsControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LoadCSVButton;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OperationButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SecondNumTextBox;
        private System.Windows.Forms.TextBox FirstNumTextBox;
    }
}

