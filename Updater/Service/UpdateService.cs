using System;
using System.Diagnostics;
using System.IO;
using System.Text;

using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Interfaces;
using Com.QueoMedia.Updater.Manager;
using Com.QueoMedia.Updater.Utilities;

using Updater.Args;

namespace Com.QueoMedia.Updater.Service {
    public enum UpdateStatus {
        OK,
        FAILED,
        UPDATER
    }

    /**
     * Updater service.
     * Updates current installation based on given update type and update operation.
     * Respectively calls specific update services to handle update tasks.
     */

    internal class UpdateService : IUpdateService {
        private readonly FileUpdaterService fileUpdater;
        private readonly UpdaterUpdateService updaterService;
        private readonly ZipUpdaterService zipUpdater;
        private bool updaterUpdaterInProgress;
        private VersionInformation workingVersion;
        private string workingVersionBackupRoot;

        public UpdateService() {
            fileUpdater = new FileUpdaterService();
            fileUpdater.StatusMessageChanged += fileUpdater_StatusMessageChanged;
            fileUpdater.ProgressMessageChanged += fileUpdater_ProgressMessageChanged;
            zipUpdater = new ZipUpdaterService();
            zipUpdater.StatusMessageChanged += fileUpdater_StatusMessageChanged;
            zipUpdater.ProgressMessageChanged += fileUpdater_ProgressMessageChanged;
            updaterService = new UpdaterUpdateService();
            updaterService.StatusMessageChanged += fileUpdater_StatusMessageChanged;
            updaterService.ProgressMessageChanged += fileUpdater_ProgressMessageChanged;
        }

        public delegate void ProgressMessageChangedHandler(object sender, ProgressMessageArgs data);

        public delegate void StatusMessageChangedHandler(object sender, StatusMessageArgs data);

        public event ProgressMessageChangedHandler ProgressMessageChanged;

        public event StatusMessageChangedHandler StatusMessageChanged;

        /**
         * Ctor.
         * Instantiate new file, zip and updater update services.
         */

        /**
         * Delete temporary files.
         * Report status and try to delete update information directory.
         * @see ReportStatus()
         */

        public void DeleteLocalInformations() {
            if (!updaterUpdaterInProgress) {
                ReportStatus(Strings.MESSAGE_DELETE_UPDATE_INFORMATION_FOLDER);
                try {
                    Directory.Delete(Strings.FOLDER_UPDATE_INFORMATION, true);
                } catch {
                }
            }
        }

        public void ReportProgress(int progress) {
            if (StatusMessageChanged != null) {
                ProgressMessageArgs e = new ProgressMessageArgs();
                e.Progress = progress;
                ProgressMessageChanged(this, e);
            }
        }

        public void ReportStatus(string message) {
            if (StatusMessageChanged != null) {
                StatusMessageArgs e = new StatusMessageArgs();
                e.Message = message;
                StatusMessageChanged(this, e);
            }
        }

        public UpdateStatus StartUpdate() {
            ReportStatus(Strings.MESSAGE_CHECKING_TEMP_DOWNLOAD_FOLDER);
            ReportProgress(5);

            // Checking download path. Create if not exists.
            string downloadpath = SettingsManager.Instance.BasePath + Path.DirectorySeparatorChar + Strings.FOLDER_UPDATE_INFORMATION
                                  + Path.DirectorySeparatorChar + Strings.FOLDER_TEMP_DOWNLOAD;
            if (!Directory.Exists(downloadpath)) {
                Directory.CreateDirectory(downloadpath);
            }

            // As long as there anre version in the version list get the last one and continue.
            ReportStatus(Strings.MESSAGE_APPLY_UPDATES);
            ReportProgress(20);
            int versionProgressCounter = 0;
            int maxVersions = VersionsManager.Instance.RemoteVersions.Count;
            while ((workingVersion = VersionsManager.Instance.GetLastVersionFromList()) != null) {
                // Check version specific folder.
                // Create if not exists.
                // Return with update status if failed.
                ReportProgress(20 + ((80/maxVersions)*versionProgressCounter));
                versionProgressCounter++;
                ReportStatus(
                        new StringBuilder().Append(Strings.MESSAGE_WORKING_VERSION_TBC).Append(workingVersion.ResultsInVersion).ToString());
                workingVersionBackupRoot = new StringBuilder()
                        .Append(SettingsManager.Instance.BasePath)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(Strings.FOLDER_UPDATE_INFORMATION)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(workingVersion.ResultsInVersion)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(Strings.FOLDER_VERSION_BACKUP)
                        .ToString();
                try {
                    if (!Directory.Exists(workingVersionBackupRoot)) {
                        Directory.CreateDirectory(workingVersionBackupRoot);
                    }
                } catch {
                    ReportProgress(100);
                    return UpdateStatus.FAILED;
                }

                // Try to create a backup of existing files.
                // Return with update status if failed.
                if (CreateBackup() == UpdateStatus.FAILED) {
                    return UpdateStatus.FAILED;
                }

                // Apply update depending on update type
                UpdateStatus resultingStatus = DoWork();

                // If applying failed try to restore backup.
                if (resultingStatus == UpdateStatus.FAILED) {
                    RestoreBackup();
                    ReportProgress(100);
                    return UpdateStatus.FAILED;
                } else if (resultingStatus == UpdateStatus.UPDATER) {
                    ReportProgress(100);
                    return UpdateStatus.UPDATER;
                }

                // Clear backup or return with update status.
                if (ClearBackup() == UpdateStatus.FAILED) {
                    ReportProgress(100);
                    return UpdateStatus.FAILED;
                }
                // Set current version to resulting version from last update
                VersionsManager.Instance.LocalInformation.CurrentVersion = workingVersion.ResultsInVersion;
                // Save local information.
                VersionsManager.Instance.SaveLocalInformations();
                // Delete last version from list.
                VersionsManager.Instance.DeleteLastVersionFromList();
            }
            // Delete temporary files.
            DeleteLocalInformations();

            // Report status and return.
            ReportStatus(Strings.MESSAGE_UPDATE_COMPLETED_SUCCESSFULLY);
            ReportProgress(100);
            return UpdateStatus.OK;
        }

        private void CheckDownloadDir() {
            string downloaddir = new StringBuilder()
                    .Append(SettingsManager.Instance.BasePath)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_UPDATE_INFORMATION)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_TEMP_DOWNLOAD).ToString();
            ReportStatus(Strings.MESSAGE_CHECKING_TEMP_DOWNLOAD_FOLDER);
            if (!Directory.Exists(downloaddir)) {
                Directory.CreateDirectory(downloaddir);
            }
        }

        /**
         * Clear backup.
         * Clear backup files and folders after successfull update.
         * @return update status
         */

        private UpdateStatus ClearBackup() {
            ReportStatus(Strings.MESSAGE_DELETE_BACKUP);
            try {
                Directory.Delete(workingVersionBackupRoot, true);
            } catch (Exception ex) {
                return UpdateStatus.FAILED;
            }
            return UpdateStatus.OK;
        }

        /**
         * Create backup from existing files based on files in update.
         * @see ReportStatus()
         * @return update status
         */

        private UpdateStatus CreateBackup() {
            ReportStatus(Strings.MESSAGE_CREATING_BACKUP);

            foreach (UpdateFile file in workingVersion.Files) {
                string searchfor = new StringBuilder()
                        .Append(SettingsManager.Instance.BasePath)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(file.DestinationFolder)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(file.Name)
                        .ToString();
                string fileBackupFolder = new StringBuilder()
                        .Append(workingVersionBackupRoot)
                        .Append(Path.DirectorySeparatorChar)
                        .Append(file.DestinationFolder)
                        .ToString();
                try {
                    // Check if file exists in installed version.
                    if (File.Exists(searchfor)) {
                        // If yes, check/create backup path and copy to backup path.
                        if (!Directory.Exists(fileBackupFolder)) {
                            Directory.CreateDirectory(fileBackupFolder);
                        }
                        string filename =
                                new StringBuilder().Append(fileBackupFolder)
                                        .Append(Path.DirectorySeparatorChar)
                                        .Append(file.Name)
                                        .ToString();
                        ReportStatus(new StringBuilder().Append(Strings.MESSAGE_BACKUP_TBC).Append(file).ToString());
                        File.Copy(searchfor, filename, true);
                    }
                } catch (Exception ex) {
                    return UpdateStatus.FAILED;
                }
            }
            return UpdateStatus.OK;
        }

        /**
         * Try to restore backup.
         * @see ReportStatus()
         */

        /**
         * Apply update based on update type.
         * @see CheckDownloadDir()
         * @see ReportStatus()
         * @see StartUpdaterUpdate()
         * @return update status
         */

        private UpdateStatus DoWork() {
            CheckDownloadDir();
            foreach (UpdateFile file in workingVersion.Files) {
                switch (file.UpdateType) {
                        // Do single file update.
                    case UpdateType.FILE:
                        if (file.UpdateOperation == UpdateOperation.ADD) {
                            // Add new or changed file to installation.
                            ReportStatus(
                                    new StringBuilder().Append(Strings.MESSAGE_ADDING_FILE_TBC)
                                            .Append(file.DestinationFolder)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append(file.Name)
                                            .ToString());
                            if (fileUpdater.AddFile(workingVersion.ResultsInVersion.ToString(), file) == UpdateStatus.FAILED) {
                                ReportStatus(Strings.MESSAGE_ADDING_FAILED);
                                return UpdateStatus.FAILED;
                            }
                        } else if (file.UpdateOperation == UpdateOperation.DEL) {
                            // Delete existing file from installation.
                            ReportStatus(
                                    new StringBuilder().Append(Strings.MESSAGE_DELETING_FILE_TBC)
                                            .Append(file.DestinationFolder)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append(file.Name)
                                            .ToString());
                            if (fileUpdater.DelFile(file) == UpdateStatus.FAILED) {
                                ReportStatus(Strings.MESSAGE_DELETING_FAILED);
                                return UpdateStatus.FAILED;
                            }
                        }
                        break;
                        // Do zip update.
                    case UpdateType.ZIP:
                        if (file.UpdateOperation == UpdateOperation.ADD) {
                            // Add new or changed file to installation.
                            ReportStatus(
                                    new StringBuilder().Append(Strings.MESSAGE_ADDING_FILE_TBC)
                                            .Append(file.DestinationFolder)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append(file.Name)
                                            .ToString());
                            if (zipUpdater.AddZip(workingVersion.ResultsInVersion.ToString(), file, workingVersionBackupRoot)
                                == UpdateStatus.FAILED) {
                                ReportStatus(Strings.MESSAGE_ADDING_FAILED);
                                return UpdateStatus.FAILED;
                            }
                        }
                        break;
                        // Do updater update.
                    case UpdateType.UPDATER:
                        if (file.UpdateOperation == UpdateOperation.ADD) {
                            // Start update process like single file but then call the helper application to copy updated files.
                            ReportStatus(
                                    new StringBuilder().Append(Strings.MESSAGE_ADDING_FILE_TBC)
                                            .Append(file.DestinationFolder)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append(file.Name)
                                            .ToString());
                            foreach (UpdateFile ufile in workingVersion.Files) {
                                if (updaterService.AddFile(workingVersion.ResultsInVersion.ToString(), ufile) == UpdateStatus.FAILED) {
                                    ReportStatus(Strings.MESSAGE_ADDING_FAILED);
                                    return UpdateStatus.FAILED;
                                }
                            }
                            string filelistPath =
                                    new StringBuilder().Append(SettingsManager.Instance.BasePath)
                                            .Append(Path.DirectorySeparatorChar)
                                            .Append("filelist.tmp")
                                            .ToString();
                            DeSerializer.Serialize(workingVersion.Files, filelistPath);
                            string downloadDir = new StringBuilder()
                                    .Append(SettingsManager.Instance.DownloadDestination)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(Strings.FOLDER_TEMP_DOWNLOAD).ToString();
                            StartUpdaterUpdate(filelistPath, downloadDir, workingVersionBackupRoot, SettingsManager.Instance.BasePath);
                            updaterUpdaterInProgress = true;
                            return UpdateStatus.UPDATER;
                        }
                        break;
                    default:
                        return UpdateStatus.FAILED;
                        break;
                }
            }
            return UpdateStatus.OK;
        }

        private void RestoreBackup() {
            // Restore all files from backup folder to installation
            ReportStatus(Strings.MESSAGE_RESTORING_BACKUP);
            if (!FilesystemUtilities.CopyDirectory(workingVersionBackupRoot, SettingsManager.Instance.BasePath, true)) {
                SettingsManager.Instance.RestoreBackupFailed = true;
            }
        }

        /**
         * Updating the updater.
         * Start helper application to copy newer updater files over existing one.
         * @param filelistPath temporary file with a list of files to copy
         * @param downloadDir path where new files were downloaded to
         * @param workingVersionBackupRoot backup directory of current version
         * @param basepath base path of current application
         */

        private void StartUpdaterUpdate(string filelistPath, string downloadDir, string workingVersionBackupRoot, string basepath) {
            Process updater = new Process();

            // Switch to /nogiu if application was started without gui.
            string gui = "/gui";
            if (SettingsManager.Instance.UseGUI) {
            } else {
                gui = "/nogui";
            }

            // Set application to start and parameters.
            updater.StartInfo.FileName =
                    new StringBuilder().Append(SettingsManager.Instance.BasePath)
                            .Append(Path.DirectorySeparatorChar)
                            .Append("UpdaterUpdate.exe")
                            .ToString();
            updater.StartInfo.Arguments = new StringBuilder()
                    .Append("\"").Append(filelistPath).Append("\"").Append(" ")
                    .Append("\"").Append(downloadDir).Append("\"").Append(" ")
                    .Append("\"").Append(workingVersionBackupRoot).Append("\"").Append(" ")
                    .Append("\"").Append(basepath).Append("\"").Append(" ")
                    .Append(gui).ToString();

            // Start application
            updater.Start();
        }

        private void fileUpdater_ProgressMessageChanged(object sender, ProgressMessageArgs data) {
            ReportProgress(data.Progress);
        }

        /**
         * Called when status message changed.
         * @see ReportStatus()
         */

        private void fileUpdater_StatusMessageChanged(object sender, StatusMessageArgs data) {
            ReportStatus(data.Message);
        }

        /**
         * Check download directory.
         * Check if download directory exists. Create if not.
         */
    }
}