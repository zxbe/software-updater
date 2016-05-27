namespace com.queomedia.updater.data {
    public class ProxyInformation {
        private string domain;
        private string httpsPort;
        private User proxyUser;
        private string url;

        public string Domain {
            get { return domain; }
            set { domain = value; }
        }

        public string HttpsPort {
            get { return httpsPort; }
            set { httpsPort = value; }
        }
        public User ProxyUser {
            get { return proxyUser; }
            set { proxyUser = value; }
        }
        public string Url {
            get { return url; }
            set { url = value; }
        }
    }
}