namespace WeatherApp
{
    partial class WeatherInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndwcInfo = new System.Windows.Forms.Button();
            this.btndwcCreateWidget = new System.Windows.Forms.Button();
            this.brndwcNewCity = new System.Windows.Forms.Button();
            this.pnldwcMainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbldwcDate = new System.Windows.Forms.Label();
            this.lbldwcMainDesc = new System.Windows.Forms.Label();
            this.lbldwcCurrentTemp = new System.Windows.Forms.Label();
            this.flpWeatherForecast = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnldwcMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.brndwcNewCity);
            this.panel1.Controls.Add(this.btndwcCreateWidget);
            this.panel1.Controls.Add(this.btndwcInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.pin;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // btndwcInfo
            // 
            this.btndwcInfo.BackColor = System.Drawing.Color.SeaGreen;
            this.btndwcInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndwcInfo.ForeColor = System.Drawing.Color.White;
            this.btndwcInfo.Location = new System.Drawing.Point(1008, 0);
            this.btndwcInfo.Name = "btndwcInfo";
            this.btndwcInfo.Size = new System.Drawing.Size(75, 50);
            this.btndwcInfo.TabIndex = 2;
            this.btndwcInfo.Text = "?";
            this.btndwcInfo.UseVisualStyleBackColor = false;
            // 
            // btndwcCreateWidget
            // 
            this.btndwcCreateWidget.BackColor = System.Drawing.Color.Salmon;
            this.btndwcCreateWidget.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndwcCreateWidget.ForeColor = System.Drawing.Color.White;
            this.btndwcCreateWidget.Location = new System.Drawing.Point(756, 0);
            this.btndwcCreateWidget.Name = "btndwcCreateWidget";
            this.btndwcCreateWidget.Size = new System.Drawing.Size(250, 50);
            this.btndwcCreateWidget.TabIndex = 3;
            this.btndwcCreateWidget.Text = "Create Widget";
            this.btndwcCreateWidget.UseVisualStyleBackColor = false;
            // 
            // brndwcNewCity
            // 
            this.brndwcNewCity.BackColor = System.Drawing.Color.SaddleBrown;
            this.brndwcNewCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brndwcNewCity.ForeColor = System.Drawing.Color.White;
            this.brndwcNewCity.Location = new System.Drawing.Point(529, 0);
            this.brndwcNewCity.Name = "brndwcNewCity";
            this.brndwcNewCity.Size = new System.Drawing.Size(225, 50);
            this.brndwcNewCity.TabIndex = 4;
            this.brndwcNewCity.Text = "New City";
            this.brndwcNewCity.UseVisualStyleBackColor = false;
            // 
            // pnldwcMainPanel
            // 
            this.pnldwcMainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnldwcMainPanel.Controls.Add(this.flpWeatherForecast);
            this.pnldwcMainPanel.Controls.Add(this.lbldwcCurrentTemp);
            this.pnldwcMainPanel.Controls.Add(this.lbldwcMainDesc);
            this.pnldwcMainPanel.Controls.Add(this.lbldwcDate);
            this.pnldwcMainPanel.Controls.Add(this.pictureBox2);
            this.pnldwcMainPanel.Location = new System.Drawing.Point(0, 57);
            this.pnldwcMainPanel.Name = "pnldwcMainPanel";
            this.pnldwcMainPanel.Size = new System.Drawing.Size(1083, 648);
            this.pnldwcMainPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(529, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 175);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbldwcDate
            // 
            this.lbldwcDate.AutoSize = true;
            this.lbldwcDate.BackColor = System.Drawing.Color.Transparent;
            this.lbldwcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcDate.ForeColor = System.Drawing.Color.White;
            this.lbldwcDate.Location = new System.Drawing.Point(573, 31);
            this.lbldwcDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldwcDate.Name = "lbldwcDate";
            this.lbldwcDate.Size = new System.Drawing.Size(92, 39);
            this.lbldwcDate.TabIndex = 1;
            this.lbldwcDate.Text = "temp";
            // 
            // lbldwcMainDesc
            // 
            this.lbldwcMainDesc.AutoSize = true;
            this.lbldwcMainDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbldwcMainDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcMainDesc.ForeColor = System.Drawing.Color.White;
            this.lbldwcMainDesc.Location = new System.Drawing.Point(753, 176);
            this.lbldwcMainDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldwcMainDesc.Name = "lbldwcMainDesc";
            this.lbldwcMainDesc.Size = new System.Drawing.Size(182, 39);
            this.lbldwcMainDesc.TabIndex = 2;
            this.lbldwcMainDesc.Text = "description";
            // 
            // lbldwcCurrentTemp
            // 
            this.lbldwcCurrentTemp.AutoSize = true;
            this.lbldwcCurrentTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbldwcCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldwcCurrentTemp.ForeColor = System.Drawing.Color.White;
            this.lbldwcCurrentTemp.Location = new System.Drawing.Point(753, 127);
            this.lbldwcCurrentTemp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldwcCurrentTemp.Name = "lbldwcCurrentTemp";
            this.lbldwcCurrentTemp.Size = new System.Drawing.Size(92, 39);
            this.lbldwcCurrentTemp.TabIndex = 3;
            this.lbldwcCurrentTemp.Text = "temp";
            // 
            // flpWeatherForecast
            // 
            this.flpWeatherForecast.BackColor = System.Drawing.Color.Transparent;
            this.flpWeatherForecast.Location = new System.Drawing.Point(2, 305);
            this.flpWeatherForecast.Name = "flpWeatherForecast";
            this.flpWeatherForecast.Size = new System.Drawing.Size(1080, 300);
            this.flpWeatherForecast.TabIndex = 4;
            // 
            // WeatherInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.pnldwcMainPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherInfoForm";
            this.Text = "Weather Infoformation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnldwcMainPanel.ResumeLayout(false);
            this.pnldwcMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brndwcNewCity;
        private System.Windows.Forms.Button btndwcCreateWidget;
        private System.Windows.Forms.Button btndwcInfo;
        private System.Windows.Forms.Panel pnldwcMainPanel;
        private System.Windows.Forms.FlowLayoutPanel flpWeatherForecast;
        private System.Windows.Forms.Label lbldwcCurrentTemp;
        private System.Windows.Forms.Label lbldwcMainDesc;
        private System.Windows.Forms.Label lbldwcDate;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}