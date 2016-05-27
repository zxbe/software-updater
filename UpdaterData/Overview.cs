using System.Collections.Generic;

namespace Com.QueoMedia.Updater.Data {
    public class Overview {
        private List<VersionNumber> versions;

        public List<VersionNumber> Versions {
            get { return versions; }
            set {
                versions = value;
                versions.Sort();
            }
        }
    }
}