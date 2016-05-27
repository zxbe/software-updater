using System;
using System.IO;
using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services.Implementation {
    public class FileSystemService : IFileSystemService {
        #region Implementation of IFileSystemService

        public bool IsFileInFolder(string path, string file) {
            return path.EndsWith(Path.DirectorySeparatorChar.ToString())
                ? File.Exists(path + file)
                : File.Exists(path + Path.DirectorySeparatorChar + file);
        }

        public string GetCompletePath(string path, string file) {
            return path.EndsWith(Path.DirectorySeparatorChar.ToString())
                       ? path + file
                       : path + Path.DirectorySeparatorChar + file;
        }

        public string GenerateNewFolderForVersion(VersionNumber version, string server)
        {
            string path = server + Path.DirectorySeparatorChar + version;
            Directory.CreateDirectory(path);
            return path;
        }

        /// <summary>
        /// Prüft ob ein Ordner mit gegebenen Namen bereits im gegebenen Ordner existiert.
        /// </summary>
        /// <param name="foldername">Der name des zu prüfenden Ordners.</param>
        /// <param name="path">Der Pfad des Ordners in dem geprüft werden soll.</param>
        public bool FolderExistsInPath(string foldername, string path)
        {
            return Directory.Exists(path + Path.DirectorySeparatorChar + foldername);
        }

        /// <summary>
        /// Prüft ob der aktuelle Benutzer im gegebenen Orner Schreibberechtigung besitzt.
        /// </summary>
        /// <param name="folderPath">Pfad des zu prüfenden Ordners.</param>
        public bool UserHasWritePermissionToFolder(string folderPath)
        {
            bool result = true;
            string testDir = folderPath + Path.DirectorySeparatorChar + "_";
            try {
                Directory.CreateDirectory(testDir);
            } catch (UnauthorizedAccessException uaex)
            {
                result = false;
            }

            if (result)
                Directory.Delete(testDir);
            return result;
        }

        public void DeleteServerFolder(string serverFolder, string serverName)
        {
            Directory.Delete(serverFolder + Path.DirectorySeparatorChar + serverName, true);
        }

        public void GenerateServerFolder(string serverFolder, string serverName)
        {
            Directory.CreateDirectory(serverFolder + Path.DirectorySeparatorChar + serverName);
        }

        public string GetServerPath(string serverFolder, string serverName)
        {
            return serverFolder + Path.DirectorySeparatorChar + serverName;
        }

        #endregion
    }
}
