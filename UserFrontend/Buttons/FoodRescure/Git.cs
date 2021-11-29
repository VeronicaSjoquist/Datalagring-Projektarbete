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
    public partial class Git : Form
    {
        public Git()
        {
            InitializeComponent();
        }

        private void btnGitWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/");//Behöver länka webläsare ev.
        }

        private void btnReturnFromDescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
