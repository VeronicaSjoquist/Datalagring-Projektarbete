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
            var soldFoodboxes = userBackend.listUnsoldonRestaurant("Theos Ricehouse"); 
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.ID.ToString(), foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnKanelbulleKim_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.listUnsoldonRestaurant("Kanelbulle Kim"); 
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
            var soldFoodboxes = userBackend.listUnsoldonRestaurant("Veronicas Köttfärssås"); 
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
            UserBackend userBackend = new UserBackend();
            var UserList = userBackend.userList(); 
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
