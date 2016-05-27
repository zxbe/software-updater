using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.QueoMedia.Updater.Data;
using DevExpress.XtraEditors;
using UpdateGenerationWizard2010.Data;
using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateGenerationWizard2010.Views.Wizard.Winform.Implementation {
    public partial class UpdateGeneratorWizard : XtraForm, IUpdateGenerator {
        public UpdateGeneratorWizard() {
            InitializeComponent();
            versionResultsIn.VersionNumberChanged += VersionResultsInVersionNumberChanged;
            bsFiles.DataSource = new List<UpdateFileDto>();
        }

        void VersionResultsInVersionNumberChanged(object sender, EventArgs e) {
            if (ResultInVersionChanged != null)
                ResultInVersionChanged(this, versionResultsIn.VersionNumber);
        }

        private void RepTxtBtnFileButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            ButtonEdit edit = gridView1.ActiveEditor as ButtonEdit;
            if (edit != null) edit.EditValue = openFileDialog1.FileName;
        }

        #region Implementation of IBasicForm

        public Form GetAsForm()
        {
            return this;
        }

        #endregion

        #region Implementation of IUpdateGenerator

        public event EventHandler Page1Activated;
        public event EventHandler Page2Activated;
        public event EventHandler Page3Activated;
        public event EventHandler Page4Activated;
        public event EventHandler Page5Activated;

        public void EnablePage2(bool enable)
        {
            wizP1.AllowNext = enable;
        }

        public void EnablePage3(bool enable)
        {
            wizP2.AllowNext = enable;
        }

        public void EnablePage4(bool enable)
        {
            wizP3.AllowNext = enable;
        }

        public void EnablePage5(bool enable)
        {
            wizP4.AllowNext = enable;
        }

        public void EnableFinish(bool enable)
        {
            wizP5.AllowNext = enable;
        }

        public VersionNumber AppliesTo
        {
            get { return versionAppliesTo.VersionNumber; }
        }

        public event VersionNumberEventHandler ResultInVersionChanged;

        public VersionNumber ResultsIn
        {
            get { return versionResultsIn.VersionNumber; }
            set { versionResultsIn.VersionNumber = value; }
        }

        public event EventHandler ItemAddedToFiles;

        public IList<UpdateFileDto> UpdateFiles
        {
            get { return bsFiles.DataSource as IList<UpdateFileDto>; }
        }

        public event StringEventHandler DestinationDirChanged;

        public string FinalUpdateDestination
        {
            set { txtFinalDestination.Text = value; }
        }

        #endregion

        private void WizardControl1SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e) {
            if (e.PrevPage == null && e.Page.Name == wizP1.Name)
            {
                if (Page1Activated != null)
                    Page1Activated(this, EventArgs.Empty);
            } else if (e.Page.Name == wizP2.Name) {
                if (Page2Activated != null)
                    Page2Activated(this, EventArgs.Empty);
            } else if (e.Page.Name == wizP3.Name) {
                if (Page3Activated != null)
                    Page3Activated(this, EventArgs.Empty);
            } else if (e.Page.Name == wizP4.Name) {
                if (Page4Activated != null)
                    Page4Activated(this, EventArgs.Empty);
            } else if (e.Page.Name == wizP5.Name) {
                if (Page5Activated != null)
                    Page5Activated(this, EventArgs.Empty);
            }
        }

        private void BsFilesCurrentChanged(object sender, EventArgs e) {
            if (bsFiles.Count > 0)
                if (ItemAddedToFiles != null)
                    ItemAddedToFiles(this, EventArgs.Empty);
        }

        private void ButtonEdit1ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBtnFinalFolder.EditValue = folderBrowserDialog1.SelectedPath;
                if (DestinationDirChanged != null)
                {
                    DestinationDirChanged(this, folderBrowserDialog1.SelectedPath);
                }
            }
        }

        private void WizardControl1CancelClick(object sender, System.ComponentModel.CancelEventArgs e) {
            this.Close();
        }

        private void WizardControl1FinishClick(object sender, System.ComponentModel.CancelEventArgs e) {
            this.Close();
        }
    }
}