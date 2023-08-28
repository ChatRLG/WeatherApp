
namespace WeatherApp
{
    class City
    {
        public string Name { get; private set; }

        public City(string name)
        {
            this.Name = name;
        }

        public int GetCityIDFromCityName()
        {
            if (Settings.CITIES_IDS.TryGetValue(Name, out int cityID))
            {
                return cityID;
            }
            return -1;
        }
    }
}
