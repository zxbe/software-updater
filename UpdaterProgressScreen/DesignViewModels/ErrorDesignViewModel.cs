using System;

namespace UpdaterProgressScreen.DesignViewModels {
    public class ErrorDesignViewModel :IErrorViewModel{
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="T:System.Object"/>-Klasse.
        /// </summary>
        public ErrorDesignViewModel() {
            ErrorMessage = "Dies ist ein Fehler. Die info.xml konnte nicht gefunden werden.";
        }

        public void LoadData(string errorMessage) {
        }

        public string ErrorMessage { get; private set; }

        public event EventHandler ErrorAcknowledged;

        public RelayCommand AcknowledgeErrorCommand { get; private set; }
    }
}