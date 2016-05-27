// Provide the ProjectInstaller class which allows 
// the service to be installed by the Installutil.exe tool
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace UpdateServiceHost
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller() {
            process = new ServiceProcessInstaller {Account = ServiceAccount.LocalSystem};
            service = new ServiceInstaller {ServiceName = "WCFWindowsServiceSample"};
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
