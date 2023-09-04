using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherBoard : Form
    {
        List<Location> locationList;

        public static Label LabelSpinner { get; set; }

        //form movement variables
        private bool isDragging = false;
        private Point newPoint = new Point(0, 0);

        public WeatherBoard()
        {
            InitializeComponent();
            FillListCityData();
            FillCityNamesToLocationComboBox();
            toolTipBtnGetForecast.SetToolTip(btnGetForecast, "Click to get forecast");
            LabelSpinner = lblProgressUpdate;
        }

        private void FillListCityData()
        {
            locationList = new List<Location>();

            foreach (var cityIDpair in Settings.LOCATION_IDS)
            {
                Location _location = new Location(cityIDpair.Key);
                locationList.Add(_location);
            }
        }

        private void FillCityNamesToLocationComboBox()
        {
            List<string> locationNames = new List<string>();

            foreach (var city in locationList)
            {
                locationNames.Add(city.Name);
            }

            //cbCityList.DataSource = cityNames;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LabelSpinner.Visible = true;
            // get current selected city obj 
            string currentSelectedCityName = txtBoxLocation.Text;

            // pass it to API 
            API apiWeather = new API(currentSelectedCityName, this);
            //fetch api to get current weather data and store them in CurrentWeatherResponseFromAPI field
            API.FetchDataFromAPI(false);
            txtBoxLocation.Text = "";

        }

        private void WeatherBoard_Load(object sender, EventArgs e)
        {
            lblProgressUpdate.Visible = false;

            AutoCompleteStringCollection cityColl = new AutoCompleteStringCollection();

            string[] listCityNames = Helper.GetLocationList();

            foreach (var cityname in listCityNames)
            {
                cityColl.Add(cityname);
            }

            txtBoxLocation.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBoxLocation.AutoCompleteCustomSource = cityColl;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Close();
        }

        //moves window around based on mouse movement
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - newPoint.X, p.Y - newPoint.Y);
            }
        }

        //when mouse is down on panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            newPoint = new Point(e.X, e.Y);
        }

        //when user lets go of mouse
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        //minimize
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EnteringCity(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGetForecast.PerformClick();
            }
        }

        private void WeatherBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

    }
}