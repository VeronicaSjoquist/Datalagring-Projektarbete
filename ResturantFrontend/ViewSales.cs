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
        private Options _options;
        public ViewSales(Restaurant restaurant, Options options)
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
            _restaurant = restaurant;
            _options = options;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _options.Show();
        }
        private void ViewSales_Load(object sender, EventArgs e)
        {
            textBox_PrintRestauratName.Text = $"{_restaurant.Name}";
        }

        private void button_SoldBoxses_Click(object sender, EventArgs e)
        {

            var soldFoodboxes = _restaurantBackend.ShowSoldBoxes(_restaurant);
            listView1.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new[] { foodbox.Name, foodbox.Price.ToString(), foodbox.Type };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = foodbox;

                listView1.Items.Add(listViewItem);
            }

        }

        private void button_UnsoldBoxes_Click(object sender, EventArgs e)
        {
            var UnsoldFoodboxes = _restaurantBackend.ShowUnsoldBoxes(_restaurant);
            listView1.Items.Clear();
            foreach (var foodbox in UnsoldFoodboxes)
            {
                var row = new[] { foodbox.Name, foodbox.Price.ToString(), foodbox.Type };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = foodbox;

                listView1.Items.Add(listViewItem);
            }

        }
    }
}
