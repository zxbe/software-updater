using System.Collections.Generic;

namespace Com.QueoMedia.Updater.Data {
    public class VersionInformation {
        private VersionNumber appliesToVersion;
        private List<UpdateFile> files;
        private VersionNumber resultsInVersion;

        public VersionNumber AppliesToVersion {
            get { return appliesToVersion; }
            set { appliesToVersion = value; }
        }

        public List<UpdateFile> Files {
            get { return files; }
            set { files = value; }
        }
        public VersionNumber ResultsInVersion {
            get { return resultsInVersion; }
            set { resultsInVersion = value; }
        }
    }
}