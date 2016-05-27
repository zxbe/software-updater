using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Manager;
using Com.QueoMedia.Updater.Utilities;

using Updater.Args;

namespace Com.QueoMedia.Updater.Service {
    /**
     * Base updater service
     */

    internal class BaseFileUpdaterService {
        public delegate void ProgressMessageChangedHandler(object sender, ProgressMessageArgs data);

        public delegate void StatusMessageChangedHandler(object sender, StatusMessageArgs data);

        public event ProgressMessageChangedHandler ProgressMessageChanged;

        public event StatusMessageChangedHandler StatusMessageChanged;

        public string CopyFileToLocal(string version, UpdateFile file) {
            // Build remote path.
            string remotePath = new StringBuilder()
                    .Append(VersionsManager.Instance.LocalInformation.UpdateServerUrl)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(version)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(file.DestinationFolder)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(file.Name)
                    .ToString();
            // Build local path.
            string localPath = new StringBuilder()
                    .Append(SettingsManager.Instance.BasePath)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_UPDATE_INFORMATION)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_TEMP_DOWNLOAD)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(file.Name)
                    .ToString();
            // Get new downloader.
            Downloader downloader = new Downloader();

            ReportMessage(
                    new StringBuilder().Append(Strings.MESSAGE_DOWNLOADING_TBC)
                            .Append(remotePath)
                            .Append(" -> ")
                            .Append(localPath)
                            .ToString());

            DownloaderState dlState = DownloaderState.OK;
            // switch download based on protocoll and/or location and load file.
            if (remotePath.Contains(Strings.SEARCHSTRING_HTTP) || remotePath.Contains(Strings.SEARCHSTRING_HTTPS)) {
                dlState = downloader.Download(
                        remotePath,
                        localPath,
                        VersionsManager.Instance.LocalInformation.ServerUser.Name,
                        VersionsManager.Instance.LocalInformation.ServerUser.Pwd,
                        VersionsManager.Instance.LocalInformation.Proxy.Url,
                        VersionsManager.Instance.LocalInformation.Proxy.ProxyUser.Name,
                        VersionsManager.Instance.LocalInformation.Proxy.ProxyUser.Pwd,
                        VersionsManager.Instance.LocalInformation.Proxy.HttpsPort);
            } else if (remotePath.StartsWith(Strings.STARTSTRING_LAN) || remotePath.Contains(Strings.SEARCHSTRING_LOCAL)) {
                dlState = downloader.Download(
                        remotePath,
                        localPath,
                        VersionsManager.Instance.LocalInformation.ServerUser.Name,
                        VersionsManager.Instance.LocalInformation.ServerUser.Pwd);
            }
            while (!downloader.DownloadFinished && dlState == DownloaderState.Running) {
                Thread.Sleep(200);
                Application.DoEvents();
                ReportProgress(downloader.PercentFinished);
            }
            if (dlState == DownloaderState.ErrorDestinationNotAccessible || dlState == DownloaderState.ErrorDownloadFailed) {
                ReportMessage(Strings.MESSAGE_DOWNLOAD_FAILED);
                return "0";
            }
            ReportMessage(Strings.MESSAGE_DOWNLOAD_FINISHED);
            return localPath;
        }

        /**
         * Report message.
         * Report given message to connected handlers.
         * @param message text to send to handlers
         */

        public void ReportMessage(string message) {
            if (StatusMessageChanged != null) {
                StatusMessageArgs e = new StatusMessageArgs();
                e.Message = message;
                StatusMessageChanged(this, e);
            }
        }

        private void ReportProgress(int progress) {
            if (ProgressMessageChanged != null) {
                ProgressMessageArgs e = new ProgressMessageArgs();
                e.Progress = progress;
                ProgressMessageChanged(this, e);
            }
        }

        /**
         * Copy file to local.
         * Copy file via http, https or from lan or local to given local destination.
         * @param version version currently working on
         * @param file infromation about file to load
         * @see ReportMessage()
         * @result string oath to loaded file
         */
    }
}