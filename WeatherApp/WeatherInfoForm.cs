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

        public WeatherInfoForm(dynamic api_response)
        {
            InitializeComponent();
            weather = new Weather(api_response, dwcDailyWInfo, lbldwcLocation, lbldwcCurrentTemp, lbldwcDate, lbldwcMainDesc, pbdwcMainIcon, flpWeatherForecast);
            weather.DisplayCurrentWeatherInfo();
            weather.DisplayWeatherForecast();
        }

        private void WeatherInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void WeatherInfoForm_Load(object sender, System.EventArgs e)
        {

        }

        private void brndwcNewCity_Click(object sender, System.EventArgs e)
        {
            WeatherBoard WB = new WeatherBoard();
            WB.Show();
            this.Close();
        }

        private void btndwcCreateWidget_Click(object sender, System.EventArgs e)
        {
            CreateWidget newWidget = new CreateWidget();
            newWidget.Show();
        }

        private void btndwcInfo_Click(object sender, System.EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
