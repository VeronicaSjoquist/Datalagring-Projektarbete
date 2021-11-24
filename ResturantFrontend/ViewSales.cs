using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Backend;
using DataLayer.Model;

namespace ResturantFrontend
{
    public partial class ViewSales : Form
    {
        private RestaurantBackend _restaurantBackend;
        public ViewSales()
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            var soldFoodboxes = _restaurantBackend.ShowSoldBoxes();

        }
    }
}
