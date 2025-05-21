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
            this.SuspendLayout();
            // 
            // SlidePanel
            // 
            this.SlidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(110)))), ((int)(((byte)(116)))));
            this.SlidePanel.Controls.Add(this.TrnascriptionButton);
            this.SlidePanel.Controls.Add(this.PhoneticLabel2);
            this.SlidePanel.Controls.Add(this.TranscriptionLabel);
            this.SlidePanel.Controls.Add(this.ButtonToggle);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(280, 592);
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
            // 
            // ButtonToggle
            // 
            this.ButtonToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonToggle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonToggle.Location = new System.Drawing.Point(0, 532);
            this.ButtonToggle.Name = "ButtonToggle";
            this.ButtonToggle.Size = new System.Drawing.Size(280, 60);
            this.ButtonToggle.TabIndex = 0;
            this.ButtonToggle.Text = "Close Panel";
            this.ButtonToggle.UseVisualStyleBackColor = true;
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 592);
            this.Controls.Add(this.TranscriptionPanel);
            this.Controls.Add(this.SlidePanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.SlidePanel.ResumeLayout(false);
            this.SlidePanel.PerformLayout();
            this.TranscriptionPanel.ResumeLayout(false);
            this.TranscriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}

