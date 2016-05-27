namespace Com.QueoMedia.Updater.Gui {
    /**
     * Interface for progress dialog.
     */

    public interface IProgress : IBaseWindow {
        int Progress100 { set; }

        void AddLogText(string text);

        void EnableFinish();

        void SetProgressValue(int progress);
    }
}