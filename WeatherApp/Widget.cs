using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Widget : Form
    {
        // widget movement var's 
        private bool isDragging = false;
        private Point newPoint = new Point(0,0);

        // refresh widget
        public WeatherWidget _reload = new WeatherWidget();

        public Widget(dynamic WeatherResponse)
        {
            InitializeComponent();

            WeatherWidget widget = new WeatherWidget(WeatherResponse, wlblCity, wlblDate, wlblTempDailyBoxLabel, wlblWeatherDescription, wbpWeatherIconPB, wlblDate);
            widget.DiplayCurrentWeather();
            _reload = widget;
        }

        private void wpnlTitleBG_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            newPoint = new Point(e.X, e.Y);
        }

        private void wpnlTitleBG_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void wpnlTitleBG_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - newPoint.X, p.Y - newPoint.Y); 
            }
        }

        private void wbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // reload the widget
        private void wbtnRefresh_Click(object sender, EventArgs e)
        {
            _reload.DiplayCurrentWeather();
            MessageBox.Show("Widget refreshed.");
        }

        private void Widget_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }
    }
}
