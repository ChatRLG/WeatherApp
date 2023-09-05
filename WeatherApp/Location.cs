
namespace WeatherApp
{
    class Location
    {
        public string Name { get; private set; }

        public Location(string name)
        {
            this.Name = name;
        }

        public int GetCityIDFromCityName()
        {
            if (Settings.LOCATION_IDS.TryGetValue(Name, out int locationID))
            {
                return locationID;
            }
            return -1;
        }
    }
}
