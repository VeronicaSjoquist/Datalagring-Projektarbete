using UserFrontend.Buttons;
using UserFrontend.Buttons.Admin;
using UserFrontend.Buttons.Customer;
using UserFrontend.Buttons.Restaurant;

namespace UserFrontend
{
    public partial class UserFront : Form
    {
        public UserFront()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        private void customizeDesign()
        {
            panelFoodRescue.Visible = false;
            panelCustom.Visible = false;
            paneRestaurant.Visible = false;
            panelAdmin.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelFoodRescue.Visible == true) panelFoodRescue.Visible = false;
            if (panelCustom.Visible == true) panelCustom.Visible = false;
            if (paneRestaurant.Visible == true) paneRestaurant.Visible = false;
            if (panelAdmin.Visible == true) panelAdmin.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        #region FoodRescueMenu

        private void btnFoodRescue_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFoodRescue);
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            openWorkSpace(new Description());
            hideSubMenu();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            openWorkSpace(new Git());
            hideSubMenu();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            openWorkSpace((new btnGitReport()));
            hideSubMenu();
        }

        #endregion

        #region CustomerMenu

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustom);
        }

        private void btnUnsoldFoodBoxes_Click(object sender, EventArgs e)
        {
            openWorkSpace(new UnsoldFoodBoxes());
            hideSubMenu();
        }

        private void btnBuyFoodBox_Click(object sender, EventArgs e)
        {
            openWorkSpace(new BuyFoodBox());
            hideSubMenu();
        }

        private void btwCustomerHistory_Click(object sender, EventArgs e)
        {
            openWorkSpace(new CustomerHistory());
            hideSubMenu();
        }

        #endregion

        #region RestaurantMenu

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            showSubMenu(paneRestaurant);
        }

        private void btnShowSoldBoxes_Click(object sender, EventArgs e)
        {
            openWorkSpace(new SoldBoxes());
            hideSubMenu();
        }

        private void btnAddFoodBox_Click(object sender, EventArgs e)
        {
            openWorkSpace(new AddFoodBox());
            hideSubMenu();
        }

        #endregion

        #region AdminMenu

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdmin);
        }

        private void btnShowAllCustomers_Click(object sender, EventArgs e)
        {
            openWorkSpace(new ShowAllCustomers());
            hideSubMenu();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            openWorkSpace(new RemoveCustomer());
            hideSubMenu();
        }

        private void btnShowAllRestaurants_Click(object sender, EventArgs e)
        {
            openWorkSpace(new ShowAllResturants());
            hideSubMenu();
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            openWorkSpace(new AddRestaurant());
            hideSubMenu();
        }

        private void btnCreateAndSeedDb_Click(object sender, EventArgs e)
        {
            openWorkSpace(new btnCreateAndSeedDb());
            hideSubMenu();
        }

        #endregion

        private Form activeForm = null;
        private void openWorkSpace(Form workSpace)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = workSpace;
            workSpace.TopLevel = false;
            workSpace.FormBorderStyle = FormBorderStyle.None;
            workSpace.Dock = DockStyle.Fill;
            panelWorkSpace.Controls.Add(workSpace);
            panelWorkSpace.Tag = workSpace;
            workSpace.BringToFront();
            workSpace.Show();
        }

        
    }
} 
