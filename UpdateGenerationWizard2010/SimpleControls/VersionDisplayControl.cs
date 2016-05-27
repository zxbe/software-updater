using System;
using Com.QueoMedia.Updater.Data;

namespace UpdateGenerationWizard2010.SimpleControls {
    public partial class VersionDisplayControl : DevExpress.XtraEditors.XtraUserControl {
        private VersionNumber _version = new VersionNumber("0.0.0.0");

        public event EventHandler VersionNumberChanged;

        public VersionDisplayControl() {
            InitializeComponent();
        }

        public VersionNumber VersionNumber {
            get {
                return _version;
            }
            set
            {
                spinMajor.Value = int.Parse(value.Major);
                spinMinor.Value = int.Parse(value.Minor);
                spinBuild.Value = int.Parse(value.Build);
                spinRevision.Value = int.Parse(value.Revision);
                lblVersionAsString.Text = value.ToString();
                _version = value;
            }
        }

        private void SpinMajorValueChanged(object sender, System.EventArgs e) {
            _version.Major = spinMajor.Value.ToString();
            RefreshLabel();
        }

        private void SpinMinorValueChanged(object sender, System.EventArgs e) {
            _version.Minor = spinMinor.Value.ToString();
            RefreshLabel();
        }

        private void SpinBuildValueChanged(object sender, System.EventArgs e) {
            _version.Build = spinBuild.Value.ToString();
            RefreshLabel();
        }

        private void SpinRevisionValueChanged(object sender, System.EventArgs e) {
            _version.Revision = spinRevision.Value.ToString();
            RefreshLabel();
        }

        private void RefreshLabel()
        {
            lblVersionAsString.Text = _version.ToString();
            if (VersionNumberChanged != null)
            {
                VersionNumberChanged(this, EventArgs.Empty);
            }
        }
    }
}
