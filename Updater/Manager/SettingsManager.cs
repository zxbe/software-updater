using System.IO;
using System.Text;

using Com.QueoMedia.Updater.Interfaces;
using Com.QueoMedia.Updater.Utilities;

namespace Com.QueoMedia.Updater.Manager {
    /**
     * Holds various pathes and application states to be accessible from everywhere.
     */

    internal class SettingsManager : ISettingsManager {
        // Instanzierung
        private static readonly SettingsManager instance = new SettingsManager();
        private readonly string _basePath;
        private readonly string _downloadDestination;

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        private bool _continueUpdate;
        private ErrorPosition _errorPosition;
        private bool _noNewVersions;
        private bool _restoreBackupFailed;
        private bool _useGUI;
        private bool _showProgress;

        static SettingsManager() {
        }

        private SettingsManager() {
            _restoreBackupFailed = false;
            _basePath = Path.GetFullPath(".");
            _downloadDestination = new StringBuilder()
                    .Append(_basePath)
                    .Append(Path.DirectorySeparatorChar)
                    .Append(Strings.FOLDER_UPDATE_INFORMATION)
                    .ToString();
        }

        public static SettingsManager Instance {
            get { return instance; }
        }
        public string BasePath {
            get { return _basePath; }
        }

        public bool ContinueUpdate {
            get { return _continueUpdate; }
            set { _continueUpdate = value; }
        }

        public string DownloadDestination {
            get { return _downloadDestination; }
        }
        public ErrorPosition ErrorPosition {
            get { return _errorPosition; }
            set { _errorPosition = value; }
        }

        public bool NoNewVersions {
            get { return _noNewVersions; }
            set { _noNewVersions = value; }
        }

        /// <summary>
        /// Liefert oder setzt ob das Backup nach einerm Fehler wieder hergestellt werden soll.
        /// </summary>
        public bool RestoreBackupFailed {
            get { return _restoreBackupFailed; }
            set { _restoreBackupFailed = value; }
        }

        /// <summary>
        /// Liefert oder setzt ob die ZU des Updaters gezeigt werden soll.
        /// </summary>
        public bool UseGUI {
            get { return _useGUI; }
            set { _useGUI = value; }
        }

        /// <summary>
        /// Liefert oder setzt ob der Fortschritt gezeigt werden soll
        /// </summary>
        public bool ShowProgress {
            get { return _showProgress; }
            set { _showProgress = value; }
        }
    }
}