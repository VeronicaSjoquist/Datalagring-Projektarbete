using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Model;

namespace ResturantFrontend
{
    public partial class AddFoodbox : Form
    {
        private Restaurant _restaurant;
        public AddFoodbox(Restaurant restaurant)
        {
            _restaurant = restaurant;
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Hide();
            Options options = new Options(_restaurant);
            options.Show();
        }

        private void AddFoodbox_Load(object sender, EventArgs e)
        {
            textBox_PrintRestauratName.Text = $"{_restaurant.Name}";
        }
    }
}
