﻿namespace Lab1_DMInS
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectFileLabel = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileLable = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.ImagesControl = new System.Windows.Forms.TabControl();
            this.OriginalTabPage = new System.Windows.Forms.TabPage();
            this.OriginalImagePictureBox = new System.Windows.Forms.PictureBox();
            this.CorrectedBrightnessTabPage = new System.Windows.Forms.TabPage();
            this.CorrectedBrightnessPictureBox = new System.Windows.Forms.PictureBox();
            this.BlackAndWhiteTabPage = new System.Windows.Forms.TabPage();
            this.BlackAndWhitePictureBox = new System.Windows.Forms.PictureBox();
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.BinarizationLevelTextBox = new System.Windows.Forms.TextBox();
            this.BinarizationLevelLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FilterCheckBox = new System.Windows.Forms.CheckBox();
            this.ClassesCountLabel = new System.Windows.Forms.Label();
            this.ClassesCountComboBox = new System.Windows.Forms.ComboBox();
            this.ImagesControl.SuspendLayout();
            this.OriginalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).BeginInit();
            this.CorrectedBrightnessTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectedBrightnessPictureBox)).BeginInit();
            this.BlackAndWhiteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackAndWhitePictureBox)).BeginInit();
            this.ResultTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFileLabel
            // 
            this.SelectFileLabel.AutoSize = true;
            this.SelectFileLabel.Location = new System.Drawing.Point(12, 8);
            this.SelectFileLabel.Name = "SelectFileLabel";
            this.SelectFileLabel.Size = new System.Drawing.Size(62, 13);
            this.SelectFileLabel.TabIndex = 0;
            this.SelectFileLabel.Text = "Select file : ";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(81, 3);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileLable
            // 
            this.FileLable.AutoSize = true;
            this.FileLable.Location = new System.Drawing.Point(162, 13);
            this.FileLable.Name = "FileLable";
            this.FileLable.Size = new System.Drawing.Size(0, 13);
            this.FileLable.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(714, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ImagesControl
            // 
            this.ImagesControl.Controls.Add(this.OriginalTabPage);
            this.ImagesControl.Controls.Add(this.CorrectedBrightnessTabPage);
            this.ImagesControl.Controls.Add(this.BlackAndWhiteTabPage);
            this.ImagesControl.Controls.Add(this.ResultTabPage);
            this.ImagesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagesControl.Location = new System.Drawing.Point(0, 0);
            this.ImagesControl.Name = "ImagesControl";
            this.ImagesControl.SelectedIndex = 0;
            this.ImagesControl.Size = new System.Drawing.Size(792, 377);
            this.ImagesControl.TabIndex = 4;
            // 
            // OriginalTabPage
            // 
            this.OriginalTabPage.Controls.Add(this.OriginalImagePictureBox);
            this.OriginalTabPage.Location = new System.Drawing.Point(4, 22);
            this.OriginalTabPage.Name = "OriginalTabPage";
            this.OriginalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OriginalTabPage.Size = new System.Drawing.Size(784, 351);
            this.OriginalTabPage.TabIndex = 0;
            this.OriginalTabPage.Text = "Original";
            this.OriginalTabPage.UseVisualStyleBackColor = true;
            // 
            // OriginalImagePictureBox
            // 
            this.OriginalImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalImagePictureBox.Location = new System.Drawing.Point(3, 3);
            this.OriginalImagePictureBox.Name = "OriginalImagePictureBox";
            this.OriginalImagePictureBox.Size = new System.Drawing.Size(778, 345);
            this.OriginalImagePictureBox.TabIndex = 0;
            this.OriginalImagePictureBox.TabStop = false;
            // 
            // CorrectedBrightnessTabPage
            // 
            this.CorrectedBrightnessTabPage.Controls.Add(this.CorrectedBrightnessPictureBox);
            this.CorrectedBrightnessTabPage.Location = new System.Drawing.Point(4, 22);
            this.CorrectedBrightnessTabPage.Name = "CorrectedBrightnessTabPage";
            this.CorrectedBrightnessTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CorrectedBrightnessTabPage.Size = new System.Drawing.Size(625, 351);
            this.CorrectedBrightnessTabPage.TabIndex = 1;
            this.CorrectedBrightnessTabPage.Text = "Corrected Brightness";
            this.CorrectedBrightnessTabPage.UseVisualStyleBackColor = true;
            // 
            // CorrectedBrightnessPictureBox
            // 
            this.CorrectedBrightnessPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorrectedBrightnessPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CorrectedBrightnessPictureBox.Name = "CorrectedBrightnessPictureBox";
            this.CorrectedBrightnessPictureBox.Size = new System.Drawing.Size(619, 345);
            this.CorrectedBrightnessPictureBox.TabIndex = 0;
            this.CorrectedBrightnessPictureBox.TabStop = false;
            // 
            // BlackAndWhiteTabPage
            // 
            this.BlackAndWhiteTabPage.Controls.Add(this.BlackAndWhitePictureBox);
            this.BlackAndWhiteTabPage.Location = new System.Drawing.Point(4, 22);
            this.BlackAndWhiteTabPage.Name = "BlackAndWhiteTabPage";
            this.BlackAndWhiteTabPage.Size = new System.Drawing.Size(625, 351);
            this.BlackAndWhiteTabPage.TabIndex = 2;
            this.BlackAndWhiteTabPage.Text = "BlackAndWhite";
            this.BlackAndWhiteTabPage.UseVisualStyleBackColor = true;
            // 
            // BlackAndWhitePictureBox
            // 
            this.BlackAndWhitePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlackAndWhitePictureBox.Location = new System.Drawing.Point(0, 0);
            this.BlackAndWhitePictureBox.Name = "BlackAndWhitePictureBox";
            this.BlackAndWhitePictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.BlackAndWhitePictureBox.Size = new System.Drawing.Size(625, 351);
            this.BlackAndWhitePictureBox.TabIndex = 0;
            this.BlackAndWhitePictureBox.TabStop = false;
            // 
            // ResultTabPage
            // 
            this.ResultTabPage.Controls.Add(this.ResultPictureBox);
            this.ResultTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResultTabPage.Name = "ResultTabPage";
            this.ResultTabPage.Size = new System.Drawing.Size(625, 351);
            this.ResultTabPage.TabIndex = 3;
            this.ResultTabPage.Text = "Result";
            this.ResultTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(625, 351);
            this.ResultPictureBox.TabIndex = 0;
            this.ResultPictureBox.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.ClassesCountComboBox);
            this.splitContainer.Panel1.Controls.Add(this.ClassesCountLabel);
            this.splitContainer.Panel1.Controls.Add(this.FilterCheckBox);
            this.splitContainer.Panel1.Controls.Add(this.BinarizationLevelTextBox);
            this.splitContainer.Panel1.Controls.Add(this.BinarizationLevelLabel);
            this.splitContainer.Panel1.Controls.Add(this.FilePathLabel);
            this.splitContainer.Panel1.Controls.Add(this.SelectFileLabel);
            this.splitContainer.Panel1.Controls.Add(this.SelectFileButton);
            this.splitContainer.Panel1.Controls.Add(this.GoButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.ImagesControl);
            this.splitContainer.Size = new System.Drawing.Size(792, 411);
            this.splitContainer.SplitterDistance = 30;
            this.splitContainer.TabIndex = 5;
            // 
            // BinarizationLevelTextBox
            // 
            this.BinarizationLevelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BinarizationLevelTextBox.Location = new System.Drawing.Point(662, 5);
            this.BinarizationLevelTextBox.Name = "BinarizationLevelTextBox";
            this.BinarizationLevelTextBox.Size = new System.Drawing.Size(46, 20);
            this.BinarizationLevelTextBox.TabIndex = 6;
            this.BinarizationLevelTextBox.Text = "128";
            // 
            // BinarizationLevelLabel
            // 
            this.BinarizationLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BinarizationLevelLabel.AutoSize = true;
            this.BinarizationLevelLabel.Location = new System.Drawing.Point(561, 8);
            this.BinarizationLevelLabel.Name = "BinarizationLevelLabel";
            this.BinarizationLevelLabel.Size = new System.Drawing.Size(95, 13);
            this.BinarizationLevelLabel.TabIndex = 5;
            this.BinarizationLevelLabel.Text = "Binarization level : ";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(162, 8);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 13);
            this.FilePathLabel.TabIndex = 4;
            // 
            // FilterCheckBox
            // 
            this.FilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterCheckBox.AutoSize = true;
            this.FilterCheckBox.Checked = true;
            this.FilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterCheckBox.Location = new System.Drawing.Point(488, 7);
            this.FilterCheckBox.Name = "FilterCheckBox";
            this.FilterCheckBox.Size = new System.Drawing.Size(67, 17);
            this.FilterCheckBox.TabIndex = 8;
            this.FilterCheckBox.Text = "Use filter";
            this.FilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClassesCountLabel
            // 
            this.ClassesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesCountLabel.AutoSize = true;
            this.ClassesCountLabel.Location = new System.Drawing.Point(349, 8);
            this.ClassesCountLabel.Name = "ClassesCountLabel";
            this.ClassesCountLabel.Size = new System.Drawing.Size(82, 13);
            this.ClassesCountLabel.TabIndex = 9;
            this.ClassesCountLabel.Text = "Classes count : ";
            // 
            // ClassesCountComboBox
            // 
            this.ClassesCountComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesCountComboBox.FormattingEnabled = true;
            this.ClassesCountComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.ClassesCountComboBox.Location = new System.Drawing.Point(437, 5);
            this.ClassesCountComboBox.Name = "ClassesCountComboBox";
            this.ClassesCountComboBox.Size = new System.Drawing.Size(45, 21);
            this.ClassesCountComboBox.TabIndex = 10;
            this.ClassesCountComboBox.Text = "2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 411);
            this.Controls.Add(this.FileLable);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DMInS";
            this.ImagesControl.ResumeLayout(false);
            this.OriginalTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).EndInit();
            this.CorrectedBrightnessTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CorrectedBrightnessPictureBox)).EndInit();
            this.BlackAndWhiteTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlackAndWhitePictureBox)).EndInit();
            this.ResultTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFileLabel;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label FileLable;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TabControl ImagesControl;
        private System.Windows.Forms.TabPage OriginalTabPage;
        private System.Windows.Forms.TabPage CorrectedBrightnessTabPage;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.PictureBox CorrectedBrightnessPictureBox;
        private System.Windows.Forms.TabPage BlackAndWhiteTabPage;
        private System.Windows.Forms.PictureBox BlackAndWhitePictureBox;
        private System.Windows.Forms.TabPage ResultTabPage;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.PictureBox OriginalImagePictureBox;
        private System.Windows.Forms.TextBox BinarizationLevelTextBox;
        private System.Windows.Forms.Label BinarizationLevelLabel;
        private System.Windows.Forms.CheckBox FilterCheckBox;
        private System.Windows.Forms.ComboBox ClassesCountComboBox;
        private System.Windows.Forms.Label ClassesCountLabel;
    }
}

