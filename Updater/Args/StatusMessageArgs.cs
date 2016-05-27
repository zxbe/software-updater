using System;

namespace Updater.Args {
    internal class StatusMessageArgs : EventArgs {
        private string m_message;

        public string Message {
            get { return m_message; }
            set { m_message = value; }
        }
    }
}