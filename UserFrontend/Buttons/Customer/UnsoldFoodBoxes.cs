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

        protected void btnUnsoldFoodBoxes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
