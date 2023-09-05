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
        public Widget()
        {
            InitializeComponent();
        }
    }
}
