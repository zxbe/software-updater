using System;
using UpdateServerManager2010.Interfaces;
using UpdateServerManager2010.Views.ServerGeneratorWizard.Winform;
using UpdateServerManager2010Services;
using UpdateServerManager2010Services.Implementation;

namespace UpdateServerManager2010.Views.ServerGeneratorWizard.Controller.Implementation {
    class ServerWizardController: IServerWizardController {

        private IServerWizard _attachedView;

        private IFileSystemService _fileSystemService;
        private IOverviewService _overviewService;
        private ILocalInformationService _localService;

        private string _serverFolder;
        private string _serverName;
        private string _executable;
        private string _serverPath;
        private string _serverUser;
        private string _serverPwd;
        private string _serverProxyUrl;
        private string _serverProxyPort;
        private string _serverProxyUser;
        private string _serverProxyPwd;

        private bool _isOnPage3;
        private bool _isCanceled;

        public ServerWizardController(IServerWizard attachedView)
        {
            _fileSystemService = new FileSystemService();
            _overviewService = new OverviewService();
            _localService = new LocalInformationService();

            _attachedView = attachedView;
            _attachedView.Page1Activated += AttachedViewPage1Activated;
            _attachedView.Page1SelectedFolderChanged += AttachedViewPage1SelectedFolderChanged;
            _attachedView.Page1ServernameChanged += AttachedViewPage1ServernameChanged;
            _attachedView.Page2Activated += AttachedViewPage2Activated;
            _attachedView.Page2ServerpathChanged += AttachedViewPage2ServerpathChanged;
            _attachedView.Page3Activated += AttachedViewPage3Activated;
            _attachedView.CreationCanceled += AttachedViewCreationCanceled;
        }

        void AttachedViewCreationCanceled(object sender, EventArgs e) {
            _isCanceled = true;
            if (_isOnPage3)
            {
                _fileSystemService.DeleteServerFolder(_serverFolder, _serverName);
            }
        }

        void AttachedViewPage3Activated(object sender, EventArgs e) {
            // Get values from view
            GetPage2Values();

            // remember that page 3 is active
            _isOnPage3 = true;

            // generate server folder
            _fileSystemService.GenerateServerFolder(_serverFolder, _serverName);

            // generate base version and overview.xml
            _overviewService.InitServerFolder(_serverFolder, _serverName);

            // generate new info.xml
            _attachedView.Page3InfoXmlContent = _localService.GenerateLocalInformation(_serverName, _executable, _serverPath, _serverUser, _serverPwd,
                                                   _serverProxyUrl, _serverProxyPort, _serverProxyUser, _serverProxyPwd);
        }

        void AttachedViewPage2ServerpathChanged(object sender, string text)
        {
            _serverPath = text;
            // check if https is in use and en- or disable security settings input
            if (string.IsNullOrEmpty(text)) _attachedView.EnableFinish(false);
            else _attachedView.EnableFinish(true);
            _attachedView.Page2EnableSecuritySettings(text.ToLower().StartsWith("https:"));
        }

        void AttachedViewPage2Activated(object sender, System.EventArgs e) {
            _executable = _attachedView.Page1Executable;

            _attachedView.Page2Serverpath = _fileSystemService.GetServerPath(_serverFolder, _serverName);

            if (_isOnPage3)
            {
                // reset all stuff made on change to page 3
                // delete new server folder
                _fileSystemService.DeleteServerFolder(_serverFolder, _serverName);

                _isOnPage3 = false;
            }
        }

        void AttachedViewPage1ServernameChanged(object sender, string text) {
            // check if server allready exists in given folder
            _serverName = text;
            ValidateServer();
        }

        void AttachedViewPage1SelectedFolderChanged(object sender, string text) {
            // check if server allready exists in given folder
            _serverFolder = text;
            ValidateServer();
        }

        void AttachedViewPage1Activated(object sender, System.EventArgs e) {
            

            // Reset error display
            _attachedView.VoidShowError("");
        }

        private void GetPage2Values() {
            _serverUser = _attachedView.Page2SecurityUser;
            _serverPwd = _attachedView.Page2SecurityPwd;
            _serverProxyUrl = _attachedView.Page2ProxyUrl;
            _serverProxyPort = _attachedView.Page2ProxyPort;
            _serverProxyUser = _attachedView.Page2ProxyUser;
            _serverProxyPwd = _attachedView.Page2ProxyPwd;
        }

        private void ValidateServer() {
            if (string.IsNullOrEmpty(_serverFolder) || string.IsNullOrEmpty(_serverName))
            {
                _attachedView.EnablePage2(false);
                return;
            }

            if (_fileSystemService.FolderExistsInPath(_serverName, _serverFolder)) {
                _attachedView.VoidShowError("Es exisitiert bereits ein Ordner mit dem Namen " + _serverName + "\nim gewünschten Zielordner.");
                _attachedView.EnablePage2(false);
                return;
            }

            if (!_fileSystemService.UserHasWritePermissionToFolder(_serverFolder))
            {
                _attachedView.VoidShowError("Im gewünschten Zielordner kann nicht geschrieben werden!");
                _attachedView.EnablePage2(false);
                return;
            }

            _attachedView.VoidShowError("");
            _attachedView.EnablePage2(true);
        }

        #region Implementation of IBasicViewController

        public IBasicForm GetAttachedForm()
        {
            return _attachedView;
        }

        #endregion

        #region Implementation of IServerWizardController

        public string NewServerPath
        {
            get { return !_isCanceled ? _fileSystemService.GetServerPath(_serverFolder, _serverName) : ""; }
        }

        #endregion
    }
}
