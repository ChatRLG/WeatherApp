namespace WeatherApp
{
    partial class WeatherBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherBoard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appImageBox = new System.Windows.Forms.PictureBox();
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.btnGetForecast = new System.Windows.Forms.Button();
            this.lblProgressUpdate = new System.Windows.Forms.Label();
            this.toolTipBtnGetForecast = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Weather Forecast";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.pin;
            this.pictureBox1.Location = new System.Drawing.Point(18, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // appImageBox
            // 
            this.appImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appImageBox.Image = global::WeatherApp.Properties.Resources._182;
            this.appImageBox.Location = new System.Drawing.Point(12, 12);
            this.appImageBox.Margin = new System.Windows.Forms.Padding(1);
            this.appImageBox.Name = "appImageBox";
            this.appImageBox.Size = new System.Drawing.Size(87, 86);
            this.appImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appImageBox.TabIndex = 0;
            this.appImageBox.TabStop = false;
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.AutoSize = true;
            this.lblSelectCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCity.Location = new System.Drawing.Point(46, 136);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(169, 25);
            this.lblSelectCity.TabIndex = 3;
            this.lblSelectCity.Text = "Enter the Location";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(252, 136);
            this.txtBoxLocation.Multiline = true;
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(182, 25);
            this.txtBoxLocation.TabIndex = 1;
            // 
            // btnGetForecast
            // 
            this.btnGetForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetForecast.Location = new System.Drawing.Point(252, 185);
            this.btnGetForecast.Name = "btnGetForecast";
            this.btnGetForecast.Size = new System.Drawing.Size(182, 30);
            this.btnGetForecast.TabIndex = 4;
            this.btnGetForecast.Text = "Confirm";
            this.btnGetForecast.UseVisualStyleBackColor = true;
            // 
            // lblProgressUpdate
            // 
            this.lblProgressUpdate.AutoSize = true;
            this.lblProgressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProgressUpdate.Location = new System.Drawing.Point(300, 237);
            this.lblProgressUpdate.Name = "lblProgressUpdate";
            this.lblProgressUpdate.Size = new System.Drawing.Size(94, 17);
            this.lblProgressUpdate.TabIndex = 5;
            this.lblProgressUpdate.Text = "Processing....";
            // 
            // WeatherBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblProgressUpdate);
            this.Controls.Add(this.btnGetForecast);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.lblSelectCity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.appImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeatherBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox appImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Button btnGetForecast;
        private System.Windows.Forms.Label lblProgressUpdate;
        private System.Windows.Forms.ToolTip toolTipBtnGetForecast;
    }
}