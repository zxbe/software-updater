using System;
using System.Drawing;
using System.Threading;
using Com.QueoMedia.Updater.Data;
using UpdateServerManager2010.Interfaces;
using UpdateServerManager2010.Views.ZipImportWizard.Winform;
using UpdateServerManager2010Services;
using UpdateServerManager2010Services.Implementation;

namespace UpdateServerManager2010.Views.ZipImportWizard.Controller.Implementation {
    class ZipWizardController : IZipWizardController {

        private IZipWizard _attachedView;
        private IZipUpdateFileService _zipUpdateService;
        private IVersionInformationService _versionInfoService;
        private IOverviewService _overviewService;
        private IFileSystemService _fileService;

        private string _activeServer;
        private string _activeZip;
        private Overview _activeOverview;
        private VersionNumber _activeAppliesTo;
        private VersionNumber _activeResultsIn;

        public ZipWizardController(IZipWizard attachedView, string activeServer, Overview activeOverview) {
            _activeServer = activeServer;
            _activeOverview = activeOverview;

            _zipUpdateService = new ZipUpdateFileService();
            _versionInfoService = new VersionInformationService();
            _overviewService = new OverviewService();
            _fileService = new FileSystemService();

            _attachedView = attachedView;
            _attachedView.Page1SelectedFileChanged += AttachedViewPage1SelectedFileChanged;

            _attachedView.Page1Activated += _attachedView_Page1Activated;
            _attachedView.Page2Activated += AttachedViewPage2Activated;
            _attachedView.Page3Activated += AttachedViewPage3Activated;
            _attachedView.Page4Activated += AttachedViewPage4Activated;
        }

        void AttachedViewPage4Activated(object sender, EventArgs e) {
            // copy zip content to server
            UpdateServer();
        }

        void AttachedViewPage3Activated(object sender, EventArgs e) {
            // Prüfen ob diese Version schon auf dem server existiert
            //Fehler wenn schon auf dem server
            //fehler wenn assign to version nicht exisiert
            ValidateVersions();
        }

        void AttachedViewPage2Activated(object sender, EventArgs e) {
            // show content of info.xml
            ShowInfoXmlContent();
        }

        void _attachedView_Page1Activated(object sender, EventArgs e) {
            // nothing to do on page 1.
        }

        void AttachedViewPage1SelectedFileChanged(object sender, string text) {
            VerifySelectedZip(text);
        }

        private void ShowInfoXmlContent() {
            VersionInformation info = _zipUpdateService.GetVersionInformationFromZip(_activeZip);
            if (info == null)
                return;
            _attachedView.AppliesToVersion = info.AppliesToVersion;
            _activeAppliesTo = info.AppliesToVersion;
            _attachedView.ResultsInVersion = info.ResultsInVersion;
            _activeResultsIn = info.ResultsInVersion;
            _attachedView.FilesInZip = _versionInfoService.GenerateFileOperationsList(info);
            _attachedView.EnablePage3(true);
        }

        private void ValidateVersions() {
            bool assignToVersionValidated = false;
            bool resultsingVersionValidated = false;

            if (_overviewService.ExistsInOverview(_activeOverview, _activeAppliesTo)) {
                _attachedView.Page3AddValidationLine("Grundversion vorhanden.");
                assignToVersionValidated = true;
            } else {
                _attachedView.Page3AddValidationLine("Grundversion nicht vorhanden!");
            }

            if (_overviewService.ExistsInOverview(_activeOverview, _activeResultsIn)) {
                _attachedView.Page3AddValidationLine("Zielversion bereits vorhanden!");
            } else {
                _attachedView.Page3AddValidationLine("Zielversion noch nicht vorhanden.");
                resultsingVersionValidated = true;
            }

            if (assignToVersionValidated && resultsingVersionValidated) {
                _attachedView.EnablePage4(true);
            }
        }

        private void UpdateServer() {
            string newUpdatePath = string.Empty;
            //TestMeter();

            _attachedView.Page4SetMeterValue(0);

            // generate new folder on server);
            try {
                newUpdatePath = _fileService.GenerateNewFolderForVersion(_activeResultsIn, _activeServer);
            } catch (Exception ex) {
                _attachedView.Page4AddOperationLine("Fehler: " + ex.Message);
                return;
            }
            _attachedView.Page4AddOperationLine("Ordner für neue Version angelegt.");
            _attachedView.Page4SetMeterValue(25);

            // extract zip to folder
            try {
                _zipUpdateService.ExtractUopdateZipToFolder(_activeZip, newUpdatePath);
            } catch (Exception ex)
            {
                _attachedView.Page4AddOperationLine("Fehler: " + ex.Message);
                return;
            }
            _attachedView.Page4AddOperationLine("Update in Ordner entpackt.");
            _attachedView.Page4SetMeterValue(50);

            // update overview

            _activeOverview.Versions.Add(_activeResultsIn);
            _attachedView.Page4AddOperationLine("Neue Version in Übersicht eingetragen");
            _attachedView.Page4SetMeterValue(75);

            // write overview

            _overviewService.UpdateOverviewFile(_activeServer, _activeOverview);
            _attachedView.Page4AddOperationLine("Übersicht gespeichert.");
            _attachedView.Page4SetMeterValue(100);

            _attachedView.Page4AddOperationLine("Update Bereitgestellt.");
        }

        private void TestMeter() {
            _attachedView.Page4SetMeterValue(0);
            for (int i = 0; i < 100; i++) {
                _attachedView.Page4SetMeterValue(i);
                Thread.Sleep(100);
            }
            _attachedView.Page4SetMeterValue(0);
        }

        private void VerifySelectedZip(string text) {
            if (_zipUpdateService.FileIsUpdate(text)) {
                _activeZip = text;
                _attachedView.SetFileStatus("Datei ist ein Update.", Color.Green);
                _attachedView.EnablePage2(true);
            } else {
                _activeZip = string.Empty;
                _attachedView.SetFileStatus("Datei ist kein Update.", Color.Red);
                _attachedView.EnablePage2(false);
                _attachedView.EnablePage3(false);
                _attachedView.EnablePage4(false);
            }
        }

        #region Implementation of IBasicViewController

        public IBasicForm GetAttachedForm() {
            return _attachedView;
        }

        #endregion
    }
}
