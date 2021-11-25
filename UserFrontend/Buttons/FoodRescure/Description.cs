using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFrontend.Buttons
{
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        private void btnReturnFromDescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDesciption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
