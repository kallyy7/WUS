using System.ComponentModel;

namespace WindowsUserService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceInstaller2_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }
    }
}
