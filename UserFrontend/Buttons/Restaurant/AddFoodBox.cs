using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFrontend.Buttons.Restaurant
{
    public partial class AddFoodBox : Form
    {
        public AddFoodBox()
        {
            InitializeComponent();
        }

        private void btnReturnFromAddFoodBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
