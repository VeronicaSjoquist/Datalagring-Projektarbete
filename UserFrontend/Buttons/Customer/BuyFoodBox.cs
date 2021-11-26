using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
