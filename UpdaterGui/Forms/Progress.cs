using System;

namespace Com.QueoMedia.Updater.Gui.Forms {
    /**
     * Progress dialog.
     * Shows update progress and log entries.
     */

    public partial class Progress : Base, IProgress {
        /**
         * Ctor.
         */

        public Progress(){
            InitializeComponent();
            SetStateFinish(false);
            SetStateNext(false);

            btnNext.Click += btnNext_Click;
            btnFinish.Click += btnFinish_Click;
            btnCancel.Click += btnCancel_Click;
        }

        /**
         * Called when "Next" clicked.
         */

        /**
         * Called when "Cancel" clicked.
         */

        #region Methods

        private void btnCancel_Click(object sender, EventArgs e){
            if (Cancel != null) {
                Cancel(this, EventArgs.Empty);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e){
            if (Finish != null) {
                Finish(this, EventArgs.Empty);
            }
        }

        private void btnNext_Click(object sender, EventArgs e){
            if (Next != null) {
                Next(this, EventArgs.Empty);
            }
        }

        #endregion

        #region IProgress Member

        /**
         * Sets progress value.
         */

        #region Properties

        public int Progress100{
            set { prgProgress.Value = value; }
        }

        #endregion

        /**
         * Adds log entry to dialog output.
         */

        #region Public Methods

        public void AddLogText(string text){
            lstDetails.Items.Add(text);
            lstDetails.SelectedIndex = lstDetails.Items.Count - 1;
        }

        /**
         * Enables "Finish" button.
         */

        public void EnableFinish(){
            SetStateFinish(true);
        }

        public void SetProgressValue(int progress){
            prgProgress.Value = progress;
        }

        #endregion

        #endregion

        #region IBaseWindow Member

        public event EventHandler Cancel;
        public event EventHandler Finish;
        public event EventHandler Next;

        #endregion
    }
}