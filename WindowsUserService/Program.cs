namespace WindowsUserService
{
    using System;
    using System.ServiceProcess;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                UserService us = new UserService();
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new UserService()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
