using System.Windows.Forms;

namespace WeatherApp
{
    class WeatherWidget
    {
        // Controls to hold View Controls
        public Label lblLocationName { get; private set; }
        public Label lblCurrentDate { get; private set; }
        public Label lblCurrentTemperature { get; private set; }
        public Label lblDescription { get; private set; }
        public PictureBox pbIcon { get; private set; }
        public Label lblWeekDay { get; private set; }
        public dynamic responseFromAPI { get; private set; }

        public WeatherWidget(dynamic dataResponse, Label lblLoc, Label lblDate, Label lblCurrTemp, Label lblDesc, PictureBox pbWeaIcon, Label lblWDay)
        {
            responseFromAPI = dataResponse;

            lblLocationName = lblLoc;
            lblCurrentDate = lblDate;
            lblCurrentTemperature = lblCurrTemp;
            lblDescription = lblDesc;
            pbIcon = pbWeaIcon;
            lblWeekDay = lblWDay;            
        }

        public void DiplayCurrentWeather()
        {
            
        }


    }
}
