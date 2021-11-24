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
        private Restaurant _restaurant;
        public ViewSales(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
            _restaurant = restaurant;
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            var soldFoodboxes = _restaurantBackend.ShowSoldBoxes(_restaurant);

        }
    }
}
