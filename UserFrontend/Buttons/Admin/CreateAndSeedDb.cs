using DataLayer.Backend;

namespace UserFrontend.Buttons.Admin
{
    public partial class btnCreateAndSeedDb : Form
    {
        public btnCreateAndSeedDb()
        {
            InitializeComponent();
        }

        private void btnReturnFromCreatAnSeedDb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminBackend adminBackend = new AdminBackend();
            adminBackend.CreateAndSeedDb();
            MessageBox.Show("Nu har databasen startats om");
        }
    }
}
