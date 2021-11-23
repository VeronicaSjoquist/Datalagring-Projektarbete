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

namespace RestaurantFrontend
{
    public partial class RestaurantFrontend : Form
    {

        private readonly RestaurantBackend _restaurantBackend;
        public RestaurantFrontend()
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurantToLogin = _restaurantBackend.LoginRestaurant(textBox_Username.Text, textBox_Password.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
           textBox_Username.Clear();
           textBox_Password.Clear();

        }
    }
}
