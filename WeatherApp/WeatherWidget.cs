using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public class WeatherWidget
    {
        // Controls to hold View Controls
        public Label wlblLocationName { get; private set; }
        public Label wlblCurrentDate { get; private set; }
        public Label wlblCurrentTemperature { get; private set; }
        public Label wlblDescription { get; private set; }
        public PictureBox wpbIcon { get; private set; }
        public Label wlblWeekDay { get; private set; }
        public dynamic wresponseFromAPI { get; private set; }

        public WeatherWidget()
        { }

        public WeatherWidget(dynamic dataResponse, Label lblLoc, Label lblDate, Label lblCurrTemp, Label lblDesc, PictureBox pbWeaIcon, Label lblWDay)
        {
            // initializing weather data
            wresponseFromAPI = dataResponse;

            // initializing view control reference
            wlblLocationName = lblLoc;
            wlblCurrentDate = lblDate;
            wlblCurrentTemperature = lblCurrTemp;
            wlblDescription = lblDesc;
            wpbIcon = pbWeaIcon;
            wlblWeekDay = lblWDay;            
        }

        public void DiplayCurrentWeather()
        {
            DisplayWeather();
            DisplayTemp();
            DisplayCurrentDateTime();
            DisplayDescription();
            DisplayIcon();
            DisplayWeekDay();            
        }

        private void DisplayWeather()
        {
            wlblLocationName.Text = wresponseFromAPI.location.name;            
        }

        private void DisplayTemp()
        {
           wlblCurrentTemperature.Text = wresponseFromAPI.current.temp_c + " ˚C";
        }
        private void DisplayCurrentDateTime()
        {
            wlblCurrentDate.Text = wresponseFromAPI.forecast.forecast[0].ToString();
        }
        private void DisplayDescription()
        {
            wlblDescription.Text = wresponseFromAPI.current.condition.text.ToString();
        }
        private void DisplayIcon()
        {
            var UrlPath = wresponseFromAPI.current.condition.icon;
            wpbIcon.Load(@"http:" + UrlPath.ToString());
        }
        private void DisplayWeekDay()
        {
            var currentDate = (DateTime)wresponseFromAPI.forecast.forecastday[0].date;
            var dayOfWeek = GetDayOfWeekFromGivenDate(currentDate);
            wlblWeekDay.Text = dayOfWeek;
        }

        private string GetDayOfWeekFromGivenDate(DateTime currentDate)
        {
            return currentDate.DayOfWeek.ToString();
        }
    }
}
