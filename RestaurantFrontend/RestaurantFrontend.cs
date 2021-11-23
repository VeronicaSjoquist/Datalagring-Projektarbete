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
        private readonly AdminBackend _adminBackend;

        public RestaurantFrontend()
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
            _adminBackend = new AdminBackend();
            _adminBackend.CreateAndSeedDb();

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
                Restaurant restaurantToLogin =
                    _restaurantBackend.LoginRestaurant(textBox_Username.Text, textBox_Password.Text);
                MessageBox.Show($"Welcome {restaurantToLogin.Name}");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            textBox_Username.Clear();
            textBox_Password.Clear();

        }
    }
}
