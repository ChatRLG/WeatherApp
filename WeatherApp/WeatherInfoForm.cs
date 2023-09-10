using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherInfoForm : Form
    {
        private dynamic API_Response;
        private WeatherApp

        public WeatherInfoForm()
        {
            InitializeComponent();
        }

        public WeatherInfoForm(dynamic aPI_Response)
        {
            this.API_Response = aPI_Response;
        }
    }
}
