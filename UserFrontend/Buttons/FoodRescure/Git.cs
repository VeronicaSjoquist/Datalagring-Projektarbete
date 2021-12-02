using System.Diagnostics;


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
            System.Diagnostics.Process.Start(new ProcessStartInfo{FileName = "https://github.com/VeronicaSjoquist/Datalagring-Projektarbete",UseShellExecute = true});
        }

        private void btnReturnFromDescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}