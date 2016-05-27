using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Com.QueoMedia.Updater.Data;
using DevExpress.XtraWizard;
using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateServerManager2010.Views.ZipImportWizard.Winform.Implementation {
    public partial class ZipWizard : DevExpress.XtraEditors.XtraForm, IZipWizard {

        public ZipWizard() {
            InitializeComponent();
        }

        private void ButtonEdit1ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {

        }

        #region Implementation of IBasicForm

        public Form GetAsForm() {
            return this;
        }

        #endregion

        #region Implementation of IZipWizard

        public void SetFileStatus(string message, Color textColor) {
            page1FileStatus.Text = message;
            page1FileStatus.ForeColor = textColor;
        }

        public event StringEventHandler Page1SelectedFileChanged;

        public VersionNumber AppliesToVersion {
            set { versionAppliesTo.VersionNumber = value; }
        }

        public VersionNumber ResultsInVersion {
            set { VersionResultsIn.VersionNumber = value; }
        }

        public IList<string> FilesInZip {
            set { zipContent.DataSource = value; }
        }

        public void Page3AddValidationLine(string message)
        {
            page3LstValidations.Items.Add(message);
        }

        public void Page4AddOperationLine(string message)
        {
            page4LstOperations.Items.Add(message);
        }

        public void Page4SetMeterValue(int value)
        {
            linearGauge1.Scales[0].Value = value;
            Application.DoEvents();
        }

        public void EnablePage2(bool enable) {
            page1.AllowNext = enable;
        }

        public void EnablePage3(bool enable) {
            page2.AllowNext = enable;
        }

        public void EnablePage4(bool enable) {
            page3.AllowNext = enable;
        }

        public void EnableFinish(bool enable) {
            page4.AllowNext = enable;
        }

        public event EventHandler Page1Activated;
        public event EventHandler Page2Activated;
        public event EventHandler Page3Activated;
        public event EventHandler Page4Activated;

        #endregion

        private void Page1BtnTxtButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            page1BtnTxt.Text = openFileDialog1.FileName;
            if (Page1SelectedFileChanged == null)
                return;
            Page1SelectedFileChanged(this, openFileDialog1.FileName);
        }

        private void WizardControl2SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e) {
            if (e.PrevPage == null && e.Direction == Direction.Forward) {
                if (Page1Activated != null) {
                    Page1Activated(this, EventArgs.Empty);
                }
            } else if (e.PrevPage == page1 && e.Direction == Direction.Forward) {
                if (Page2Activated != null) {
                    Page2Activated(this, EventArgs.Empty);
                }
            } else if (e.PrevPage == page2 && e.Direction == Direction.Forward) {
                page3LstValidations.Items.Clear();
                if (Page3Activated != null) {
                    Page3Activated(this, EventArgs.Empty);
                }
            } else if (e.PrevPage == page3 && e.Direction == Direction.Forward) {
                if (Page4Activated != null) {
                    Page4Activated(this, EventArgs.Empty);
                }
            }
        }
    }
}