namespace Com.QueoMedia.Updater.Data {
    public class LocalInformation {
        private VersionNumber currentVersion;
        private string productName;
        private string programExecutable;
        private ProxyInformation proxy;
        private User serverUser;
        private string updateServerUrl;

        public VersionNumber CurrentVersion {
            get { return currentVersion; }
            set { currentVersion = value; }
        }

        public string ProductName {
            get { return productName; }
            set { productName = value; }
        }

        public string ProgramExecutable {
            get { return programExecutable; }
            set { programExecutable = value; }
        }
        public ProxyInformation Proxy {
            get { return proxy; }
            set { proxy = value; }
        }
        public User ServerUser {
            get { return serverUser; }
            set { serverUser = value; }
        }
        public string UpdateServerUrl {
            get { return updateServerUrl; }
            set { updateServerUrl = value; }
        }
    }
}