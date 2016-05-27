using System;

namespace Com.QueoMedia.Updater.Gui {
    /**
     * Interface for basic window functions
     */

    public interface IBaseWindow {
        // Button events.

        event EventHandler Cancel;

        event EventHandler Finish;

        event EventHandler Next;

        // Window functions.

        void Close();

        void Hide();

        void Show();
    }
}