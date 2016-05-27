using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Com.QueoMedia.Updater.Gui;
using Com.QueoMedia.Updater.Gui.Forms;
using Com.QueoMedia.Updater.Interfaces;
using Com.QueoMedia.Updater.Manager;
using Com.QueoMedia.Updater.Service;
using Com.QueoMedia.Updater.Utilities;

using log4net;

using Updater.Args;

using UpdaterProgressScreen;
using UpdaterProgressScreen.ViewModels;

namespace Com.QueoMedia.Updater.Controller {
    /**
     * Main update controller.
     * Instanziates various managers, gui interfaces and the update service.
     */

    public class MainUpdaterController : IMainUpdaterController {
        private static readonly ILog _log = LogManager.GetLogger(typeof(MainUpdaterController));
        private readonly UpdateService _userv;
        private IDiff _differences;
        private IProgress _progress;
        private ProgressScreen _progressScreen;
        private IProgressScreenViewModel _progressScreenViewModel;
        private UpdateStatus _updateResult;
        private IVersionsManager _verManager;

        /// <summary>
        ///     Erstellt eine neue Instanz des Controller
        /// </summary>
        /// <param name="useGui"></param>
        /// <param name="showProgress"></param>
        public MainUpdaterController(bool useGui, bool showProgress) {
            // Writes gui usage to settings manager
            SettingsManager.Instance.UseGUI = useGui;
            SettingsManager.Instance.ShowProgress = showProgress;

            WriteLog(new StringBuilder().Append(Strings.MESSAGE_USE_GUI_TBC).Append(useGui.ToString()).ToString());

            // instanziates new updateService
            _userv = new UpdateService();
            _userv.StatusMessageChanged += Userv_StatusMessageChanged;
            _userv.ProgressMessageChanged += userv_ProgressMessageChanged;
        }

        public event EventHandler RequestExit;

        /**
         * Pre start procedures.
         * @see CheckUpdateInformationFolder()
         * @see StartUpdate()
         * @see Exit()
         */

        public void Start() {
            CheckUpdateInformationFolder();
            StartUpdate();

            // Exit program if gui is not used
            if (!SettingsManager.Instance.UseGUI && !SettingsManager.Instance.ShowProgress) {
                Exit();
            }
        }

        /**
         * UpdateService status changed.
         * Gets called if status within UpdateService changed.
         * @param sender calling object.
         * @param e status message.
         * @see WriteLog()
         */

        /**
         * Informs Gui about error.
         * @see WriteLog()
         */

        private void CheckUpdateInformationFolder() {
            WriteLog(Strings.MESSAGE_CHECKING_UPDATE_INFORMATION_FOLDER);
            // check if UpdateInformation folder exists .. if not -> create
            if (Directory.Exists(Path.GetFullPath(Strings.FOLDER_UPDATE_INFORMATION))) {
            } else {
                Directory.CreateDirectory(Path.GetFullPath(Strings.FOLDER_UPDATE_INFORMATION));
            }
        }

        private void DifferencesCancel(object sender, EventArgs e) {
            // exit application
            Exit();
        }

        private void DifferencesFinish(object sender, EventArgs e) {
            // exit application
            Exit();
        }

        /**
         * Exit on cancel
         * @see Exit()
         */

        /**
         * Called when update proceeds and gui is enabled.
         * @see EndUpdate()
         */

        private void DifferencesNext(object sender, EventArgs e) {
            // Close diff dialog.
            _differences.Close();
            // Show progess dialog.
            _progress.Show();
            // Start update.
            _updateResult = _userv.StartUpdate();
            // End update.
            EndUpdate();
        }

        /**
         * Ends update process
         * @see Exit()
         */

        private void EndUpdate() {
            // If gui is in use enable button to finish update.
            if (_updateResult == UpdateStatus.OK || SettingsManager.Instance.NoNewVersions) {
                // Generate dummy file update.finish to inform other programs about sucessfull update
                FileStream dummy = File.Create("./update.finished");
                dummy.Close();
                dummy = null;

                if (File.Exists(VersionsManager.Instance.LocalInformation.ProgramExecutable)) {
                    Process exe = new Process();

                    // Set application to start and parameters.
                    exe.StartInfo.FileName =
                            new StringBuilder().Append(SettingsManager.Instance.BasePath)
                                    .Append(Path.DirectorySeparatorChar)
                                    .Append(VersionsManager.Instance.LocalInformation.ProgramExecutable)
                                    .ToString();
                    // Start application
                    exe.Start();
                }
            }
            if (SettingsManager.Instance.UseGUI && _updateResult != UpdateStatus.UPDATER) {
                _progress.EnableFinish();
                // Else exit application.
            } else if (SettingsManager.Instance.ShowProgress && _updateResult == UpdateStatus.FAILED) {
                _progressScreenViewModel.UpdateErrorOccured();
            } else {
                Exit();
            }
        }

        /**
         * Called on finish click.
         * @see Exit()
         */

        /**
         * Initiates application shutdown.
         * @see WriteLog()
         */

        private void Exit() {
            _userv.DeleteLocalInformations();
            WriteLog(Strings.MESSAGE_END_UPDATE);
            WriteLog(Strings.COMMON_SEPARATOR);
            if (RequestExit != null) {
                RequestExit(this, EventArgs.Empty);
            }
        }

        private void OnError(string errorMessage) {
            if (SettingsManager.Instance.UseGUI) {
                // Disable proceed button.
                _differences.SetStateNext(false);
                // Show error message in gui.
                _differences.Status = errorMessage;
            } else if (SettingsManager.Instance.ShowProgress) {
                _progressScreenViewModel.ShowError(errorMessage);
            } else {
                // Write erro message to log.
                WriteLog(errorMessage);
            }
        }

        private void ProgressCancel(object sender, EventArgs e) {
            Exit();
        }

        /**
         * Exit on finish
         * @see Exit()
         */

        private void ProgressFinish(object sender, EventArgs e) {
            Exit();
        }

        private void ProgressScreenViewModelAcknowledgeError(object sender, EventArgs e) {
            Exit();
        }

        private void StartUpdate() {
            WriteLog(Strings.MESSAGE_START_UPDATE);

            // Instantiate gui.
            _differences = new Diff();
            _progress = new Progress();

            // Continue update.
            SettingsManager.Instance.ContinueUpdate = false;

            // If used, set gui to initial state and register events.
            if (SettingsManager.Instance.UseGUI) {
                _differences.Next += DifferencesNext;
                _differences.Finish += DifferencesFinish;
                _differences.Cancel += DifferencesCancel;
                _differences.ProductName = Strings.LOADING;
                _differences.CurrentVersion = Strings.LOADING;
                _differences.NewVersion = Strings.LOADING;
                _differences.ChangedFiles = Strings.LOADING;
                _differences.Show();

                _progress.Cancel += ProgressCancel;
                _progress.Finish += ProgressFinish;
            }
            if (SettingsManager.Instance.ShowProgress) {
                _progressScreenViewModel = new ProgressScreenViewModel();
                _progressScreenViewModel.AcknowledgeError += ProgressScreenViewModelAcknowledgeError;
                _progressScreen = new ProgressScreen();
                _progressScreen.DataContext = _progressScreenViewModel;
                _progressScreenViewModel.ShowProgress();
                _progressScreen.Show();
            }

            // Get VersionManger instance.
            _verManager = VersionsManager.Instance;

            /**
             * Get local information.
             */

            WriteLog(Strings.MESSAGE_AQUIRE_LOCAL_INFORMATION);
            // Get local version information.
            _verManager.GetLocalData();

            // If an error occours during local information gathering discontinue update
            if (!SettingsManager.Instance.ContinueUpdate && SettingsManager.Instance.ErrorPosition == ErrorPosition.Localinformation) {
                OnError(Strings.ERROR_GET_LOCAL);
            }

            // If update continues and gui is in use set current version and product name.
            if (SettingsManager.Instance.ContinueUpdate) {
                if (SettingsManager.Instance.UseGUI) {
                    _differences.CurrentVersion = _verManager.LocalInformation.CurrentVersion.ToString();
                    _differences.ProductName = _verManager.LocalInformation.ProductName;
                }
            }

            /**
             * Get remote overview.
             */

            // If update continues get overview.
            if (SettingsManager.Instance.ContinueUpdate) {
                WriteLog(Strings.MESSAGE_AQUIRE_REMOTE_OVERIEW);
                _verManager.GetOverview();
            }

            // If fetching remote overview failed cancel information gathering and discontinue.
            if (!SettingsManager.Instance.ContinueUpdate && SettingsManager.Instance.ErrorPosition == ErrorPosition.Overview) {
                OnError(Strings.ERROR_GET_OVERVIEW);
            }

            // If update continues and gu is in use, set newest avaiable version number.
            if (SettingsManager.Instance.ContinueUpdate) {
                if (SettingsManager.Instance.UseGUI) {
                    _differences.NewVersion = _verManager.Overview.Versions[_verManager.Overview.Versions.Count - 1].ToString();
                }
            }

            /**
             * Get remote version information.
             */

            // If update continues get all remote versions from newest down to current local version.
            if (SettingsManager.Instance.ContinueUpdate) {
                if (VersionsManager.Instance.LocalInformation.CurrentVersion.ToString()
                    != VersionsManager.Instance.Overview.Versions[VersionsManager.Instance.Overview.Versions.Count - 1].ToString()) {
                    WriteLog(Strings.MESSAGE_AQUIRE_REMOTE_INFORMATION);
                    _verManager.GetVersions(_verManager.Overview.Versions[_verManager.Overview.Versions.Count - 1].ToString());
                } else {
                    SettingsManager.Instance.NoNewVersions = true;
                    WriteLog(Strings.MESSAGE_NO_NEW_VERSION);
                }
            }

            // If error occours during version fetching cancel information gathering and discontinue.
            if (!SettingsManager.Instance.ContinueUpdate && SettingsManager.Instance.ErrorPosition == ErrorPosition.Remoteinformation) {
                OnError(Strings.ERROR_GET_VERSIONS);
            }

            // If update continues and gui is in use set number of files that will be changed during update or inform about no new version.
            if (SettingsManager.Instance.ContinueUpdate) {
                if (SettingsManager.Instance.UseGUI) {
                    if (SettingsManager.Instance.NoNewVersions) {
                        _differences.ChangedFiles = Strings.NO_NEW_VERSION;
                    } else {
                        _differences.ChangedFiles = _verManager.RemoteVersions[0].Files.Count.ToString();
                    }
                }
            }

            /**
             * Enable next step in update process
             */
            if ((!SettingsManager.Instance.UseGUI && !SettingsManager.Instance.ShowProgress) && SettingsManager.Instance.ContinueUpdate
                && !SettingsManager.Instance.NoNewVersions) {
                _updateResult = _userv.StartUpdate();
                EndUpdate();
            } else if (SettingsManager.Instance.ContinueUpdate && !SettingsManager.Instance.NoNewVersions
                       && SettingsManager.Instance.ShowProgress) {
                _updateResult = _userv.StartUpdate();
                EndUpdate();
            } else if (SettingsManager.Instance.ContinueUpdate && !SettingsManager.Instance.NoNewVersions
                       && SettingsManager.Instance.UseGUI) {
                _differences.SetStateNext(true);
            } else if (SettingsManager.Instance.NoNewVersions) {
                _userv.DeleteLocalInformations();
                EndUpdate();
            }
        }

        private void Userv_StatusMessageChanged(object sender, StatusMessageArgs e) {
            // write event message to gui if used
            if (SettingsManager.Instance.UseGUI) {
                _progress.AddLogText(e.Message);
            }
            if (SettingsManager.Instance.ShowProgress) {
                _progressScreenViewModel.SetProgressMessage(e.Message);
                Application.DoEvents();
            }

            // write message to log
            WriteLog(e.Message);
        }

        private void WriteLog(string p) {
            // write message to log
            _log.Info(p);
        }

        private void userv_ProgressMessageChanged(object sender, ProgressMessageArgs data) {
            if (SettingsManager.Instance.UseGUI) {
                _progress.SetProgressValue(data.Progress);
            }
            if (SettingsManager.Instance.ShowProgress) {
                _progressScreenViewModel.SetProgress(data.Progress);
                Application.DoEvents();
            }
        }
    }
}