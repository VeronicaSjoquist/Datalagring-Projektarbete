using System.Diagnostics;

namespace UserFrontend.Buttons
{
    public partial class btnGitReport : Form
    {
        public btnGitReport()
        {
            InitializeComponent();
        }

        private void btnReturnFromDescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGitReportWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://github.com/VeronicaSjoquist/Datalagring-Projektarbete/blob/master/Joakim.md", UseShellExecute = true });
        }
    }
}
