using System;
using System.Configuration;
using System.Diagnostics;
using System.ServiceModel;

namespace UpdateServiceHost {
    static class UpdateServiceHost {
        private static ServiceHost _serviceHost;

        public static void StartWcfService()
        {
            //Consider putting the baseAddress in the configuration system
            //and getting it here with AppSettings
            //Uri baseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings.Get("baseAddress"));
            Uri baseAddress = new Uri("http://localhost:1805/ServiceModelSamples/service");

            //Instantiate new ServiceHost 
            _serviceHost = new ServiceHost(typeof(UpdateWcfService.UpdateWcfService), baseAddress);

            //Open myServiceHost
            _serviceHost.Open();
        }

        public static void StopWcfService()
        {
            EventLog.WriteEntry("blub", "fertsch");
            //Call StopService from your shutdown logic (i.e. dispose method));
            if (_serviceHost.State != CommunicationState.Closed)
                _serviceHost.Close();
        }
    }
}
