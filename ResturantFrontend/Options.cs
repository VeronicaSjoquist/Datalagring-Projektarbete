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
    
    public partial class Options : Form
    {
        private Restaurant _restaurant;
        public Options(Restaurant restaurant)
        {
            _restaurant = restaurant;
            InitializeComponent();
        }

        private void Button_AddBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFoodbox addFoodbox = new AddFoodbox(_restaurant);
            addFoodbox.Show();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBox_PrintRestauratName.Text = $"{_restaurant.Name}";

        }
    }
}
