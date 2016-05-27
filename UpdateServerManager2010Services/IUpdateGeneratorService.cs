using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services
{
    public interface IUpdateGeneratorService
    {
        string GenerateUpdate(string workFolder, string zipDestination, VersionNumber appliesTo, VersionNumber resultsIn,
                              IList<UpdateFile> files);
    }
}