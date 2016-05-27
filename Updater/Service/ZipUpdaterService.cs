using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Manager;
using Com.QueoMedia.Updater.Utilities;

using ICSharpCode.SharpZipLib.Zip;

namespace Com.QueoMedia.Updater.Service {
    /**
     * Zip updater service.
     * Apply update from within a zip file.
     */

    internal class ZipUpdaterService : BaseFileUpdaterService {
        /**
         * Add files from zip.
         * @param version current working version
         * @param file information about update file
         * @param currentBackup path to current backup folder
         * @see ReportMessage()
         * @return update status
         */

        public UpdateStatus AddZip(string version, UpdateFile file, string currentBackup) {
            #region Download file

            // get file from remote location
            string localPath = base.CopyFileToLocal(version, file);
            if (localPath == "0") {
                return UpdateStatus.FAILED;
            }

            #endregion

            #region Extract zip and get content

            // extract downloaded files and get content of zip file
            FastZip zip = new FastZip();
            try {
                ReportMessage(Strings.MESSAGE_EXTRACTING_ZIP);
                zip.ExtractZip(localPath, Path.GetDirectoryName(localPath), "");
            } catch (Exception ex) {
                ReportMessage(ex.Message);
                return UpdateStatus.FAILED;
            }
            ZipInputStream zipstream = new ZipInputStream(File.OpenRead(localPath));
            List<ZipEntry> zipcontent = new List<ZipEntry>();
            ZipEntry entry = null;
            while ((entry = zipstream.GetNextEntry()) != null) {
                zipcontent.Add(entry);
            }
            zipstream.Close();
            File.Delete(localPath);

            #endregion

            #region Build backup

            // Add files and folders found in zip and installed version to backup folder
            // build tempdownload path
            string downloadroot = new StringBuilder()
                    .Append(SettingsManager.Instance.DownloadDestination)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_TEMP_DOWNLOAD).ToString();
            string progroot = SettingsManager.Instance.BasePath;

            // go through all elements of extracted zip
            // go through all directories
            foreach (ZipEntry zipEntry in zipcontent) {
                // if found on onstall -> add to backup with install path
                if (zipEntry.IsDirectory) {
                    if (
                            Directory.Exists(
                                    new StringBuilder().Append(progroot)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append(zipEntry.Name)
                                            .ToString())) {
                        // create directory in backup
                        string tempDirName =
                                new StringBuilder().Append(currentBackup)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(zipEntry.Name)
                                        .ToString();
                        if (!Directory.Exists(tempDirName)) {
                            Directory.CreateDirectory(tempDirName);
                        }
                    }
                }
            }
            // go through all files
            foreach (ZipEntry zipEntry in zipcontent) {
                if (zipEntry.IsFile) {
                    string tempFileName =
                            new StringBuilder().Append(progroot).Append(Path.DirectorySeparatorChar).Append(zipEntry.Name).ToString();
                    if (File.Exists(tempFileName)) {
                        File.Copy(tempFileName,
                                new StringBuilder().Append(currentBackup)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(zipEntry.Name)
                                        .ToString(),
                                true);
                    }
                }
            }

            #endregion

            #region Copy extracted files to final location

            // copy files to installed version
            try {
                FilesystemUtilities.CopyDirectory(downloadroot, progroot, true);
                //File.Copy(localPath, finalPath);
            } catch {
                return UpdateStatus.FAILED;
            }
            Directory.Delete(Path.GetDirectoryName(localPath), true);
            Directory.CreateDirectory(SettingsManager.Instance.BasePath + Path.DirectorySeparatorChar + Strings.FOLDER_UPDATE_INFORMATION
                                      + Path.DirectorySeparatorChar + Strings.FOLDER_TEMP_DOWNLOAD);
            return UpdateStatus.OK;

            #endregion
        }
    }
}