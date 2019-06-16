namespace WindowsUserService
{
    using Config.Support.CountdownTool;
    using System;
    using System.ServiceProcess;

    public partial class UserService : ServiceBase
    {
        public UserService()
        {
            InitializeComponent();

            CanPauseAndContinue = true;
            CanHandleSessionChangeEvent = true;
            ServiceName = "WindowsUserService";
        }

        protected override void OnSessionChange(SessionChangeDescription changeDescription)
        {
            if (changeDescription.Reason == SessionChangeReason.SessionLock ||
                changeDescription.Reason == SessionChangeReason.SessionLogoff ||
                changeDescription.Reason == SessionChangeReason.ConsoleDisconnect)
            {
               // string _exePath = Assembly.GetExecutingAssembly().Location;

                DbHelper.InsertLastDisconnect(DateTime.Now);
            }

            base.OnSessionChange(changeDescription);
        }

        public void Start()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            System.Diagnostics.Debugger.Launch(); // start the service on debug
        }

        protected override void OnStop()
        {

        }
    }
}
