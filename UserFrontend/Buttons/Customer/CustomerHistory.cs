using DataLayer.Backend;

namespace UserFrontend.Buttons.Customer
{
    public partial class CustomerHistory : Form
    {
        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void btnReturnFromCustomerHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTheosHistory_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();

            var soldFoodboxes = userBackend.ListOfCustomerHistory(1); ;
            listHistorySold.Items.Clear();

            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { 
                    foodbox.customer.ID.ToString(), 
                    foodbox.customer.Name, 
                    foodbox.restaurant.Name, 
                    foodbox.Name,
                    foodbox.Price.ToString() + ":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listHistorySold.Items.Add(listviewItem);
            }
        }

        private void btnKimsHistory_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();

            var soldFoodboxes = userBackend.ListOfCustomerHistory(2); ;
            listHistorySold.Items.Clear();

            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(),
                    foodbox.customer.Name,
                    foodbox.restaurant.Name,
                    foodbox.Name,
                    foodbox.Price.ToString() + ":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listHistorySold.Items.Add(listviewItem);
            }
        }

        private void btnVeronicasHistory_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();

            var soldFoodboxes = userBackend.ListOfCustomerHistory(3); ;
            listHistorySold.Items.Clear();

            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(),
                    foodbox.customer.Name,
                    foodbox.restaurant.Name,
                    foodbox.Name,
                    foodbox.Price.ToString() + ":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listHistorySold.Items.Add(listviewItem);
            }
        }
    }
}
