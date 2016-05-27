using System;
using System.IO;
using System.Text;

using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Manager;

namespace Com.QueoMedia.Updater.Service {
    /**
     * File updater service.
     * Add or delete a single file.
     */

    internal class FileUpdaterService : BaseFileUpdaterService {
        /**
         * Add file.
         * Add a single file.
         * @param version current version number
         * @param file informations about file to update
         * @see CopyFileToLocal()
         * @see ReportMessage()
         * @return update status
         */

        public UpdateStatus AddFile(string version, UpdateFile file) {
            // Get file from remote location.
            string localPath = base.CopyFileToLocal(version, file);
            if (localPath == "0") {
                return UpdateStatus.FAILED;
            }
            // Copy file to installed version.
            if (!File.Exists(localPath)) {
                return UpdateStatus.FAILED;
            }
            try {
                string finalPath = new StringBuilder()
                        .Append(SettingsManager.Instance.BasePath)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(file.DestinationFolder)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(file.Name)
                        .ToString();
                if (!Directory.Exists(Path.GetDirectoryName(finalPath))) {
                    Directory.CreateDirectory(Path.GetDirectoryName(finalPath));
                }
                File.Copy(localPath, finalPath, true);
            } catch (Exception ex) {
                ReportMessage(ex.Message);
                return UpdateStatus.FAILED;
            }
            // Delete from download directory.
            File.Delete(localPath);
            return UpdateStatus.OK;
        }

        /**
         * Delete file.
         * Delete a single file.
         * @param file informations about the file to delete
         * @see ReportMessage()
         * @return update status
         */

        public UpdateStatus DelFile(UpdateFile file) {
            #region Build file path

            string filePath = new StringBuilder()
                    .Append(SettingsManager.Instance.BasePath)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(file.DestinationFolder)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(file.Name)
                    .ToString();

            #endregion

            #region Try to delete file

            try {
                if (File.Exists(filePath)) {
                    File.Delete(filePath);
                }
            } catch (Exception ex) {
                ReportMessage(ex.Message);
                return UpdateStatus.FAILED;
            }

            #endregion

            #region Try to delete directory if empty

            // try to delete directory if empty
            try {
                string path = Path.GetDirectoryName(filePath);
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                if (dirs.Length == 0 && files.Length == 0) {
                    Directory.Delete(path);
                }
            } catch (Exception ex) {
                ReportMessage(ex.Message);
                return UpdateStatus.FAILED;
            }

            #endregion

            return UpdateStatus.OK;
        }
    }
}