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
    public partial class CreateWidget : Form
    {
        public CreateWidget()
        {
            InitializeComponent();
        }

        private void btnNWConfirm_Click(object sender, EventArgs e)
        {
            API WeatehrAPI = new API(tbLocation.Text);
            // fetch current weather data from API and store in 
            API.FetchDataFromAPI(true);
            this.Close();
        }

        private void SetLocationForm_LocationChanged(object sender, EventArgs e)
        {
            //enter location
            AutoCompleteStringCollection locCollection = new AutoCompleteStringCollection();

            string[] locationList = Helper.GetLocationList();
            foreach (var loc in locationList)
            {
                locCollection.Add(loc);
            }

            tbLocation.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbLocation.AutoCompleteCustomSource = locCollection;
        }

        private void ConfirmCity(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNWConfirm.PerformClick();                
            }            
        }
    }
}
