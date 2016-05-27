using System.Collections.Generic;
using System.IO;
using System.Linq;
using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Utilities;

namespace UpdateServerManager2010Services.Implementation {
    public class OverviewService : IOverviewService{

        private const string OverviewFileName = "overview.xml";

        #region Implementation of IOverviewService

        public IList<VersionNumber> GetVersionsFromOverview(Overview overview)
        {
            return overview.Versions;
        }

        public Overview GetOverviewFromFile(string overviewFile)
        {
            return DeSerializer.Deserializer<Overview>(overviewFile);
        }

        public bool ExistsInOverview(Overview source, VersionNumber versionToCheck)
        {
            return source.Versions.Any(version => version.ToString() == versionToCheck.ToString());
        }

        public void UpdateOverviewFile(string serverPath, Overview newOverview)
        {
            DeSerializer.Serialize(newOverview, serverPath + Path.DirectorySeparatorChar + OverviewFileName);
        }

        public void InitServerFolder(string serverFolder, string serverName)
        {
            // assemble complete update server path
            string completeFolder = serverFolder + Path.DirectorySeparatorChar + serverName;

            // generate new overview
            Overview overview = new Overview {Versions = new List<VersionNumber>()};
            VersionNumber baseVersion = new VersionNumber("0.0.0.1");
            overview.Versions.Add(baseVersion);
            DeSerializer.Serialize(overview, completeFolder + Path.DirectorySeparatorChar + "overview.xml");

            // create folder for base version
            Directory.CreateDirectory(completeFolder + Path.DirectorySeparatorChar + "0.0.0.1");

            // generate new info.xml for base version
            VersionInformation baseInfo = new VersionInformation();
            VersionNumber appliesTo = new VersionNumber("0.0.0.0");
            baseInfo.AppliesToVersion = appliesTo;
            baseInfo.ResultsInVersion = baseVersion;
            baseInfo.Files = new List<UpdateFile>();
            DeSerializer.Serialize(baseInfo, completeFolder + Path.DirectorySeparatorChar + "0.0.0.1" + Path.DirectorySeparatorChar + "info.xml");
        }

        #endregion
    }
}
