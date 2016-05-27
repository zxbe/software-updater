using System.Collections.Generic;

using Com.QueoMedia.Updater.Data;

namespace Com.QueoMedia.Updater.Interfaces {
    /**
     * Interface for VersionsManager.
     */

    internal interface IVersionsManager {
        LocalInformation LocalInformation { get; set; }

        Overview Overview { get; set; }

        List<VersionInformation> RemoteVersions { get; set; }

        VersionInformation GetLastVersionFromList();

        void GetLocalData();

        void GetOverview();

        void GetVersions(string version);
    }
}