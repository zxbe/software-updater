using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services
{
    public interface IVersionInformationService
    {
        VersionInformation GetVersionInformationFromFile(string filePath);

        void GenerateFileLists(VersionInformation source, out IList<string> changedFiles, out IList<string> deletedFiles);

        IList<string> GenerateFileOperationsList(VersionInformation source);
    }
}