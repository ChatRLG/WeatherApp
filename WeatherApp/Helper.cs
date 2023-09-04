using System.Collections.Generic;
using System.IO;

namespace WeatherApp
{
    public static class Helper
    {
        public static string PATH_LOCATIONS_LIST = @"../../Resources/locations_list.txt";

        public static string[] GetLocationList()
        {
            List<string> locations = new List<string>();

            using (StreamReader sr = new StreamReader(PATH_LOCATIONS_LIST))
            {
                var data = sr.ReadLine();
                while (data != null)
                {
                    locations.Add(data);
                    data = sr.ReadLine();
                }
                return locations.ToArray();                
            }
        }

        public static string ConvertFahrenheitToCelcius(double fTemp)
        {
            return (((5/9)*(fTemp - 32)).ToString());            
        }

        public static string ConvertCelciusToFahrenheit(double cTemp)
        {
            return (((cTemp * 1.8) + 32).ToString());
        }
    }
}
