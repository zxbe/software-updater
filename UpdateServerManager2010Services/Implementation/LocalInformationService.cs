using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Utilities;

namespace UpdateServerManager2010Services.Implementation {
    public class LocalInformationService : ILocalInformationService {
        #region Implementation of ILocalInformationService

        public string GenerateLocalInformation(string servername, string executable, string serverpath, string httpsUser, string httpsPwd, string proxyUrl, string proxyHttpsPort, string proxyUser, string proxyPwd) {
            LocalInformation local = new LocalInformation
                                         {
                                             CurrentVersion = new VersionNumber("0.0.0.0"),
                                             ProductName = servername,
                                             ProgramExecutable = executable,
                                             Proxy = new ProxyInformation
                                                         {
                                                             Url = proxyUrl,
                                                             HttpsPort = proxyHttpsPort,
                                                             ProxyUser = new User
                                                                             {
                                                                                 Name = proxyUser,
                                                                                 Pwd = proxyPwd
                                                                             }
                                                         },
                                             ServerUser = new User
                                                              {
                                                                  Name = httpsUser,
                                                                  Pwd = httpsPwd
                                                              },
                                             UpdateServerUrl = serverpath
                                         };
            return DeSerializer.SerializeToString(local);
        }

        #endregion
    }
}
