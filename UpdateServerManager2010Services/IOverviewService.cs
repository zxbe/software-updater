using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services
{
    public interface IOverviewService
    {
        IList<VersionNumber> GetVersionsFromOverview(Overview overview);

        Overview GetOverviewFromFile(string overviewFile);

        bool ExistsInOverview(Overview source, VersionNumber versionToCheck);

        void UpdateOverviewFile(string serverPath, Overview newOverview);

        void InitServerFolder(string serverFolder, string serverName);
    }
}