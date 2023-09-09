namespace WeatherApp
{
    partial class Widget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.wpbMainIcon = new System.Windows.Forms.PictureBox();
            this.wlblCity = new System.Windows.Forms.Label();
            this.wpnlTitleBG = new System.Windows.Forms.Panel();
            this.wlblWeekDay = new System.Windows.Forms.Label();
            this.wlblDate = new System.Windows.Forms.Label();
            this.wbpWeatherIconPB = new System.Windows.Forms.PictureBox();
            this.wlblTempDailyBoxLabel = new System.Windows.Forms.Label();
            this.bflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wlblWeatherDescription = new System.Windows.Forms.Label();
            this.wbtnRefresh = new System.Windows.Forms.Button();
            this.wbtnClose = new System.Windows.Forms.Button();
            this.wpbFooterIcon = new System.Windows.Forms.PictureBox();
            this.wlblFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wpbMainIcon)).BeginInit();
            this.wpnlTitleBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbpWeatherIconPB)).BeginInit();
            this.bflowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wpbFooterIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // wpbMainIcon
            // 
            this.wpbMainIcon.BackColor = System.Drawing.Color.Transparent;
            this.wpbMainIcon.Image = global::WeatherApp.Properties.Resources.pin;
            this.wpbMainIcon.Location = new System.Drawing.Point(15, 7);
            this.wpbMainIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wpbMainIcon.Name = "wpbMainIcon";
            this.wpbMainIcon.Size = new System.Drawing.Size(32, 31);
            this.wpbMainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wpbMainIcon.TabIndex = 0;
            this.wpbMainIcon.TabStop = false;
            // 
            // wlblCity
            // 
            this.wlblCity.AutoSize = true;
            this.wlblCity.BackColor = System.Drawing.Color.Transparent;
            this.wlblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlblCity.ForeColor = System.Drawing.Color.White;
            this.wlblCity.Location = new System.Drawing.Point(48, 6);
            this.wlblCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wlblCity.Name = "wlblCity";
            this.wlblCity.Size = new System.Drawing.Size(68, 32);
            this.wlblCity.TabIndex = 25;
            this.wlblCity.Text = "City";
            // 
            // wpnlTitleBG
            // 
            this.wpnlTitleBG.BackColor = System.Drawing.SystemColors.Highlight;
            this.wpnlTitleBG.Controls.Add(this.wpbMainIcon);
            this.wpnlTitleBG.Controls.Add(this.wlblCity);
            this.wpnlTitleBG.Location = new System.Drawing.Point(-3, 0);
            this.wpnlTitleBG.Margin = new System.Windows.Forms.Padding(4);
            this.wpnlTitleBG.Name = "wpnlTitleBG";
            this.wpnlTitleBG.Size = new System.Drawing.Size(397, 46);
            this.wpnlTitleBG.TabIndex = 25;
            this.wpnlTitleBG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wpnlTitleBG_MouseDown);
            this.wpnlTitleBG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.wpnlTitleBG_MouseMove);
            this.wpnlTitleBG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.wpnlTitleBG_MouseUp);
            // 
            // wlblWeekDay
            // 
            this.wlblWeekDay.AutoSize = true;
            this.wlblWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.wlblWeekDay.Location = new System.Drawing.Point(72, 54);
            this.wlblWeekDay.Name = "wlblWeekDay";
            this.wlblWeekDay.Size = new System.Drawing.Size(118, 29);
            this.wlblWeekDay.TabIndex = 0;
            this.wlblWeekDay.Text = "SUNDAY";
            // 
            // wlblDate
            // 
            this.wlblDate.AutoSize = true;
            this.wlblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlblDate.Location = new System.Drawing.Point(78, 84);
            this.wlblDate.Name = "wlblDate";
            this.wlblDate.Size = new System.Drawing.Size(103, 20);
            this.wlblDate.TabIndex = 26;
            this.wlblDate.Text = "0000-00-00";
            // 
            // wbpWeatherIconPB
            // 
            this.wbpWeatherIconPB.Location = new System.Drawing.Point(86, 107);
            this.wbpWeatherIconPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wbpWeatherIconPB.Name = "wbpWeatherIconPB";
            this.wbpWeatherIconPB.Size = new System.Drawing.Size(85, 58);
            this.wbpWeatherIconPB.TabIndex = 27;
            this.wbpWeatherIconPB.TabStop = false;
            // 
            // wlblTempDailyBoxLabel
            // 
            this.wlblTempDailyBoxLabel.AutoSize = true;
            this.wlblTempDailyBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlblTempDailyBoxLabel.Location = new System.Drawing.Point(113, 169);
            this.wlblTempDailyBoxLabel.Name = "wlblTempDailyBoxLabel";
            this.wlblTempDailyBoxLabel.Size = new System.Drawing.Size(35, 25);
            this.wlblTempDailyBoxLabel.TabIndex = 9;
            this.wlblTempDailyBoxLabel.Text = "0c";
            // 
            // bflowLayoutPanel
            // 
            this.bflowLayoutPanel.Controls.Add(this.wlblWeatherDescription);
            this.bflowLayoutPanel.Location = new System.Drawing.Point(61, 192);
            this.bflowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bflowLayoutPanel.Name = "bflowLayoutPanel";
            this.bflowLayoutPanel.Size = new System.Drawing.Size(135, 47);
            this.bflowLayoutPanel.TabIndex = 30;
            // 
            // wlblWeatherDescription
            // 
            this.wlblWeatherDescription.AutoSize = true;
            this.wlblWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlblWeatherDescription.Location = new System.Drawing.Point(3, 0);
            this.wlblWeatherDescription.Name = "wlblWeatherDescription";
            this.wlblWeatherDescription.Size = new System.Drawing.Size(119, 48);
            this.wlblWeatherDescription.TabIndex = 7;
            this.wlblWeatherDescription.Text = "A mix of sun and clouds";
            // 
            // wbtnRefresh
            // 
            this.wbtnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.wbtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbtnRefresh.ForeColor = System.Drawing.Color.White;
            this.wbtnRefresh.Location = new System.Drawing.Point(61, 246);
            this.wbtnRefresh.Name = "wbtnRefresh";
            this.wbtnRefresh.Size = new System.Drawing.Size(52, 44);
            this.wbtnRefresh.TabIndex = 31;
            this.wbtnRefresh.Text = "🔄";
            this.wbtnRefresh.UseVisualStyleBackColor = false;
            this.wbtnRefresh.Click += new System.EventHandler(this.wbtnRefresh_Click);
            // 
            // wbtnClose
            // 
            this.wbtnClose.BackColor = System.Drawing.Color.DarkRed;
            this.wbtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbtnClose.ForeColor = System.Drawing.Color.White;
            this.wbtnClose.Location = new System.Drawing.Point(138, 246);
            this.wbtnClose.Name = "wbtnClose";
            this.wbtnClose.Size = new System.Drawing.Size(52, 44);
            this.wbtnClose.TabIndex = 29;
            this.wbtnClose.Text = "X";
            this.wbtnClose.UseVisualStyleBackColor = false;
            this.wbtnClose.Click += new System.EventHandler(this.wbtnClose_Click);
            // 
            // wpbFooterIcon
            // 
            this.wpbFooterIcon.Image = global::WeatherApp.Properties.Resources._182;
            this.wpbFooterIcon.InitialImage = global::WeatherApp.Properties.Resources._182;
            this.wpbFooterIcon.Location = new System.Drawing.Point(44, 292);
            this.wpbFooterIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wpbFooterIcon.Name = "wpbFooterIcon";
            this.wpbFooterIcon.Size = new System.Drawing.Size(33, 33);
            this.wpbFooterIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wpbFooterIcon.TabIndex = 32;
            this.wpbFooterIcon.TabStop = false;
            // 
            // wlblFooter
            // 
            this.wlblFooter.AutoSize = true;
            this.wlblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlblFooter.ForeColor = System.Drawing.Color.Navy;
            this.wlblFooter.Location = new System.Drawing.Point(83, 307);
            this.wlblFooter.Name = "wlblFooter";
            this.wlblFooter.Size = new System.Drawing.Size(121, 17);
            this.wlblFooter.TabIndex = 33;
            this.wlblFooter.Text = "Weather Forecast";
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 330);
            this.Controls.Add(this.wlblFooter);
            this.Controls.Add(this.wpbFooterIcon);
            this.Controls.Add(this.wbtnClose);
            this.Controls.Add(this.wbtnRefresh);
            this.Controls.Add(this.bflowLayoutPanel);
            this.Controls.Add(this.wlblTempDailyBoxLabel);
            this.Controls.Add(this.wbpWeatherIconPB);
            this.Controls.Add(this.wlblDate);
            this.Controls.Add(this.wlblWeekDay);
            this.Controls.Add(this.wpnlTitleBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Widget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Widget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Widget_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wpbMainIcon)).EndInit();
            this.wpnlTitleBG.ResumeLayout(false);
            this.wpnlTitleBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wbpWeatherIconPB)).EndInit();
            this.bflowLayoutPanel.ResumeLayout(false);
            this.bflowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wpbFooterIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wpbMainIcon;
        private System.Windows.Forms.Label wlblCity;
        private System.Windows.Forms.Panel wpnlTitleBG;
        private System.Windows.Forms.Label wlblWeekDay;
        private System.Windows.Forms.Label wlblDate;
        private System.Windows.Forms.PictureBox wbpWeatherIconPB;
        private System.Windows.Forms.Label wlblTempDailyBoxLabel;
        private System.Windows.Forms.FlowLayoutPanel bflowLayoutPanel;
        private System.Windows.Forms.Label wlblWeatherDescription;
        private System.Windows.Forms.Button wbtnRefresh;
        private System.Windows.Forms.Button wbtnClose;
        private System.Windows.Forms.PictureBox wpbFooterIcon;
        private System.Windows.Forms.Label wlblFooter;
    }
}