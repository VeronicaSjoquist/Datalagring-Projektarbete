using DataLayer.Backend;

namespace UserFrontend.Buttons.Customer
{
    public partial class BuyFoodBox : Form
    {
        public BuyFoodBox()
        {
            InitializeComponent();
        }

        private void btnReturnFromBuyFoodBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnsoldFoodFishBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnRestaurant("Theos Ricehouse"); 
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(), foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() + ":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnKanelbulleKim_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnRestaurant("Kanelbulle Kim"); 
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(), foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnVeronicasKöttfärssås_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnRestaurant("Veronicas Köttfärssås"); 
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(), foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AdminBackend adminBackend = new AdminBackend();
            var UserList = adminBackend.ShowAllCustomers(); 
            listCustomers.Items.Clear();
            foreach (var customer in UserList)
            {
                var row = new string[] { customer.ID.ToString(), customer.Name };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = customer;

                listCustomers.Items.Add(listviewItem);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            int x = Int32.Parse(textBoxBox.Text);
            int y = Int32.Parse(textBoxCustomer.Text);
            userBackend.BuyFoodBox(x, y);
            listUnsold.Items.Clear();
            listCustomers.Items.Clear();
            textBoxBox.Clear();
            textBoxCustomer.Clear();
            MessageBox.Show("Du har nu köpt en matlåda!");
        }
    }
}
