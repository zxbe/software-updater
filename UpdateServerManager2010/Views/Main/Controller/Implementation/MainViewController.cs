using System;
using System.Collections.Generic;
using System.IO;
using Com.QueoMedia.Updater.Data;
using UpdateServerManager2010.Interfaces;
using UpdateServerManager2010.Properties;
using UpdateServerManager2010.Views.Main.Winform;
using UpdateServerManager2010.Views.ServerGeneratorWizard.Controller;
using UpdateServerManager2010.Views.ServerGeneratorWizard.Controller.Implementation;
using UpdateServerManager2010.Views.ServerGeneratorWizard.Winform.Implementation;
using UpdateServerManager2010.Views.ZipImportWizard.Controller;
using UpdateServerManager2010.Views.ZipImportWizard.Controller.Implementation;
using UpdateServerManager2010.Views.ZipImportWizard.Winform.Implementation;
using UpdateServerManager2010Services;
using UpdateServerManager2010Services.Implementation;

namespace UpdateServerManager2010.Views.Main.Controller.Implementation {
    class MainViewController : IMainViewController {

        #region Private variables

        private IMainForm _attachedForm;
        private string _currentlyOpenedServer;
        private const string OverviewFile = "overview.xml";
        private const string InformationFile = "info.xml";
        private IFileSystemService _fileSystemService;
        private IOverviewService _overviewService;
        private IVersionInformationService _versionInfoService;
        private Overview _currentServerOverview;

        #endregion

        #region Public methods

        public MainViewController(IMainForm attachedForm) {
            _fileSystemService = new FileSystemService();
            _overviewService = new OverviewService();
            _versionInfoService = new VersionInformationService();

            _attachedForm = attachedForm;
            _attachedForm.ServerFolderSelected += AttachedFormServerFolderSelected;
            _attachedForm.VersionNumberSelectionChanged += AttachedFormVersionNumberSelectionChanged;
            _attachedForm.RequestZipImport += AttachedFormRequestZipImport;
            _attachedForm.RequestNewServerWizard +=AttachedFormRequestNewServerWizard;

            if (!string.IsNullOrEmpty(Settings.Default.LastUsedServerPath))
                AttachedFormServerFolderSelected(null, Settings.Default.LastUsedServerPath);
        }

        #endregion

        #region Event handling

        private void AttachedFormRequestNewServerWizard(object sender, EventArgs e) {
            IServerWizardController newServer = new ServerWizardController(new ServerWizard());
            newServer.GetAttachedForm().GetAsForm().ShowDialog(_attachedForm.GetAsForm());
            if (newServer.NewServerPath != "")
            {
                _currentlyOpenedServer = newServer.NewServerPath;
                InitView(_currentlyOpenedServer);
            }
        }

        void AttachedFormRequestZipImport(object sender, System.EventArgs e) {
            IZipWizardController zipWizard = new ZipWizardController(new ZipWizard(), _currentlyOpenedServer, _currentServerOverview);
            zipWizard.GetAttachedForm().GetAsForm().ShowDialog(_attachedForm.GetAsForm());
            InitView(_currentlyOpenedServer);
        }

        void AttachedFormVersionNumberSelectionChanged(object sender, VersionNumber versionNumber) {
            if (versionNumber == null)
                return;
            VersionInformation info = _versionInfoService.GetVersionInformationFromFile(_fileSystemService.GetCompletePath(_currentlyOpenedServer + Path.DirectorySeparatorChar + versionNumber.ToString(), InformationFile));
            _attachedForm.AppliesToVersion = info.AppliesToVersion;
            _attachedForm.CreatesVersion = info.ResultsInVersion;
            IList<string> changed;
            IList<string> deleted;
            _versionInfoService.GenerateFileLists(info, out changed, out deleted);
            _attachedForm.ChangedFiles = changed;
            _attachedForm.DeletedFiles = deleted;
        }

        void AttachedFormServerFolderSelected(object sender, string text) {
            InitView(text);
        }

        private void InitView(string text) {
            if (_fileSystemService.IsFileInFolder(text, OverviewFile)) {
                InitOnServerChanged(text);
                _attachedForm.EnableServerRelevantElements(true);
            } else {
                _attachedForm.ShowError("Der gewählte Ordner ist kein Update Server.");
                ResetGui();
                _attachedForm.EnableServerRelevantElements(false);
            }
        }

        #endregion

        #region Private methods

        private void InitOnServerChanged(string folderPath) {
            _currentlyOpenedServer = folderPath;
            _attachedForm.SelectedServer = _currentlyOpenedServer;
            _currentServerOverview = _overviewService.GetOverviewFromFile(_fileSystemService.GetCompletePath(_currentlyOpenedServer, OverviewFile));
            _attachedForm.AvailableVersions = _overviewService.GetVersionsFromOverview(_currentServerOverview);
            Settings.Default.LastUsedServerPath = _currentlyOpenedServer;
            Settings.Default.Save();
        }

        private void ResetGui() {
            _currentlyOpenedServer = string.Empty;
            _attachedForm.SelectedServer = "-";
            _attachedForm.AvailableVersions = new List<VersionNumber>();
            Settings.Default.LastUsedServerPath = "";
            Settings.Default.Save();
        }

        #endregion

        #region Implementation of IBasicViewController

        public IBasicForm GetAttachedForm() {
            return _attachedForm;
        }

        #endregion
    }
}
