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
            var soldFoodboxes = userBackend.UnsoldFoodBoxes("Fish"); ;
            listUnsold.Items.Clear();

            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() +":-" };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnUnsoldFoodMeatBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.UnsoldFoodBoxes("Meat"); ;
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        private void btnUnsoldFoodVeganBoxes_Click(object sender, EventArgs e)
        {
            UserBackend userBackend = new UserBackend();
            var soldFoodboxes = userBackend.UnsoldFoodBoxes("Vegan"); ;
            listUnsold.Items.Clear();
            foreach (var foodbox in soldFoodboxes)
            {
                var row = new string[] { foodbox.Name, foodbox.restaurant.Name, foodbox.Price.ToString() };
                var listviewItem = new ListViewItem(row);
                listviewItem.Tag = foodbox;

                listUnsold.Items.Add(listviewItem);
            }
        }

        #endregion
    }
}
