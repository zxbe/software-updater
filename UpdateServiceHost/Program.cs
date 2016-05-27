using System;
using System.ServiceProcess;

namespace UpdateServiceHost {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        static void Main() {

            //------------------------------------------------------------------------------------------------------
            //    USE FOR STAND ALONE TESTING
            //------------------------------------------------------------------------------------------------------

            //UpdateServiceHost.StartWcfService();
            //Console.ReadLine();
            //UpdateServiceHost.StopWcfService();

            //------------------------------------------------------------------------------------------------------
            //    USE TO RUN AS A SERVICE
            //------------------------------------------------------------------------------------------------------

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new UpdateWindowsService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
