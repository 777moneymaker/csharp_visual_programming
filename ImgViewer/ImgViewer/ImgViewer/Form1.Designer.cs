namespace ImgViewer {
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
            this.ImgPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.OnlyRedsCheckBox = new System.Windows.Forms.CheckBox();
            this.ReflectColorsCheckBox = new System.Windows.Forms.CheckBox();
            this.ReflectCheckBox = new System.Windows.Forms.CheckBox();
            this.Invert90CheckBox = new System.Windows.Forms.CheckBox();
            this.Invert180CheckBox = new System.Windows.Forms.CheckBox();
            this.OnlyBlueCheckBox = new System.Windows.Forms.CheckBox();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPictureBox)).BeginInit();
            this.MainTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgPictureBox
            // 
            this.ImgPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPictureBox.Location = new System.Drawing.Point(46, 49);
            this.ImgPictureBox.Name = "ImgPictureBox";
            this.ImgPictureBox.Size = new System.Drawing.Size(570, 760);
            this.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPictureBox.TabIndex = 0;
            this.ImgPictureBox.TabStop = false;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLabel.Location = new System.Drawing.Point(284, 21);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(75, 25);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "Image";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileButton.Location = new System.Drawing.Point(3, 3);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(294, 74);
            this.LoadFileButton.TabIndex = 7;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // OnlyRedsCheckBox
            // 
            this.OnlyRedsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OnlyRedsCheckBox.AutoSize = true;
            this.OnlyRedsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyRedsCheckBox.Location = new System.Drawing.Point(3, 483);
            this.OnlyRedsCheckBox.Name = "OnlyRedsCheckBox";
            this.OnlyRedsCheckBox.Size = new System.Drawing.Size(126, 74);
            this.OnlyRedsCheckBox.TabIndex = 5;
            this.OnlyRedsCheckBox.Text = "Only Reds";
            this.OnlyRedsCheckBox.UseVisualStyleBackColor = true;
            this.OnlyRedsCheckBox.CheckedChanged += new System.EventHandler(this.OnlyRedsCheckBox_CheckedChanged);
            // 
            // ReflectColorsCheckBox
            // 
            this.ReflectColorsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReflectColorsCheckBox.AutoSize = true;
            this.ReflectColorsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReflectColorsCheckBox.Location = new System.Drawing.Point(3, 403);
            this.ReflectColorsCheckBox.Name = "ReflectColorsCheckBox";
            this.ReflectColorsCheckBox.Size = new System.Drawing.Size(159, 74);
            this.ReflectColorsCheckBox.TabIndex = 4;
            this.ReflectColorsCheckBox.Text = "Reflect Colors";
            this.ReflectColorsCheckBox.UseVisualStyleBackColor = true;
            this.ReflectColorsCheckBox.CheckedChanged += new System.EventHandler(this.ReflectColorsCheckBox_CheckedChanged);
            // 
            // ReflectCheckBox
            // 
            this.ReflectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReflectCheckBox.AutoSize = true;
            this.ReflectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReflectCheckBox.Location = new System.Drawing.Point(3, 323);
            this.ReflectCheckBox.Name = "ReflectCheckBox";
            this.ReflectCheckBox.Size = new System.Drawing.Size(93, 74);
            this.ReflectCheckBox.TabIndex = 3;
            this.ReflectCheckBox.Text = "Reflect";
            this.ReflectCheckBox.UseVisualStyleBackColor = true;
            this.ReflectCheckBox.CheckedChanged += new System.EventHandler(this.ReflectCheckBox_CheckedChanged);
            // 
            // Invert90CheckBox
            // 
            this.Invert90CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Invert90CheckBox.AutoSize = true;
            this.Invert90CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invert90CheckBox.Location = new System.Drawing.Point(3, 243);
            this.Invert90CheckBox.Name = "Invert90CheckBox";
            this.Invert90CheckBox.Size = new System.Drawing.Size(108, 74);
            this.Invert90CheckBox.TabIndex = 2;
            this.Invert90CheckBox.Text = "Invert 90";
            this.Invert90CheckBox.UseVisualStyleBackColor = true;
            this.Invert90CheckBox.CheckedChanged += new System.EventHandler(this.Invert90CheckBox_CheckedChanged);
            // 
            // Invert180CheckBox
            // 
            this.Invert180CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Invert180CheckBox.AutoSize = true;
            this.Invert180CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invert180CheckBox.Location = new System.Drawing.Point(3, 163);
            this.Invert180CheckBox.Name = "Invert180CheckBox";
            this.Invert180CheckBox.Size = new System.Drawing.Size(119, 74);
            this.Invert180CheckBox.TabIndex = 1;
            this.Invert180CheckBox.Text = "Invert 180";
            this.Invert180CheckBox.UseVisualStyleBackColor = true;
            this.Invert180CheckBox.CheckedChanged += new System.EventHandler(this.Invert180CheckBox_CheckedChanged);
            // 
            // OnlyBlueCheckBox
            // 
            this.OnlyBlueCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OnlyBlueCheckBox.AutoSize = true;
            this.OnlyBlueCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyBlueCheckBox.Location = new System.Drawing.Point(3, 563);
            this.OnlyBlueCheckBox.Name = "OnlyBlueCheckBox";
            this.OnlyBlueCheckBox.Size = new System.Drawing.Size(120, 78);
            this.OnlyBlueCheckBox.TabIndex = 6;
            this.OnlyBlueCheckBox.Text = "Only Blue";
            this.OnlyBlueCheckBox.UseVisualStyleBackColor = true;
            this.OnlyBlueCheckBox.CheckedChanged += new System.EventHandler(this.OnlyBlueCheckBox_CheckedChanged);
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.SaveFileButton, 0, 1);
            this.MainTableLayout.Controls.Add(this.LoadFileButton, 0, 0);
            this.MainTableLayout.Controls.Add(this.OnlyBlueCheckBox, 0, 7);
            this.MainTableLayout.Controls.Add(this.OnlyRedsCheckBox, 0, 6);
            this.MainTableLayout.Controls.Add(this.ReflectColorsCheckBox, 0, 5);
            this.MainTableLayout.Controls.Add(this.ReflectCheckBox, 0, 4);
            this.MainTableLayout.Controls.Add(this.Invert90CheckBox, 0, 3);
            this.MainTableLayout.Controls.Add(this.Invert180CheckBox, 0, 2);
            this.MainTableLayout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainTableLayout.Location = new System.Drawing.Point(663, 165);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 8;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainTableLayout.Size = new System.Drawing.Size(300, 644);
            this.MainTableLayout.TabIndex = 4;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFileButton.Location = new System.Drawing.Point(3, 83);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(294, 74);
            this.SaveFileButton.TabIndex = 8;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RotateButton, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(663, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 99);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateButton.Location = new System.Drawing.Point(3, 3);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(290, 93);
            this.RotateButton.TabIndex = 0;
            this.RotateButton.Text = "Rotate: Right";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainTableLayout);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.ImgPictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 900);
            this.Name = "MainWindow";
            this.Text = "ImgViewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImgPictureBox)).EndInit();
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPictureBox;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.CheckBox OnlyRedsCheckBox;
        private System.Windows.Forms.CheckBox ReflectColorsCheckBox;
        private System.Windows.Forms.CheckBox ReflectCheckBox;
        private System.Windows.Forms.CheckBox Invert90CheckBox;
        private System.Windows.Forms.CheckBox Invert180CheckBox;
        private System.Windows.Forms.CheckBox OnlyBlueCheckBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RotateButton;
    }
}

