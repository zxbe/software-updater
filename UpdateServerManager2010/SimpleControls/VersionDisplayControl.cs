using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010.SimpleControls {
    public partial class VersionDisplayControl : DevExpress.XtraEditors.XtraUserControl {
        public VersionDisplayControl() {
            InitializeComponent();
        }

        public VersionNumber VersionNumber {
            set {
                bsVersionNumber.DataSource = value;
                lblVersionAsString.Text = value.ToString();
            }
        }
    }
}
