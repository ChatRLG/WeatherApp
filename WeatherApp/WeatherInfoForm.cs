using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherInfoForm : Form
    {
        private Weather weather;

        // form movement variables
        private bool isDragging;
        private Point newPoint = new Point(0, 0);

        public WeatherInfoForm()
        {
            InitializeComponent();
        }

        public WeatherInfoForm(dynamic api_response)
        {
            InitializeComponent();
            //weather = new Weather(api_response, lblCityName);
        }
    }
}
