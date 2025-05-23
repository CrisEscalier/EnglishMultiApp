﻿using System.Drawing;
using System.Web.UI.WebControls;
using EnglishMultiApp.Classes;

namespace EnglishMultiApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SlidePanel = new System.Windows.Forms.Panel();

            this.TrnascriptionButton = new System.Windows.Forms.Button();
            this.PhoneticLabel2 = new System.Windows.Forms.Label();
            this.TranscriptionLabel = new System.Windows.Forms.Label();
            this.ButtonToggle = new System.Windows.Forms.Button();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.TranscriptionPanel = new System.Windows.Forms.Panel();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TranscribeButton = new System.Windows.Forms.Button();
            this.SlidePanel.SuspendLayout();
            this.TranscriptionPanel.SuspendLayout();
            this.PhonemeIcon = new System.Windows.Forms.Button();
            this.PhonemeLabel = new System.Windows.Forms.Label();
            this.AppTagName = new System.Windows.Forms.Label();
            this.ButtonToggle = new System.Windows.Forms.Button();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.PhonemePanel = new System.Windows.Forms.Panel();
            this.PhonemeDetail = new System.Windows.Forms.RichTextBox();
            this.PhonemeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhonemeButtonsPanel = new System.Windows.Forms.Panel();
            this.PureVowelButton = new System.Windows.Forms.Button();
            this.ConsonantButton = new System.Windows.Forms.Button();
            this.DiphthongButton = new System.Windows.Forms.Button();
            this.SlidePanel.SuspendLayout();
            this.PhonemePanel.SuspendLayout();
            this.PhonemeButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidePanel
            // 
            this.SlidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SlidePanel.Controls.Add(this.TrnascriptionButton);
            this.SlidePanel.Controls.Add(this.PhoneticLabel2);
            this.SlidePanel.Controls.Add(this.TranscriptionLabel);
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.SlidePanel.Controls.Add(this.PhonemeIcon);
            this.SlidePanel.Controls.Add(this.PhonemeLabel);
            this.SlidePanel.Controls.Add(this.AppTagName);
            this.SlidePanel.Controls.Add(this.ButtonToggle);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(310, 592);
            this.SlidePanel.TabIndex = 0;
            // 
            // TrnascriptionButton
            // 
            this.TrnascriptionButton.BackColor = System.Drawing.Color.Transparent;
            this.TrnascriptionButton.BackgroundImage = global::EnglishMultiApp.Properties.Resources.phonetics_icon;
            this.TrnascriptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TrnascriptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnascriptionButton.FlatAppearance.BorderSize = 0;
            this.TrnascriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrnascriptionButton.Location = new System.Drawing.Point(0, 162);
            this.TrnascriptionButton.Name = "TrnascriptionButton";
            this.TrnascriptionButton.Size = new System.Drawing.Size(65, 65);
            this.TrnascriptionButton.TabIndex = 3;
            this.TrnascriptionButton.UseVisualStyleBackColor = false;
            this.TrnascriptionButton.Click += new System.EventHandler(this.ShowTrancriptionPanel);
            // 
            // PhoneticLabel2
            // 
            this.PhoneticLabel2.AutoSize = true;
            this.PhoneticLabel2.BackColor = System.Drawing.Color.Transparent;
            this.PhoneticLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhoneticLabel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneticLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneticLabel2.Location = new System.Drawing.Point(71, 195);
            this.PhoneticLabel2.Name = "PhoneticLabel2";
            this.PhoneticLabel2.Size = new System.Drawing.Size(153, 22);
            this.PhoneticLabel2.TabIndex = 2;
            this.PhoneticLabel2.Text = "Transcription";
            this.PhoneticLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneticLabel2.Click += new System.EventHandler(this.ShowTrancriptionPanel);
            // 
            // TranscriptionLabel
            // 
            this.TranscriptionLabel.AutoSize = true;
            this.TranscriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TranscriptionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TranscriptionLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranscriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TranscriptionLabel.Location = new System.Drawing.Point(71, 173);
            this.TranscriptionLabel.Name = "TranscriptionLabel";
            this.TranscriptionLabel.Size = new System.Drawing.Size(98, 22);
            this.TranscriptionLabel.TabIndex = 1;
            this.TranscriptionLabel.Text = "Phonetic";
            this.TranscriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranscriptionLabel.Click += new System.EventHandler(this.ShowTrancriptionPanel);
            // PhonemeIcon
            // 
            this.PhonemeIcon.BackColor = System.Drawing.Color.Transparent;
            this.PhonemeIcon.BackgroundImage = global::EnglishMultiApp.Properties.Resources.phonemes_icon;
            this.PhonemeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhonemeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhonemeIcon.FlatAppearance.BorderSize = 0;
            this.PhonemeIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.PhonemeIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.PhonemeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhonemeIcon.ForeColor = System.Drawing.Color.Transparent;
            this.PhonemeIcon.Location = new System.Drawing.Point(0, 85);
            this.PhonemeIcon.Name = "PhonemeIcon";
            this.PhonemeIcon.Size = new System.Drawing.Size(65, 65);
            this.PhonemeIcon.TabIndex = 3;
            this.PhonemeIcon.UseVisualStyleBackColor = false;
            this.PhonemeIcon.Click += new System.EventHandler(this.PhonemeShowPanel_Click);
            // 
            // PhonemeLabel
            // 
            this.PhonemeLabel.AutoSize = true;
            this.PhonemeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhonemeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhonemeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonemeLabel.ForeColor = System.Drawing.Color.White;
            this.PhonemeLabel.Location = new System.Drawing.Point(79, 105);
            this.PhonemeLabel.Name = "PhonemeLabel";
            this.PhonemeLabel.Size = new System.Drawing.Size(153, 22);
            this.PhonemeLabel.TabIndex = 2;
            this.PhonemeLabel.Text = "Phoneme Chart";
            this.PhonemeLabel.Click += new System.EventHandler(this.PhonemeShowPanel_Click);
            // 
            // AppTagName
            // 
            this.AppTagName.AutoSize = true;
            this.AppTagName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTagName.ForeColor = System.Drawing.Color.White;
            this.AppTagName.Location = new System.Drawing.Point(79, 35);
            this.AppTagName.Name = "AppTagName";
            this.AppTagName.Size = new System.Drawing.Size(208, 22);
            this.AppTagName.TabIndex = 1;
            this.AppTagName.Text = "English Helper App";
            // 
            // ButtonToggle
            // 
            this.ButtonToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonToggle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonToggle.FlatAppearance.BorderSize = 0;
            this.ButtonToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ButtonToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.ButtonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToggle.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.ButtonToggle.Location = new System.Drawing.Point(0, 532);
            this.ButtonToggle.Name = "ButtonToggle";
            this.ButtonToggle.Size = new System.Drawing.Size(310, 60);
            this.ButtonToggle.TabIndex = 0;
            this.ButtonToggle.Text = "<<";
            this.ButtonToggle.UseVisualStyleBackColor = false;
            this.ButtonToggle.Click += new System.EventHandler(this.ButtonToggle_Click);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 300;
            // 
            // TranscriptionPanel
            // 
            this.TranscriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(45)))), ((int)(((byte)(88)))));
            this.TranscriptionPanel.Controls.Add(this.TranscribeButton);
            this.TranscriptionPanel.Controls.Add(this.textBox1);
            this.TranscriptionPanel.Controls.Add(this.InputBox);
            this.TranscriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranscriptionPanel.Location = new System.Drawing.Point(280, 0);
            this.TranscriptionPanel.Name = "TranscriptionPanel";
            this.TranscriptionPanel.Size = new System.Drawing.Size(618, 592);
            this.TranscriptionPanel.TabIndex = 1;
            this.TranscriptionPanel.Visible = false;
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(45)))), ((int)(((byte)(88)))));
            this.InputBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(595, 250);
            this.InputBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(45)))), ((int)(((byte)(88)))));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 330);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 250);
            this.textBox1.TabIndex = 1;
            // 
            // TranscribeButton
            // 
            this.TranscribeButton.BackColor = System.Drawing.Color.Transparent;
            this.TranscribeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TranscribeButton.FlatAppearance.BorderSize = 0;
            this.TranscribeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranscribeButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranscribeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TranscribeButton.Location = new System.Drawing.Point(206, 268);
            this.TranscribeButton.Name = "TranscribeButton";
            this.TranscribeButton.Size = new System.Drawing.Size(202, 56);
            this.TranscribeButton.TabIndex = 2;
            this.TranscribeButton.Text = "Transcribe Text";
            this.TranscribeButton.UseVisualStyleBackColor = false;
=======
            // PhonemePanel
            // 
            this.PhonemePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PhonemePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.PhonemePanel.Controls.Add(this.PhonemeDetail);
            this.PhonemePanel.Controls.Add(this.PhonemeTablePanel);
            this.PhonemePanel.Controls.Add(this.PhonemeButtonsPanel);
            this.PhonemePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhonemePanel.Location = new System.Drawing.Point(310, 0);
            this.PhonemePanel.Name = "PhonemePanel";
            this.PhonemePanel.Size = new System.Drawing.Size(627, 592);
            this.PhonemePanel.TabIndex = 1;
            this.PhonemePanel.Visible = false;
            // 
            // PhonemeDetail
            // 
            this.PhonemeDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PhonemeDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhonemeDetail.Font = new System.Drawing.Font("Courier New", 11.75F, System.Drawing.FontStyle.Bold);
            this.PhonemeDetail.Location = new System.Drawing.Point(322, 105);
            this.PhonemeDetail.Name = "PhonemeDetail";
            this.PhonemeDetail.Size = new System.Drawing.Size(100, 96);
            this.PhonemeDetail.TabIndex = 4;
            this.PhonemeDetail.Text = "";
            this.PhonemeDetail.Visible = false;
            // 
            // PhonemeTablePanel
            // 
            this.PhonemeTablePanel.AutoSize = true;
            this.PhonemeTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PhonemeTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PhonemeTablePanel.ColumnCount = 4;
            this.PhonemeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PhonemeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PhonemeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PhonemeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PhonemeTablePanel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonemeTablePanel.Location = new System.Drawing.Point(12, 105);
            this.PhonemeTablePanel.Name = "PhonemeTablePanel";
            this.PhonemeTablePanel.RowCount = 2;
            this.PhonemeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhonemeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhonemeTablePanel.Size = new System.Drawing.Size(0, 0);
            this.PhonemeTablePanel.TabIndex = 3;
            this.PhonemeTablePanel.Visible = false;
            // 
            // PhonemeButtonsPanel
            // 
            this.PhonemeButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PhonemeButtonsPanel.Controls.Add(this.PureVowelButton);
            this.PhonemeButtonsPanel.Controls.Add(this.ConsonantButton);
            this.PhonemeButtonsPanel.Controls.Add(this.DiphthongButton);
            this.PhonemeButtonsPanel.Location = new System.Drawing.Point(12, 12);
            this.PhonemeButtonsPanel.Name = "PhonemeButtonsPanel";
            this.PhonemeButtonsPanel.Size = new System.Drawing.Size(594, 60);
            this.PhonemeButtonsPanel.TabIndex = 0;
            // 
            // PureVowelButton
            // 
            this.PureVowelButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.PureVowelButton.FlatAppearance.BorderSize = 0;
            this.PureVowelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PureVowelButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.PureVowelButton.Location = new System.Drawing.Point(0, 0);
            this.PureVowelButton.Name = "PureVowelButton";
            this.PureVowelButton.Size = new System.Drawing.Size(198, 60);
            this.PureVowelButton.TabIndex = 3;
            this.PureVowelButton.Text = "Pure Vowels";
            this.PureVowelButton.UseVisualStyleBackColor = false;
            this.PureVowelButton.Click += new System.EventHandler(this.PureVowelButton_Click);
            this.PureVowelButton.MouseEnter += new System.EventHandler(this.PureVowelButton_MouseEnter);
            this.PureVowelButton.MouseLeave += new System.EventHandler(this.PureVowelButton_MouseLeave);
            // 
            // ConsonantButton
            // 
            this.ConsonantButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ConsonantButton.FlatAppearance.BorderSize = 0;
            this.ConsonantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsonantButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.ConsonantButton.Location = new System.Drawing.Point(396, 0);
            this.ConsonantButton.Name = "ConsonantButton";
            this.ConsonantButton.Size = new System.Drawing.Size(198, 60);
            this.ConsonantButton.TabIndex = 2;
            this.ConsonantButton.Text = "Consonants";
            this.ConsonantButton.UseVisualStyleBackColor = false;
            this.ConsonantButton.MouseEnter += new System.EventHandler(this.ConsonantButton_MouseEnter);
            this.ConsonantButton.MouseLeave += new System.EventHandler(this.ConsonantButton_MouseLeave);
            // 
            // DiphthongButton
            // 
            this.DiphthongButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DiphthongButton.FlatAppearance.BorderSize = 0;
            this.DiphthongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiphthongButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.DiphthongButton.Location = new System.Drawing.Point(198, 0);
            this.DiphthongButton.Name = "DiphthongButton";
            this.DiphthongButton.Size = new System.Drawing.Size(198, 60);
            this.DiphthongButton.TabIndex = 1;
            this.DiphthongButton.Text = "Diphthongs";
            this.DiphthongButton.UseVisualStyleBackColor = false;
            this.DiphthongButton.MouseEnter += new System.EventHandler(this.DiphthongButton_MouseEnter);
            this.DiphthongButton.MouseLeave += new System.EventHandler(this.DiphthongButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TranscriptionPanel);
            this.ClientSize = new System.Drawing.Size(937, 592);
            this.Controls.Add(this.PhonemePanel);
            this.Controls.Add(this.SlidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Helper App";
            this.SlidePanel.ResumeLayout(false);
            this.SlidePanel.PerformLayout();
            this.TranscriptionPanel.ResumeLayout(false);
            this.TranscriptionPanel.PerformLayout();
            this.PhonemePanel.ResumeLayout(false);
            this.PhonemePanel.PerformLayout();
            this.PhonemeButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PhonemeChart phonemeChart;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Button ButtonToggle;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Button TrnascriptionButton;
        private System.Windows.Forms.Label PhoneticLabel2;
        private System.Windows.Forms.Label TranscriptionLabel;
        private System.Windows.Forms.Panel TranscriptionPanel;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TranscribeButton;
        private System.Windows.Forms.Panel PhonemePanel;
        private System.Windows.Forms.Panel PhonemeButtonsPanel;
        private System.Windows.Forms.Button ConsonantButton;
        private System.Windows.Forms.Button DiphthongButton;
        private System.Windows.Forms.Button PureVowelButton;
        private System.Windows.Forms.TableLayoutPanel PhonemeTablePanel;
        private System.Windows.Forms.Label AppTagName;
        private System.Windows.Forms.Label PhonemeLabel;
        private System.Windows.Forms.Button PhonemeIcon;
        private System.Windows.Forms.RichTextBox PhonemeDetail;
    }
}

