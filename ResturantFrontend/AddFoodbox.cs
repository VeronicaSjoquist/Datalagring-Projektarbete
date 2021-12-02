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
    public partial class AddFoodbox : Form
    {
        private Restaurant _restaurant;
        private Options _options;
        private RestaurantBackend _restaurantBackend;
        public AddFoodbox(Restaurant restaurant, Options options)
        {
            _restaurantBackend = new RestaurantBackend();
            _options = options;
            _restaurant = restaurant;
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
            _options.Show();
        }

        private void AddFoodbox_Load(object sender, EventArgs e)
        {
            textBox_PrintRestauratName.Text = $"{_restaurant.Name}";
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(textBox_price.Text, out price))
            {
                try
                {
                    _restaurantBackend.AddFoodBox(textBox_Name.Text, textBox_type.Text, price, _restaurant);

                    MessageBox.Show($"{textBox_Name.Text} is now up for sale");

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter price in numbers!");
                textBox_price.Clear();
            }

            textBox_Name.Clear();
            textBox_price.Clear();
            textBox_type.Clear();

        }
    }
}
