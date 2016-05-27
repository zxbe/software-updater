using System;

namespace UpdaterProgressScreen {
    public interface IProgressScreenViewModel {
        event EventHandler AcknowledgeError;

        IDetailViewModel DetailViewModel { get; set; }

        void ShowError(string errorMessage);

        void SetProgressMessage(string message);

        void SetProgress(int progress);

        void ShowProgress();

        void UpdateErrorOccured();
    }
}