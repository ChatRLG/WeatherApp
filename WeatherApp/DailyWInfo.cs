using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class DailyWInfo : UserControl
    {
        public DailyWInfo()
        {
            InitializeComponent();
        }

        private void DailyWInfo_Load(object sender, EventArgs e)
        {

        }

        public string SunSetTime
        {
            get { return lblDISunSet.Text; }
            set 
            {
                lblDISunSet.Text = value.ToString();
            }
        }

        public string MoonSetTime
        {
            get { return lblDIMoonSet.Text; }
            set
            {
                lblDIMoonSet.Text = value.ToString();
            }
        }

        public string SunRise
        {
            get { return lblDISunRise.Text; }
            set
            {
                lblDISunRise.Text = value.ToString();
            }
        }

        public string MoonRiseTime
        {
            get { return lblDIMoonRise.Text; }
            set 
            {
                lblDIMoonRise.Text = value.ToString();
            }
        }

        public string HumidityValue
        {
            get { return lblDIHumidity.Text; }
            set 
            {
                lblDIHumidity.Text = value.ToString();
            }
        }

        public string UVValue
        {
            get { return lblDIUV.Text;  }
            set 
            {
                lblDIUV.Text = value.ToString();
            }
        }

        public string Wind
        {
            get { return lblDIWind.Text;  }
            set 
            {
                lblDIWind.Text = value.ToString();
            }
        }

        public string Precipitation
        {
            get { return lblDIPrecipitation.Text; }
            set
            {
                lblDIPrecipitation.Text = value.ToString();
            }
        }
    }
}
