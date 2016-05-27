using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateServerManager2010.Views.ServerGeneratorWizard.Winform.Implementation {
    public partial class ServerWizard : XtraForm, IServerWizard {
        public ServerWizard() {
            InitializeComponent();
        }

        #region Implementation of IBasicForm

        public Form GetAsForm() {
            return this;
        }

        #endregion

        #region Implementation of IServerWizard

        public event StringEventHandler Page1SelectedFolderChanged;
        public event StringEventHandler Page1ServernameChanged;
        public event StringEventHandler Page2ServerpathChanged;

        public string Page1Executable
        {
            get { return page1TxtExecutable.Text; }
        }

        public string Page2Serverpath
        {
            set { page2TxtServerpath.Text = value; }
        }

        public string Page2SecurityUser {
            get { return page2TxtSecurityUser.Text; }
        }

        public string Page2SecurityPwd {
            get { return page2TxtSecurityPwd.Text; }
        }

        public string Page2ProxyUrl {
            get { return page2TxtProxyUrl.Text; }
        }

        public string Page2ProxyPort {
            get { return page2TxtProxyHttpsPort.Text; }
        }

        public string Page2ProxyUser {
            get { return page2TxtProxyUser.Text; }
        }

        public string Page2ProxyPwd {
            get { return page2TxtProxyPwd.Text; }
        }

        public string Page3InfoXmlContent {
            set { page3TxtInfoXmlContent.Text = value; }
        }

        public void Page2EnableSecuritySettings(bool enable) {
            page2TxtSecurityUser.Enabled = enable;
            page2TxtSecurityPwd.Enabled = enable;
        }

        public void EnablePage2(bool enable) {
            wizP1.AllowNext = enable;
        }

        public void EnableFinish(bool enable) {
            wizP2.AllowNext = enable;
        }

        public event EventHandler Page1Activated;
        public event EventHandler Page2Activated;
        public event EventHandler Page3Activated;
        public event EventHandler CreationCanceled;

        public void VoidShowError(string error)
        {
            page1LblError.Text = error;
        }

        #endregion

        private void WizardControl1SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e) {
            if (e.PrevPage == null && e.Page.Name == wizP1.Name)
            {
                if (Page1Activated != null)
                    Page1Activated(this, EventArgs.Empty);
            }
            else if (e.Page.Name == wizP2.Name)
            {
                if (Page2Activated != null)
                    Page2Activated(this, EventArgs.Empty);
            } else if (e.Page.Name == wizP3.Name)
            {
                if (Page3Activated != null)
                    Page3Activated(this, EventArgs.Empty);
            }
        }

        private void Page1BtnTxtButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                page1BtnTxt.Text = folderBrowserDialog1.SelectedPath;
                if (Page1SelectedFolderChanged != null)
                    Page1SelectedFolderChanged(this, folderBrowserDialog1.SelectedPath);
            }
        }

        private void Page1BtnTxtTextChanged(object sender, EventArgs e) {
            if (Page1SelectedFolderChanged != null)
                Page1SelectedFolderChanged(this, folderBrowserDialog1.SelectedPath);
        }

        private void Page1TxtServernameTextChanged(object sender, EventArgs e) {
            if (Page1ServernameChanged != null)
                Page1ServernameChanged(this, page1TxtServername.Text);
        }

        private void Page2TxtServerpathTextChanged(object sender, EventArgs e) {
            if (Page2ServerpathChanged != null)
            {
                Page2ServerpathChanged(this, page2TxtServerpath.Text);
            }
        }

        private void WizardControl1CancelClick(object sender, CancelEventArgs e) {
            if (CreationCanceled != null)
            {
                CreationCanceled(this, EventArgs.Empty);
            }
        }
    }
}