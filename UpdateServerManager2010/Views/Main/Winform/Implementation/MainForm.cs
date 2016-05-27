using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.QueoMedia.Updater.Data;
using DevExpress.XtraEditors;
using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateServerManager2010.Views.Main.Winform.Implementation {
    public partial class MainForm : XtraForm, IMainForm {

        #region Public methods

        public MainForm() {
            InitializeComponent();
        }

        #endregion

        #region Implementation of IBasicForm

        public Form GetAsForm() {
            return this;
        }

        #endregion

        #region Event handling

        private void BarButtonItem1ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (serverSelectDialog.ShowDialog() != DialogResult.OK)
                return;
            if (ServerFolderSelected == null)
                return;
            ServerFolderSelected(this, serverSelectDialog.SelectedPath);
        }

        #endregion

        #region Implementation of IMainForm

        public void ShowError(string error) {
            MessageBox.Show(error);
        }

        public event StringEventHandler ServerFolderSelected;

        public string SelectedServer {
            set { barStaticItem2.Caption = value; }
        }

        public IList<VersionNumber> AvailableVersions
        {
            set { bsOverviewVersions.DataSource = value; }
        }

        public void ShowInformation(string infromation)
        {
            MessageBox.Show(infromation);
        }

        public VersionNumber AppliesToVersion
        {
            set { versionApplies.VersionNumber = value; }
        }

        public VersionNumber CreatesVersion
        {
            set { versionCreates.VersionNumber = value; }
        }

        public IList<string> ChangedFiles
        {
            set { lstChangedFiles.DataSource = value; }
        }

        public IList<string> DeletedFiles
        {
            set { lstDeletedFiles.DataSource = value; }
        }

        public event VersionNumberEventHandler VersionNumberSelectionChanged;
        public event EventHandler RequestZipImport;
        public event EventHandler RequestNewServerWizard;

        public void EnableServerRelevantElements(bool enable)
        {
            barButtonItem2.Enabled = enable;
        }

        #endregion

        private void BsOverviewVersionsCurrentChanged(object sender, EventArgs e) {
            if (VersionNumberSelectionChanged == null)
                return;
            VersionNumberSelectionChanged(this, bsOverviewVersions.Current as VersionNumber);
        }

        private void BarButtonItem2ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (RequestZipImport == null)
                return;
            RequestZipImport(this, EventArgs.Empty);
        }

        private void BarButtonItem3ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (RequestNewServerWizard != null)
                RequestNewServerWizard(this, EventArgs.Empty);
        }
    }
}