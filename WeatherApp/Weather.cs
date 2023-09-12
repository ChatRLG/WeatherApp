using System;
using System.Windows.Forms;

namespace WeatherApp
{
    public class Weather
    {
        public Label CityName { get; private set; }
        public Label CurrentDate { get; private set; }
        public Label CurrentTemperature { get; private set; }
        public Label Description { get; private set; }
        public PictureBox PictureBoxIcon { get; private set; }
        public dynamic WeatherResponseFromAPI { get; private set; }

        public FlowLayoutPanel WeatherForecastFlowLayout { get; private set; }

        public DailyWInfo DWI { get; private set; }

        public Weather(dynamic dataResponse, DailyWInfo dwi, Label lblCityName, Label lblCurrTemp, Label lblDate,
            Label lblCurrDesc, PictureBox pbWeatherIcon, FlowLayoutPanel flpWeatherForecast)
        {
            // initialize weather data
            WeatherResponseFromAPI = dataResponse;

            // initialize view control reference            
            CityName = lblCityName;
            CurrentDate = lblDate;
            DWI = dwi;
            CurrentTemperature = lblCurrTemp;
            Description = lblCurrDesc;
            PictureBoxIcon = pbWeatherIcon;
            WeatherForecastFlowLayout = flpWeatherForecast;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh Test");
        }

        public void DisplayCurrentWeatherInfo()
        {
            DisplayWeatherInfo();
            DisplayTemperature();
            DisplayCurrentDate();
            DisplayDescription();
            DisplayHumidity();
            DisplayRainChance();
            DisplayDayNight();
            DisplayWindSpeed();
            DisplayIcon();
            SetCurrentConditionData();

        }

        private void SetCurrentConditionData()
        {
            DWI.HumidityValue = WeatherResponseFromAPI.current.temp_c + " ˚C";
            DWI.SunRise = WeatherResponseFromAPI.forecast.forecastday[0].astro.sunrise;
            DWI.SunSetTime = WeatherResponseFromAPI.forecast.forecastday[0].astro.sunset;
            DWI.MoonRiseTime = WeatherResponseFromAPI.forecast.forecastday[0].astro.moonrise;
            DWI.MoonSetTime = WeatherResponseFromAPI.forecast.forecastday[0].astro.moonset;
            DWI.UVValue = WeatherResponseFromAPI.current.uv;
            DWI.Wind = WeatherResponseFromAPI.current.wind_kph;
            DWI.Precipitation = WeatherResponseFromAPI.current.precip_mm;
        }

        private void DisplayIcon()
        {
            var Url = WeatherResponseFromAPI.current.condition.icon;
            PictureBoxIcon.Load(@"http:" + Url.ToString());
        }

        private void DisplayWindSpeed()
        {
            throw new NotImplementedException();
        }

        private void DisplayDayNight()
        {
            throw new NotImplementedException();
        }

        private void DisplayRainChance()
        {
            throw new NotImplementedException();
        }

        private void DisplayHumidity()
        {
            throw new NotImplementedException();
        }

        private void DisplayDescription()
        {
            throw new NotImplementedException();
        }

        private void DisplayCurrentDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayTemperature()
        {
            throw new NotImplementedException();
        }

        public void DisplayWeatherInfo()
        {
            
        }
        public void DisplayWeatherForecast()
        {
            var weatherForecastDaysInfo = WeatherResponseFromAPI.forecast.forecastday;

            foreach (var dayInfo in weatherForecastDaysInfo)
            {
                DailyWeatherControl dailyForecastUI = new DailyWeatherControl();
                dailyForecastUI.Date = dayInfo.date;
                dailyForecastUI.WeatherDescription = dayInfo.day.condition.text;
                dailyForecastUI.WeatherIcon = dayInfo.day.condition.icon.ToString();
                dailyForecastUI.Temp = dayInfo.day.maxtemp_c + "˚C";
                WeatherForecastFlowLayout.Controls.Add(dailyForecastUI);
            }
        }
    }
}
