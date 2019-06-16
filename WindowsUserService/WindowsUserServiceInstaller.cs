namespace WindowsUserService
{
    using System.Configuration.Install;
    using System.Reflection;

    public class WindowsUserServiceInstaller : Installer
    {
        private static readonly string _exePath =
        Assembly.GetExecutingAssembly().Location;

        public static bool InstallMe()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(
                    new string[] { _exePath });
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool UninstallMe()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(
                    new string[] { "/u", _exePath });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
