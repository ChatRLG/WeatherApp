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
        public dynamic WeaatherResponseFromAPI { get; private set; }

        public FlowLayoutPanel WeatherForecastFlowLayout { get; private set; }

        public DailyWInfo DWI { get; private set; }

        public Weather(dynamic dataResponse, DailyWInfo dwi, Label lblCityName, Label lblCurrTemp, 
            Label lblCurrDesc, PictureBox pbWeatherIcon, FlowLayoutPanel flpWeatherForecast)
        {
            // initialize weather data
            WeaatherResponseFromAPI = dataResponse;

            // initialize viw control reference            
        }

    }
}
