using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class DailyWeatherControl : UserControl
    {
        public DailyWeatherControl()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return lbldwcWeekDay.Text; }
            set 
            {
                lbldwcWeekDay.Text = value.ToString();
                // parse the API response and set the value of the label
                var dateToken = value.Split('-');
                var year = int.Parse(dateToken[0]);
                var month = int.Parse(dateToken[1]);
                var day = int.Parse(dateToken[2]);

                DateTime dateValue = new DateTime(year, month, day);
                DayOfWeek dayOfWeek = dateValue.DayOfWeek;
                lbldwcWeekDay.Text = dayOfWeek.ToString();
            }
        }

        public string WeatherDescription
        {
            get { return lbldwcWeatherDesc.Text;  }
            set 
            {
                lbldwcWeatherDesc.Text = value.ToString();
            }
        }

        public string WeatherIcon
        {
            set { pbdwcWeatherIconPicBox.Load(@"http:" + value); }
        }

        public string Temp
        {
            get { return lbldwcTemp.Text; }
            set
            {
                lbldwcTemp.Text = value.ToString();
            }
        }
    }
}
