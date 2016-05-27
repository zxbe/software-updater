namespace Com.QueoMedia.Updater.Gui {
    /**
     * Interface for differences dialog
     */

    public interface IDiff : IBaseWindow {
        string ChangedFiles { set; }

        string CurrentVersion { set; }

        string NewVersion { set; }

        string ProductName { set; }

        string Status { set; }

        void SetStateNext(bool state);
    }
}