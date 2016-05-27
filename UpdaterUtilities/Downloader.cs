using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace Com.QueoMedia.Updater.Utilities {
    public class Downloader {
        private string _destination;
        private bool _downloadFinished;
        private string _errorMessage;
        private int _percentFinished;
        private bool _useHttps;
        private bool _useProxy;

        public bool DownloadFinished {
            get { return _downloadFinished; }
        }
        public string ErrorMessage {
            get { return _errorMessage; }
        }

        public int PercentFinished {
            get { return _percentFinished; }
        }

        /// <summary>
        ///     Downloads a file to a given path
        /// </summary>
        /// <param name="url">Url of the file to download</param>
        /// <param name="destination">Download to</param>
        /// <param name="user">(opt) Username for https access</param>
        /// <param name="pwd">(opt) Passwort for https access</param>
        /// <param name="proxyurl">(opt) Url of proxyserver</param>
        /// <param name="proxyuser">(opt) User for proxyserver</param>
        /// <param name="proxypwd">(opt) Passwort for proxyserver</param>
        /// <returns></returns>
        /**
         * Download.
         * Downloads a file to a given path.
         * @param url Url of the file to download
         * @param destination Download destination path
         * @param user (opt) Username for https access
         * @param pwd (opt) Passwort for https access
         * @param proxyurl (opt) Url of proxyserver
         * @param proxyuser (opt) User for proxyserver
         * @param proxyppwd (opt) Passwort for proxyserver
         * @see CheckWriteAccess
         * @return downloader state
         */
        public DownloaderState Download(string url, string destination, string user, string pwd, string proxyurl, string proxyuser,
                string proxypwd, string proxyport) {
            // try to check if destination folder exists and is writeable
            // if it does not exist create new folder from given destination
            _destination = Path.GetFullPath(@destination);

            // Check write access of destination directory.
            DownloaderState resultAccessChecker = CheckWriteAccess();
            if (resultAccessChecker == DownloaderState.ErrorDestinationNotAccessible) {
                return resultAccessChecker;
            }

            // Check url.
            if (url.StartsWith(Strings.STARTSTRING_HTTPS)) {
                _useHttps = true;
            } else {
                _useHttps = false;
            }

            // Check proxy given.
            if (proxyurl != null && proxyurl != "") {
                _useProxy = true;
            } else {
                _useProxy = false;
            }

            // Get new web client.
            WebClient client = new WebClient();

            // Generate fake zertificate for https.
            if (_useHttps) {
                client.Credentials = new NetworkCredential(user, pwd);

                ServicePointManager.ServerCertificateValidationCallback += delegate {
                    return true;
                };
            }
            // Generate new proxy.
            if (_useProxy) {
                if (_useHttps) {
                    client.Proxy = new WebProxy(proxyurl, Convert.ToInt32(proxyport));
                    if (proxyuser != null && proxypwd != null) {
                        client.Proxy.Credentials = new NetworkCredential(proxyuser, proxypwd);
                    }
                } else {
                    client.Proxy = new WebProxy(proxyurl, true);
                }
            }

            // Start download.
            try {
                client.DownloadProgressChanged += client_DownloadProgressChanged;
                client.DownloadFileCompleted += client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(url), destination);
            } catch (Exception ex) {
                _errorMessage = "Http/Https: " + ex.Message;
                return DownloaderState.ErrorDownloadFailed;
            }

            return DownloaderState.Running;
        }

        /**
         * Download.
         * Downloads a file to a given path.
         * @param networkPath Path of the file to download within LAN
         * @param destination Path to download file to
         * @param user Username for authentication
         * @param pwd Password for authentication
         * @return downloader state
         */

        public DownloaderState Download(string networkPath, string destination, string user, string pwd) {
            _destination = Path.GetFullPath(@destination);

            CheckWriteAccess();

            try {
                File.Copy(networkPath, destination, true);
            } catch (Exception ex) {
                _errorMessage = "Network/Local: " + ex.Message;
                return DownloaderState.ErrorDownloadFailed;
            }
            _downloadFinished = true;
            return DownloaderState.OK;
        }

        /**
         * Check write acces.
         * Checks write access on destination directory.
         * @returns downloader state
         */

        private DownloaderState CheckWriteAccess() {
            FileIOPermission w = new FileIOPermission(FileIOPermissionAccess.Write, _destination);
            FileIOPermission a = new FileIOPermission(FileIOPermissionAccess.Append, _destination);
            try {
                w.Demand();
                a.Demand();
            } catch (SecurityException) {
                return DownloaderState.ErrorDestinationNotAccessible;
            } catch (Exception) {
                return DownloaderState.ErrorDestinationNotAccessible;
            }
            return DownloaderState.OK;
        }

        /**
         * Gets called when download progress changed.
         */

        /**
         * Gets called when download finished.
         */

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            // If download was canceled or if there was an error try to delete downloaded file.
            if (e.Cancelled || e.Error != null) {
                // try to delete downloaded file
                try {
                    File.Delete(_destination);
                } catch {
                }

                // get error message
                _errorMessage = "Download canceled: " + e.Error.Message;

                if (e.Error.InnerException != null) {
                    new StringBuilder().Append(_errorMessage)
                            .Append(Strings.CommonMessageSeperator)
                            .Append(e.Error.InnerException.Message)
                            .ToString();
                }
            }
            _downloadFinished = true;
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            _percentFinished = e.ProgressPercentage;
        }
    }
}