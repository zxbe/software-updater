using System;

namespace Com.QueoMedia.Updater.Interfaces {
    /**
     * Interface for MainUpdaterController
     */

    public interface IMainUpdaterController {
        event EventHandler RequestExit;

        // Start update
        void Start();
    }
}