using System;

namespace Updater.Args {
    internal class ProgressMessageArgs : EventArgs {
        private int _progress;
        
        public int Progress {
            get { return _progress; }
            set { _progress = value; }
        }
    }
}