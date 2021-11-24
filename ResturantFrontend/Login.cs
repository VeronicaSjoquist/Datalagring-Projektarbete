using DataLayer.Backend;
using DataLayer.Model;

namespace ResturantFrontend
{
    public partial class Login : Form
    {
        private RestaurantBackend _restaurantBackend;
        public Login()
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {

            try
            {
                Restaurant restaurantToLogin = _restaurantBackend.LoginRestaurant(textBox_Username.Text, textBox_Password.Text);
                MessageBox.Show($"Welcome {restaurantToLogin.Name}");
                this.Hide();
                Options options = new Options(restaurantToLogin);
                options.Show();
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