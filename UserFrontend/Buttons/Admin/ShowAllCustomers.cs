using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFrontend.Buttons.Admin
{
    public partial class ShowAllCustomers : Form
    {
        public ShowAllCustomers()
        {
            InitializeComponent();
        }

        private void btnReturnFromShowAllCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
