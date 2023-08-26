using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    class API
    {
        public static string SelectedCity { get; private set; }
        public static dynamic API_Response { get; set; } 
        public static dynamic CurrenyWeather { get; set; }
        public static dynamic WeatherForecast { get; set; }
        public static WeatherInfoForm InfoForm { get; private set; }
        public static WeatherBoard WeatherBoard { get; set; }

        public API(string city)
        {
            SelectedCity = city;
        }

        public API(string city, WeatherBoard weatherboard)
        {
            SelectedCity = city;
            WeatherBoard = weatherboard;
        }

        public async static void FetchDataFromAPI(bool widget)
        {
            var url = Settings.WEATHER_URL + Settings.API_KEY + "+&q=" + SelectedCity + "&days=" + Settings.FORECAST_DAYS_LIMIT;

            try
            {
                // Fetch data from the API
                using (HttpClient httpClient = new HttpClient())
                using (HttpResponseMessage response = await httpClient.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    // Read the response string
                    string result = await content.ReadAsStringAsync();
                    
                    // Deserialize the JSON object
                    API_Response = JsonConvert.DeserializeObject<dynamic>(result);

                    WeatherBoard.LabelSpinner.Visible = false;

                    if (API_Response != null)
                    {
                        if (widget)
                        {
                            Widget widget = new Widget(API_Response);
                            widget.Show();
                        }
                        else
                        {
                            InfoForm = new WeatherInfoForm(API_Response);
                            InfoForm.Show();
                            WeatherBoard.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
