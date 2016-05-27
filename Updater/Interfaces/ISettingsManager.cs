using Com.QueoMedia.Updater.Manager;

namespace Com.QueoMedia.Updater.Interfaces {
    /**
     * Interface for settings manager.
     */

    internal interface ISettingsManager {
        string BasePath { get; }

        bool ContinueUpdate { get; set; }

        string DownloadDestination { get; }

        ErrorPosition ErrorPosition { get; set; }

        bool NoNewVersions { get; set; }

        bool RestoreBackupFailed { get; set; }

        bool UseGUI { get; set; }
    }
}