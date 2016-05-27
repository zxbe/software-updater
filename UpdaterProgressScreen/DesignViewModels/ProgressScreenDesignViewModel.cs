using System;

namespace UpdaterProgressScreen.DesignViewModels {
    public class ProgressScreenDesignViewModel : IProgressScreenViewModel {
        /// <summary>
        ///     Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.
        /// </summary>
        public ProgressScreenDesignViewModel() {
            DetailViewModel = new ProgressDesignViewModel();
        }

        public event EventHandler AcknowledgeError;

        public IDetailViewModel DetailViewModel { get; set; }

        public void SetProgress(int progress) {
        }

        public void ShowProgress() {
        }

        public void UpdateErrorOccured() {
        }

        public void SetProgressMessage(string message) {
        }

        public void ShowError(string errorMessage) {
        }
    }
}