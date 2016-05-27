using System;
using System.ServiceProcess;

namespace UpdateServiceHost {
    partial class UpdateWindowsService : ServiceBase {
        public UpdateWindowsService() {
            InitializeComponent();
            // Name the Windows Service
            ServiceName = "WCFWindowsServiceSample";
        }

        protected override void OnStart(string[] args) {
            UpdateServiceHost.StartWcfService();
        }

        protected override void OnStop() {
            UpdateServiceHost.StopWcfService();
        }
    }
}
