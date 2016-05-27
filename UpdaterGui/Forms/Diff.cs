using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.QueoMedia.Updater.Gui.Forms;

namespace Com.QueoMedia.Updater.Gui.Forms
{
    /**
     * Differences dialog.
     * Dialog to show appliation version differences.
     */
    public partial class Diff : Base, IDiff
    {
        /**
         * Ctor.
         */
        public Diff()
        {
            InitializeComponent();
            SetStateFinish(true);
            btnNext.Click += new EventHandler(btnNext_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        /**
         * Called when "Next" clicked.
         */
        void btnNext_Click(object sender, EventArgs e)
        {
            if (Next != null)
            {
                Next(this, EventArgs.Empty);
            }
        }

        /**
         * Called when "Cancel" klicked.
         */
        void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel(this, EventArgs.Empty);
            }
        }

        /**
         * Called when "Finish" klicked.
         */
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (Finish != null)
            {
                Finish(this, EventArgs.Empty);
            }
        }

        #region IDiff Member

        /**
         * Set current version to label.
         */
        public string CurrentVersion
        {
            set { lblCellCurrentVersionNumber.Text = value; }
        }

        /**
         * Set new version to label.
         */
        public string NewVersion
        {
            set { lblCellNewVersionNumber.Text = value; }
        }

        /**
         * Set number of changed files to label.
         */
        public string ChangedFiles
        {
            set { lblNewVersionChangedFiles.Text = value; }
        }

        /**
         * Set product name to label.
         */
        public new string ProductName
        {
            set { lblProductName.Text = value; }
        }

        /**
         * Set "Next" state.
         * @param state enables or diables the "Next" button
         */
        public void SetStateNext(bool state) {
            base.SetStateNext(state);
        }

        #endregion

        #region IBaseWindow Member

        public event EventHandler Next;

        public event EventHandler Finish;

        public event EventHandler Cancel;

        #endregion

        #region IDiff Member

        /**
         * Sets and shows status messages in seperate, previsously hidden label.
         */
        public string Status {
            set {
                lblStatus.Text = value;
                lblStatus.Visible = true;
            }
        }

        #endregion
    }
}