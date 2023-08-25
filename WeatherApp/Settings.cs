using System.Collections.Generic;
namespace WeatherApp
{
    class Settings
    {
        // List of supported cities
        public static Dictionary<string, int> CITIES_IDS = new Dictionary<string, int>()
        {
            { "Calgary", 5913490 },
            { "Toronto", 6087824 },
            { "Vancouver", 6090785 },
            { "Saskatoon", 6141256 },
            { "Quebec", 6325494 },
            { "Airdrie", 5882799 },
            { "Medicine Hat", 6071618},
            { "Banff", 5892532 },
            { "California", 4350049 },
            { "Florida", 3851244 }
        };

        // API Public Key
        public static string API_KEY = "49dd73dca58244a685c52418182910";

        // Weather API URL
        public static string WEATHER_URL = "http://api.apixu.com/v1/forecast.json?key=";

        // Forecast days limit
        public static int FORECAST_DAYS_LIMIT = 5;

    }
}
