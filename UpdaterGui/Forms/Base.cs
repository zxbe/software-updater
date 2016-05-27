using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Com.QueoMedia.Updater.Gui.Forms
{
    /**
     * Base dialog window.
     * Defines the base dialog with title and buttons.
     */
    public partial class Base : Form
    {
        /**
         * Ctor.
         */
        public Base(){
            InitializeComponent();
        }

        /**
         * Set state of "Next" button.
         * @param enabled enable or disable button
         */
        public void SetStateNext(bool enabled){
            btnNext.Enabled = enabled;
        }

        /**
         * Set state of "Finish" button.
         * @param enabled enable or disable button
         */
        public void SetStateFinish(bool enabled){
            btnFinish.Enabled = enabled;
        }

        /**
         * Set state of "Cancel" button.
         * @param enabled enable or disable button
         */
        public void SetStateCancel(bool enabled){
            btnCancel.Enabled = enabled;
        }
    }
}