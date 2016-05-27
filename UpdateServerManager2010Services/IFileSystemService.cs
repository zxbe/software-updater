using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services
{
    public interface IFileSystemService
    {
        bool IsFileInFolder(string path, string file);

        string GetCompletePath(string path, string file);

        string GenerateNewFolderForVersion(VersionNumber version, string server);

        /// <summary>
        /// Pr�ft ob ein Ordner mit gegebenen Namen bereits im gegebenen Ordner existiert.
        /// </summary>
        /// <param name="foldername">Der name des zu pr�fenden Ordners.</param>
        /// <param name="path">Der Pfad des Ordners in dem gepr�ft werden soll.</param>
        bool FolderExistsInPath(string foldername, string path);

        /// <summary>
        /// Pr�ft ob der aktuelle Benutzer im gegebenen Orner Schreibberechtigung besitzt.
        /// </summary>
        /// <param name="folderPath">Pfad des zu pr�fenden Ordners.</param>
        bool UserHasWritePermissionToFolder(string folderPath);

        void DeleteServerFolder(string serverFolder, string serverName);

        void GenerateServerFolder(string serverFolder, string serverName);

        string GetServerPath(string serverFolder, string serverName);
    }
}