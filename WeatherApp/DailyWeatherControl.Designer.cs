
namespace WeatherApp
{
    partial class DailyWeatherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dwcMainPanel = new System.Windows.Forms.Panel();
            this.lbldwcWeekDay = new System.Windows.Forms.Label();
            this.lbldwcTemp = new System.Windows.Forms.Label();
            this.dwcInfoPanel = new System.Windows.Forms.Panel();
            this.lbldwcWeatherDesc = new System.Windows.Forms.Label();
            this.pbdwcWeatherIconPicBox = new System.Windows.Forms.PictureBox();
            this.dwcMainPanel.SuspendLayout();
            this.dwcInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdwcWeatherIconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dwcMainPanel
            // 
            this.dwcMainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dwcMainPanel.Controls.Add(this.lbldwcWeekDay);
            this.dwcMainPanel.Location = new System.Drawing.Point(0, 0);
            this.dwcMainPanel.Name = "dwcMainPanel";
            this.dwcMainPanel.Size = new System.Drawing.Size(300, 57);
            this.dwcMainPanel.TabIndex = 0;
            // 
            // lbldwcWeekDay
            // 
            this.lbldwcWeekDay.AutoSize = true;
            this.lbldwcWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcWeekDay.ForeColor = System.Drawing.Color.White;
            this.lbldwcWeekDay.Location = new System.Drawing.Point(85, 15);
            this.lbldwcWeekDay.Name = "lbldwcWeekDay";
            this.lbldwcWeekDay.Size = new System.Drawing.Size(123, 29);
            this.lbldwcWeekDay.TabIndex = 0;
            this.lbldwcWeekDay.Text = "SUNDAY";
            // 
            // lbldwcTemp
            // 
            this.lbldwcTemp.AutoSize = true;
            this.lbldwcTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcTemp.Location = new System.Drawing.Point(105, 274);
            this.lbldwcTemp.Name = "lbldwcTemp";
            this.lbldwcTemp.Size = new System.Drawing.Size(88, 29);
            this.lbldwcTemp.TabIndex = 1;
            this.lbldwcTemp.Text = "12 º C";
            // 
            // dwcInfoPanel
            // 
            this.dwcInfoPanel.Controls.Add(this.lbldwcWeatherDesc);
            this.dwcInfoPanel.Location = new System.Drawing.Point(34, 87);
            this.dwcInfoPanel.Name = "dwcInfoPanel";
            this.dwcInfoPanel.Size = new System.Drawing.Size(235, 80);
            this.dwcInfoPanel.TabIndex = 3;
            // 
            // lbldwcWeatherDesc
            // 
            this.lbldwcWeatherDesc.AutoSize = true;
            this.lbldwcWeatherDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcWeatherDesc.Location = new System.Drawing.Point(8, 26);
            this.lbldwcWeatherDesc.Name = "lbldwcWeatherDesc";
            this.lbldwcWeatherDesc.Size = new System.Drawing.Size(219, 25);
            this.lbldwcWeatherDesc.TabIndex = 0;
            this.lbldwcWeatherDesc.Text = "A mix of sun and clouds";
            // 
            // pbdwcWeatherIconPicBox
            // 
            this.pbdwcWeatherIconPicBox.Location = new System.Drawing.Point(98, 196);
            this.pbdwcWeatherIconPicBox.Name = "pbdwcWeatherIconPicBox";
            this.pbdwcWeatherIconPicBox.Size = new System.Drawing.Size(100, 60);
            this.pbdwcWeatherIconPicBox.TabIndex = 4;
            this.pbdwcWeatherIconPicBox.TabStop = false;
            // 
            // DailyWeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbdwcWeatherIconPicBox);
            this.Controls.Add(this.dwcInfoPanel);
            this.Controls.Add(this.lbldwcTemp);
            this.Controls.Add(this.dwcMainPanel);
            this.Name = "DailyWeatherControl";
            this.Size = new System.Drawing.Size(300, 334);
            this.dwcMainPanel.ResumeLayout(false);
            this.dwcMainPanel.PerformLayout();
            this.dwcInfoPanel.ResumeLayout(false);
            this.dwcInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdwcWeatherIconPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dwcMainPanel;
        private System.Windows.Forms.Label lbldwcWeekDay;
        private System.Windows.Forms.Label lbldwcTemp;
        private System.Windows.Forms.Panel dwcInfoPanel;
        private System.Windows.Forms.Label lbldwcWeatherDesc;
        private System.Windows.Forms.PictureBox pbdwcWeatherIconPicBox;
    }
}
