using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Utilities;

namespace UpdateServerManager2010Services.Implementation {
    public class VersionInformationService: IVersionInformationService {
        #region Implementation of IVersionInformationService

        public VersionInformation GetVersionInformationFromFile(string filePath)
        {
            return DeSerializer.Deserializer<VersionInformation>(filePath);
        }

        public void GenerateFileLists(VersionInformation source, out IList<string> changedFiles, out IList<string> deletedFiles)
        {
            IList<string> changed = new List<string>();
            IList<string> deleted = new List<string>();
            StringBuilder entryBuilder;
            foreach (UpdateFile file in source.Files.Where(file => file.UpdateOperation == UpdateOperation.ADD))
            {
                entryBuilder = new StringBuilder();
                entryBuilder.Append(GetBaseString(file.UpdateType));
                entryBuilder.Append(file.DestinationFolder);
                entryBuilder.Append(Path.DirectorySeparatorChar);
                entryBuilder.Append(file.Name);
                changed.Add(entryBuilder.ToString());
            }

            foreach (UpdateFile file in source.Files.Where(file => file.UpdateOperation == UpdateOperation.DEL)) {
                entryBuilder = new StringBuilder();
                entryBuilder.Append(GetBaseString(file.UpdateType));
                entryBuilder.Append(file.DestinationFolder);
                entryBuilder.Append(Path.DirectorySeparatorChar);
                entryBuilder.Append(file.Name);
                deleted.Add(entryBuilder.ToString());
            }
            changedFiles = changed;
            deletedFiles = deleted;
        }

        public IList<string> GenerateFileOperationsList(VersionInformation source)
        {
            IList<string> result = new List<string>();
            foreach (UpdateFile file in source.Files)
            {
                result.Add(file.UpdateType.ToString() + " - " + file.UpdateOperation.ToString());
                result.Add(file.DestinationFolder + Path.DirectorySeparatorChar + file.Name);
            }
            return result;
        }

        private static string GetBaseString(UpdateType updateType)
        {
            switch (updateType) {
                case UpdateType.FILE:
                    return "Datei: ";
                case UpdateType.MSP:
                    return "MS Update: ";
                case UpdateType.SQL:
                    return "SQL: ";
                case UpdateType.UPDATER:
                    return "Updater: ";
                case UpdateType.ZIP:
                    return "ZIP: ";
                default:
                    return "";
            }
        }

        #endregion
    }
}
