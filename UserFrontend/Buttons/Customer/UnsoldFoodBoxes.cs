using DataLayer.Backend;

namespace UserFrontend.Buttons.Customer
{
    public partial class UnsoldFoodBoxes : Form
    {
        public UnsoldFoodBoxes()
        {
            InitializeComponent();
        }

        private void btnReturnFromUnsoldFoodBoxes_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        #region UnsoldBoxes

        protected void btnUnsoldFoodBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnType("Fish"); ;
            listUnsoldBoxes.Items.Clear();

            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() +":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsoldBoxes.Items.Add(listviewItem);
            }
        }

        private void btnUnsoldFoodMeatBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnType("Meat"); ;
            listUnsoldBoxes.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsoldBoxes.Items.Add(listviewItem);
            }
        }

        private void btnUnsoldFoodVeganBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.ListUnsoldFoodBoxesOnType("Vegan"); ;
            listUnsoldBoxes.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsoldBoxes.Items.Add(listviewItem);
            }
        }

        #endregion
    }
}
