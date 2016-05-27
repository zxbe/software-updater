using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Interfaces;
using Com.QueoMedia.Updater.Utilities;

namespace Com.QueoMedia.Updater.Manager {
    /**
     * Versions manager.
     * Handles local and remote version information.
     */

    internal class VersionsManager : IVersionsManager {
        // Instanzierung
        private static readonly VersionsManager instance = new VersionsManager();
        private bool _gotLocal;
        private bool _gotOverview;
        private LocalInformation _localInformation;
        private Overview _overview;
        private List<VersionInformation> _remoteVersions = new List<VersionInformation>();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static VersionsManager() {
        }

        private VersionsManager() {
        }

        public static VersionsManager Instance {
            get { return instance; }
        }

        // Gets and sets local version information.
        public LocalInformation LocalInformation {
            get { return _localInformation; }
            set { _localInformation = value; }
        }
        public Overview Overview {
            get { return _overview; }
            set { _overview = value; }
        }
        public List<VersionInformation> RemoteVersions {
            get { return _remoteVersions; }
            set { _remoteVersions = value; }
        }

        /**
         * Gets last version from remote versions.
         * @return last version information from list
         */

        /**
         * Deletes last version from list.
         */

        public void DeleteLastVersionFromList() {
            if (_remoteVersions.Count >= 1) {
                _remoteVersions.RemoveAt(_remoteVersions.Count - 1);
            }
        }

        public VersionInformation GetLastVersionFromList() {
            if (_remoteVersions.Count >= 1) {
                return _remoteVersions[_remoteVersions.Count - 1];
            } else {
                return null;
            }
        }

        /**
         * Gets local version information.
         */

        public void GetLocalData() {
            SettingsManager.Instance.ContinueUpdate = false;
            SettingsManager.Instance.ErrorPosition = ErrorPosition.Localinformation;
            try {
                _localInformation = DeSerializer.Deserializer<LocalInformation>(Path.GetFullPath(Strings.FILE_LOCAL_INFORMATION));
                if (LocalInformation.UpdateServerUrl != "" && LocalInformation.UpdateServerUrl != null) {
                    _gotLocal = true;
                    SettingsManager.Instance.ContinueUpdate = true;
                }
            } catch {
            }
        }

        /**
         * Download overview data.
         * @see WebDownload()
         * @see LocalDownload()
         */

        public void GetOverview() {
            if (_gotLocal) {
                SettingsManager.Instance.ContinueUpdate = false;
                SettingsManager.Instance.ErrorPosition = ErrorPosition.Overview;
                bool finishedDownloadOK = false;

                // Download overview via HTTP or HTTPS.
                if (LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_HTTP)
                    || LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_HTTPS)) {
                    // Instantiate new downloader.
                    Downloader overviewdownloader = new Downloader();
                    DownloaderState state = WebDownload(
                            overviewdownloader,
                            new StringBuilder().Append(LocalInformation.UpdateServerUrl).Append(Strings.FILE_OVERVIEW).ToString(),
                            new StringBuilder().Append(Strings.FOLDER_UPDATE_INFORMATION)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_OVERVIEW)
                                    .ToString()
                            );
                    while (!overviewdownloader.DownloadFinished) {
                        Thread.Sleep(100);
                        Application.DoEvents();
                    }
                    if (overviewdownloader.ErrorMessage != null) {
                        if (SettingsManager.Instance.UseGUI) {
                            MessageBox.Show(overviewdownloader.ErrorMessage);
                        }
                    } else {
                        finishedDownloadOK = true;
                    }

                    // Download overview from LAN or local device.
                } else if (LocalInformation.UpdateServerUrl.StartsWith(Strings.STARTSTRING_LAN)
                           || LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_LOCAL)) {
                    // use network or local path to get information
                    Downloader overviewdownloader = new Downloader();
                    DownloaderState state = overviewdownloader.Download(
                            new StringBuilder().Append(LocalInformation.UpdateServerUrl)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_OVERVIEW)
                                    .ToString(),
                            new StringBuilder().Append(Strings.FOLDER_UPDATE_INFORMATION)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_OVERVIEW)
                                    .ToString(),
                            null,
                            null);
                    if (overviewdownloader.ErrorMessage != null) {
                        if (SettingsManager.Instance.UseGUI) {
                            MessageBox.Show(overviewdownloader.ErrorMessage);
                        }
                    } else {
                        finishedDownloadOK = true;
                    }
                }

                // Try to deserialize overview data if download finished successfully.
                // Else return from GetOverview().
                if (finishedDownloadOK) {
                    try {
                        _overview = DeSerializer.Deserializer<Overview>(
                                new StringBuilder().Append(Strings.FOLDER_UPDATE_INFORMATION)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(Strings.FILE_OVERVIEW)
                                        .ToString());
                    } catch {
                        return;
                    }
                }

                // Continues update if version information found in overview.
                if (_overview != null) {
                    if (_overview.Versions.Count > 0) {
                        _gotOverview = true;
                        SettingsManager.Instance.ContinueUpdate = true;
                    }
                }
            }
        }

        /**
         * Get detailed remote version information.
         * Recursivly get all remote version information from newest avaiable down to current version.
         * Depends on applies to value in version information.
         * @param version newest version number
         */

        public void GetVersions(string version) {
            // If fetching local and overview informations finished successfully continue with update.
            if (_gotLocal && _gotOverview) {
                SettingsManager.Instance.ContinueUpdate = false;
                SettingsManager.Instance.ErrorPosition = ErrorPosition.Remoteinformation;

                // Check if temporary folder for version exists. If not, create it.
                if (Directory.Exists(Path.GetFullPath(
                        new StringBuilder().Append(Strings.FOLDER_UPDATE_INFORMATION)
                                .Append(Path.DirectorySeparatorChar)
                                .Append(version)
                                .ToString()))) {
                } else {
                    Directory.CreateDirectory(Path.GetFullPath(
                            new StringBuilder().Append(Strings.FOLDER_UPDATE_INFORMATION)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(version)
                                    .ToString()));
                }

                bool finishedDownloadOK = false;

                // Download via HTTP or HTTPS.
                if (LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_HTTP)
                    || LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_HTTPS)) {
                    Downloader overviewdownloader = new Downloader();
                    DownloaderState state = WebDownload(overviewdownloader,
                            new StringBuilder()
                                    .Append(LocalInformation.UpdateServerUrl)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(version)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_VERSION_INFORMATION)
                                    .ToString(),
                            new StringBuilder()
                                    .Append(Strings.FOLDER_UPDATE_INFORMATION)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(version)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_VERSION_INFORMATION)
                                    .ToString());
                    while (!overviewdownloader.DownloadFinished) {
                        Thread.Sleep(100);
                        Application.DoEvents();
                    }

                    if (overviewdownloader.ErrorMessage != null) {
                        MessageBox.Show(overviewdownloader.ErrorMessage);
                    } else {
                        finishedDownloadOK = true;
                    }

                    // Download from LAN or local device.
                } else if (LocalInformation.UpdateServerUrl.StartsWith(Strings.STARTSTRING_LAN)
                           || LocalInformation.UpdateServerUrl.Contains(Strings.SEARCHSTRING_LOCAL)) {
                    // use network or local path to get information
                    Downloader overviewdownloader = new Downloader();
                    DownloaderState state = overviewdownloader.Download(
                            new StringBuilder()
                                    .Append(LocalInformation.UpdateServerUrl)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(version)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_VERSION_INFORMATION)
                                    .ToString(),
                            new StringBuilder()
                                    .Append(Strings.FOLDER_UPDATE_INFORMATION)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(version)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FILE_VERSION_INFORMATION)
                                    .ToString(),
                            null,
                            null);
                    while (!overviewdownloader.DownloadFinished) {
                        Thread.Sleep(100);
                        Application.DoEvents();
                    }

                    if (overviewdownloader.ErrorMessage != null) {
                        MessageBox.Show(overviewdownloader.ErrorMessage);
                    } else {
                        finishedDownloadOK = true;
                    }
                }

                // If download finished try to deserialize information.
                if (finishedDownloadOK) {
                    try {
                        _remoteVersions.Add(DeSerializer.Deserializer<VersionInformation>(
                                new StringBuilder()
                                        .Append(Strings.FOLDER_UPDATE_INFORMATION)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(version)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(Strings.FILE_VERSION_INFORMATION)
                                        .ToString()));
                        SettingsManager.Instance.ContinueUpdate = true;
                    } catch {
                        return;
                    }
                }

                // Check if last downloaded version matches local installation. If not, get next previous version.
                if (_remoteVersions[_remoteVersions.Count - 1].AppliesToVersion.ToString() == _localInformation.CurrentVersion.ToString()
                    || !SettingsManager.Instance.ContinueUpdate) {
                } else {
                    GetVersions(_remoteVersions[_remoteVersions.Count - 1].AppliesToVersion.ToString());
                }
            }
        }

        /**
         * Saves local version information to file.
         */

        public void SaveLocalInformations() {
            DeSerializer.Serialize(_localInformation, Strings.FILE_LOCAL_INFORMATION);
        }

        /**
         * Initiates web download.
         * @param downloader Downloader to run
         * @param from Source url to download from
         * @param to Destination path
         * @return downloader state
         */

        public DownloaderState WebDownload(Downloader downloader, string from, string to) {
            string user = null;
            string pwd = null;
            string proxyurl = null;
            string proxyuser = null;
            string proxypwd = null;
            string proxyport = null;

            if (_localInformation.ServerUser != null) {
                if (_localInformation.ServerUser.Name != null) {
                    user = _localInformation.ServerUser.Name;
                }
                if (_localInformation.ServerUser.Pwd != null) {
                    pwd = _localInformation.ServerUser.Pwd;
                }
            }
            if (_localInformation.Proxy != null) {
                if (_localInformation.Proxy.Url != null) {
                    proxyurl = _localInformation.Proxy.Url;
                }
                if (_localInformation.Proxy.HttpsPort != null) {
                    proxyport = _localInformation.Proxy.HttpsPort;
                }
                if (_localInformation.Proxy.ProxyUser != null) {
                    if (_localInformation.Proxy.ProxyUser.Name != null) {
                        proxyuser = _localInformation.Proxy.ProxyUser.Name;
                    }
                    if (_localInformation.Proxy.ProxyUser.Pwd != null) {
                        proxypwd = _localInformation.Proxy.ProxyUser.Pwd;
                    }
                }
            }
            return downloader.Download(from, to, user, pwd, proxyurl, proxyuser, proxypwd, proxyport);
        }
    }
}