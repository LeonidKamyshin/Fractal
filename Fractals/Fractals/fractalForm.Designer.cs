
namespace Fractals
{
    partial class FractalsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fractalsComboBox = new System.Windows.Forms.ComboBox();
            this.fractalNameLabel = new System.Windows.Forms.Label();
            this.fractalDepthLabel = new System.Windows.Forms.Label();
            this.fractalDepthBar = new System.Windows.Forms.TrackBar();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.startColorButton = new System.Windows.Forms.Button();
            this.startColorDialog = new System.Windows.Forms.ColorDialog();
            this.endColorLabel = new System.Windows.Forms.Label();
            this.endColorButton = new System.Windows.Forms.Button();
            this.endColorDialog = new System.Windows.Forms.ColorDialog();
            this.fractalTreePanel = new System.Windows.Forms.Panel();
            this.rightSegmentAngleBar = new System.Windows.Forms.TrackBar();
            this.rightSegmentAngleLabel = new System.Windows.Forms.Label();
            this.leftSegmentAngleBar = new System.Windows.Forms.TrackBar();
            this.leftSegmentAngleLabel = new System.Windows.Forms.Label();
            this.proportionsBar = new System.Windows.Forms.TrackBar();
            this.proportionsLabel = new System.Windows.Forms.Label();
            this.cantorSetPanel = new System.Windows.Forms.Panel();
            this.cantorSetDistanceBar = new System.Windows.Forms.TrackBar();
            this.cantorSetDistanceLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pictureFractal = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.scaleTrackBar = new System.Windows.Forms.TrackBar();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fractalDepthBar)).BeginInit();
            this.fractalTreePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSegmentAngleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSegmentAngleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionsBar)).BeginInit();
            this.cantorSetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantorSetDistanceBar)).BeginInit();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFractal)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalsComboBox
            // 
            this.fractalsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fractalsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fractalsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fractalsComboBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fractalsComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fractalsComboBox.FormattingEnabled = true;
            this.fractalsComboBox.Items.AddRange(new object[] {
            "Обдуваемое ветром фрактальное дерево",
            "Кривая Коха",
            "Ковер Серпинского",
            "Треугольник Серпинского",
            "Множество Кантора"});
            this.fractalsComboBox.Location = new System.Drawing.Point(13, 41);
            this.fractalsComboBox.Name = "fractalsComboBox";
            this.fractalsComboBox.Size = new System.Drawing.Size(318, 26);
            this.fractalsComboBox.TabIndex = 0;
            this.fractalsComboBox.TabStop = false;
            this.fractalsComboBox.SelectedIndexChanged += new System.EventHandler(this.FractalsComboBox_SelectedIndexChanged);
            // 
            // fractalNameLabel
            // 
            this.fractalNameLabel.AutoSize = true;
            this.fractalNameLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fractalNameLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fractalNameLabel.Location = new System.Drawing.Point(13, 9);
            this.fractalNameLabel.Name = "fractalNameLabel";
            this.fractalNameLabel.Size = new System.Drawing.Size(117, 20);
            this.fractalNameLabel.TabIndex = 0;
            this.fractalNameLabel.Text = "Тип фрактала";
            // 
            // fractalDepthLabel
            // 
            this.fractalDepthLabel.AutoSize = true;
            this.fractalDepthLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fractalDepthLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fractalDepthLabel.Location = new System.Drawing.Point(11, 11);
            this.fractalDepthLabel.Name = "fractalDepthLabel";
            this.fractalDepthLabel.Size = new System.Drawing.Size(180, 20);
            this.fractalDepthLabel.TabIndex = 5;
            this.fractalDepthLabel.Text = "Глубина рекурсии: 1";
            // 
            // fractalDepthBar
            // 
            this.fractalDepthBar.LargeChange = 1;
            this.fractalDepthBar.Location = new System.Drawing.Point(9, 55);
            this.fractalDepthBar.Maximum = 100;
            this.fractalDepthBar.Minimum = 1;
            this.fractalDepthBar.Name = "fractalDepthBar";
            this.fractalDepthBar.Size = new System.Drawing.Size(307, 56);
            this.fractalDepthBar.TabIndex = 6;
            this.fractalDepthBar.TabStop = false;
            this.fractalDepthBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.fractalDepthBar.Value = 1;
            this.fractalDepthBar.ValueChanged += new System.EventHandler(this.FractalDepthBar_ValueChanged);
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startColorLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startColorLabel.Location = new System.Drawing.Point(11, 113);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(144, 20);
            this.startColorLabel.TabIndex = 10;
            this.startColorLabel.Text = "Начальный цвет:";
            // 
            // startColorButton
            // 
            this.startColorButton.BackColor = System.Drawing.Color.White;
            this.startColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startColorButton.Location = new System.Drawing.Point(161, 107);
            this.startColorButton.Name = "startColorButton";
            this.startColorButton.Size = new System.Drawing.Size(35, 35);
            this.startColorButton.TabIndex = 11;
            this.startColorButton.UseVisualStyleBackColor = false;
            this.startColorButton.Click += new System.EventHandler(this.StartColorButton_Click);
            // 
            // startColorDialog
            // 
            this.startColorDialog.Color = System.Drawing.Color.White;
            // 
            // endColorLabel
            // 
            this.endColorLabel.AutoSize = true;
            this.endColorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.endColorLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endColorLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.endColorLabel.Location = new System.Drawing.Point(11, 180);
            this.endColorLabel.Name = "endColorLabel";
            this.endColorLabel.Size = new System.Drawing.Size(135, 20);
            this.endColorLabel.TabIndex = 12;
            this.endColorLabel.Text = "Конечный цвет:";
            // 
            // endColorButton
            // 
            this.endColorButton.BackColor = System.Drawing.Color.White;
            this.endColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endColorButton.Location = new System.Drawing.Point(161, 173);
            this.endColorButton.Name = "endColorButton";
            this.endColorButton.Size = new System.Drawing.Size(35, 35);
            this.endColorButton.TabIndex = 13;
            this.endColorButton.UseVisualStyleBackColor = false;
            this.endColorButton.Click += new System.EventHandler(this.EndColorButton_Click);
            // 
            // endColorDialog
            // 
            this.endColorDialog.Color = System.Drawing.Color.White;
            // 
            // fractalTreePanel
            // 
            this.fractalTreePanel.Controls.Add(this.rightSegmentAngleBar);
            this.fractalTreePanel.Controls.Add(this.rightSegmentAngleLabel);
            this.fractalTreePanel.Controls.Add(this.leftSegmentAngleBar);
            this.fractalTreePanel.Controls.Add(this.leftSegmentAngleLabel);
            this.fractalTreePanel.Controls.Add(this.proportionsBar);
            this.fractalTreePanel.Controls.Add(this.proportionsLabel);
            this.fractalTreePanel.Location = new System.Drawing.Point(1, 300);
            this.fractalTreePanel.Name = "fractalTreePanel";
            this.fractalTreePanel.Size = new System.Drawing.Size(335, 304);
            this.fractalTreePanel.TabIndex = 14;
            this.fractalTreePanel.Visible = false;
            // 
            // rightSegmentAngleBar
            // 
            this.rightSegmentAngleBar.Location = new System.Drawing.Point(11, 239);
            this.rightSegmentAngleBar.Maximum = 70;
            this.rightSegmentAngleBar.Minimum = 20;
            this.rightSegmentAngleBar.Name = "rightSegmentAngleBar";
            this.rightSegmentAngleBar.Size = new System.Drawing.Size(307, 56);
            this.rightSegmentAngleBar.TabIndex = 5;
            this.rightSegmentAngleBar.TabStop = false;
            this.rightSegmentAngleBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rightSegmentAngleBar.Value = 45;
            this.rightSegmentAngleBar.Scroll += new System.EventHandler(this.RightSegmentAngleBar_Scroll);
            // 
            // rightSegmentAngleLabel
            // 
            this.rightSegmentAngleLabel.AutoSize = true;
            this.rightSegmentAngleLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightSegmentAngleLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rightSegmentAngleLabel.Location = new System.Drawing.Point(11, 199);
            this.rightSegmentAngleLabel.Name = "rightSegmentAngleLabel";
            this.rightSegmentAngleLabel.Size = new System.Drawing.Size(306, 20);
            this.rightSegmentAngleLabel.TabIndex = 4;
            this.rightSegmentAngleLabel.Text = "Угол наклона правого отрезка: 45°";
            // 
            // leftSegmentAngleBar
            // 
            this.leftSegmentAngleBar.Location = new System.Drawing.Point(11, 140);
            this.leftSegmentAngleBar.Maximum = 70;
            this.leftSegmentAngleBar.Minimum = 20;
            this.leftSegmentAngleBar.Name = "leftSegmentAngleBar";
            this.leftSegmentAngleBar.Size = new System.Drawing.Size(307, 56);
            this.leftSegmentAngleBar.TabIndex = 3;
            this.leftSegmentAngleBar.TabStop = false;
            this.leftSegmentAngleBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.leftSegmentAngleBar.Value = 45;
            this.leftSegmentAngleBar.Scroll += new System.EventHandler(this.LeftSegmentAngleBar_Scroll);
            // 
            // leftSegmentAngleLabel
            // 
            this.leftSegmentAngleLabel.AutoSize = true;
            this.leftSegmentAngleLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftSegmentAngleLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.leftSegmentAngleLabel.Location = new System.Drawing.Point(11, 104);
            this.leftSegmentAngleLabel.Name = "leftSegmentAngleLabel";
            this.leftSegmentAngleLabel.Size = new System.Drawing.Size(297, 20);
            this.leftSegmentAngleLabel.TabIndex = 2;
            this.leftSegmentAngleLabel.Text = "Угол наклона левого отрезка: 45°";
            // 
            // proportionsBar
            // 
            this.proportionsBar.Location = new System.Drawing.Point(11, 45);
            this.proportionsBar.Maximum = 200;
            this.proportionsBar.Minimum = 130;
            this.proportionsBar.Name = "proportionsBar";
            this.proportionsBar.Size = new System.Drawing.Size(307, 56);
            this.proportionsBar.TabIndex = 1;
            this.proportionsBar.TabStop = false;
            this.proportionsBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.proportionsBar.Value = 130;
            this.proportionsBar.ValueChanged += new System.EventHandler(this.ProportionsBar_ValueChanged);
            // 
            // proportionsLabel
            // 
            this.proportionsLabel.AutoSize = true;
            this.proportionsLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proportionsLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.proportionsLabel.Location = new System.Drawing.Point(11, 9);
            this.proportionsLabel.Name = "proportionsLabel";
            this.proportionsLabel.Size = new System.Drawing.Size(198, 20);
            this.proportionsLabel.TabIndex = 0;
            this.proportionsLabel.Text = "Отношение длин: 1:1,3";
            // 
            // cantorSetPanel
            // 
            this.cantorSetPanel.Controls.Add(this.cantorSetDistanceBar);
            this.cantorSetPanel.Controls.Add(this.cantorSetDistanceLabel);
            this.cantorSetPanel.Location = new System.Drawing.Point(1, 300);
            this.cantorSetPanel.Name = "cantorSetPanel";
            this.cantorSetPanel.Size = new System.Drawing.Size(335, 304);
            this.cantorSetPanel.TabIndex = 6;
            this.cantorSetPanel.Visible = false;
            // 
            // cantorSetDistanceBar
            // 
            this.cantorSetDistanceBar.Location = new System.Drawing.Point(11, 45);
            this.cantorSetDistanceBar.Maximum = 100;
            this.cantorSetDistanceBar.Minimum = 10;
            this.cantorSetDistanceBar.Name = "cantorSetDistanceBar";
            this.cantorSetDistanceBar.Size = new System.Drawing.Size(307, 56);
            this.cantorSetDistanceBar.TabIndex = 1;
            this.cantorSetDistanceBar.TabStop = false;
            this.cantorSetDistanceBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cantorSetDistanceBar.Value = 10;
            this.cantorSetDistanceBar.ValueChanged += new System.EventHandler(this.CantorSetDistanceBar_ValueChanged);
            // 
            // cantorSetDistanceLabel
            // 
            this.cantorSetDistanceLabel.AutoSize = true;
            this.cantorSetDistanceLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantorSetDistanceLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cantorSetDistanceLabel.Location = new System.Drawing.Point(11, 9);
            this.cantorSetDistanceLabel.Name = "cantorSetDistanceLabel";
            this.cantorSetDistanceLabel.Size = new System.Drawing.Size(279, 20);
            this.cantorSetDistanceLabel.TabIndex = 0;
            this.cantorSetDistanceLabel.Text = "Расстояние между отрезками: 10";
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyButton.Location = new System.Drawing.Point(22, 110);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(107, 29);
            this.applyButton.TabIndex = 15;
            this.applyButton.Text = "применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePanel.AutoScroll = true;
            this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.picturePanel.Controls.Add(this.pictureFractal);
            this.picturePanel.Location = new System.Drawing.Point(336, 0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(611, 769);
            this.picturePanel.TabIndex = 16;
            this.picturePanel.SizeChanged += new System.EventHandler(this.PicturePanel_SizeChanged);
            // 
            // pictureFractal
            // 
            this.pictureFractal.Location = new System.Drawing.Point(0, 0);
            this.pictureFractal.Name = "pictureFractal";
            this.pictureFractal.Size = new System.Drawing.Size(200, 100);
            this.pictureFractal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureFractal.TabIndex = 0;
            this.pictureFractal.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.startColorButton);
            this.mainPanel.Controls.Add(this.endColorButton);
            this.mainPanel.Controls.Add(this.endColorLabel);
            this.mainPanel.Controls.Add(this.fractalDepthLabel);
            this.mainPanel.Controls.Add(this.fractalDepthBar);
            this.mainPanel.Controls.Add(this.startColorLabel);
            this.mainPanel.Location = new System.Drawing.Point(1, 73);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(335, 221);
            this.mainPanel.TabIndex = 17;
            this.mainPanel.Visible = false;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controlsPanel.Controls.Add(this.scaleTrackBar);
            this.controlsPanel.Controls.Add(this.scaleLabel);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Controls.Add(this.applyButton);
            this.controlsPanel.Location = new System.Drawing.Point(1, 604);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(335, 153);
            this.controlsPanel.TabIndex = 18;
            this.controlsPanel.Visible = false;
            // 
            // scaleTrackBar
            // 
            this.scaleTrackBar.LargeChange = 1;
            this.scaleTrackBar.Location = new System.Drawing.Point(9, 48);
            this.scaleTrackBar.Maximum = 5;
            this.scaleTrackBar.Minimum = 1;
            this.scaleTrackBar.Name = "scaleTrackBar";
            this.scaleTrackBar.Size = new System.Drawing.Size(307, 56);
            this.scaleTrackBar.TabIndex = 20;
            this.scaleTrackBar.TabStop = false;
            this.scaleTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleTrackBar.Value = 1;
            this.scaleTrackBar.ValueChanged += new System.EventHandler(this.ScaleTrackBar_ValueChanged);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scaleLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scaleLabel.Location = new System.Drawing.Point(9, 10);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(126, 20);
            this.scaleLabel.TabIndex = 19;
            this.scaleLabel.Text = "Увеличение: 1";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(201, 110);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 29);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All Files(*.*)|*.*\"";
            this.saveFileDialog.Title = "\"Сохранить картинку как...\";";
            // 
            // fractalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(947, 769);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.fractalsComboBox);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.fractalNameLabel);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.cantorSetPanel);
            this.Controls.Add(this.fractalTreePanel);
            this.MinimumSize = new System.Drawing.Size(950, 800);
            this.Name = "fractalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FractalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fractalDepthBar)).EndInit();
            this.fractalTreePanel.ResumeLayout(false);
            this.fractalTreePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSegmentAngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSegmentAngleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionsBar)).EndInit();
            this.cantorSetPanel.ResumeLayout(false);
            this.cantorSetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantorSetDistanceBar)).EndInit();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFractal)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox fractalsComboBox;
        private System.Windows.Forms.Label fractalNameLabel;
        private System.Windows.Forms.Label fractalDepthLabel;
        private System.Windows.Forms.TrackBar fractalDepthBar;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.Button startColorButton;
        private System.Windows.Forms.ColorDialog startColorDialog;
        private System.Windows.Forms.Label endColorLabel;
        private System.Windows.Forms.Button endColorButton;
        private System.Windows.Forms.ColorDialog endColorDialog;
        private System.Windows.Forms.Panel fractalTreePanel;
        private System.Windows.Forms.Label proportionsLabel;
        private System.Windows.Forms.TrackBar proportionsBar;
        private System.Windows.Forms.Label leftSegmentAngleLabel;
        private System.Windows.Forms.TrackBar leftSegmentAngleBar;
        private System.Windows.Forms.Label rightSegmentAngleLabel;
        private System.Windows.Forms.TrackBar rightSegmentAngleBar;
        private System.Windows.Forms.Panel cantorSetPanel;
        private System.Windows.Forms.TrackBar cantorSetDistanceBar;
        private System.Windows.Forms.Label cantorSetDistanceLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pictureFractal;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TrackBar scaleTrackBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

