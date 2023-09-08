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
            wresponseFromAPI = dataResponse;

            wlblLocationName = lblLoc;
            wlblCurrentDate = lblDate;
            wlblCurrentTemperature = lblCurrTemp;
            wlblDescription = lblDesc;
            wpbIcon = pbWeaIcon;
            wlblWeekDay = lblWDay;            
        }

        public void DiplayCurrentWeather()
        {
            
        }


    }
}
