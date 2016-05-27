using System;

using Com.QueoFlow.Commons;
using Com.QueoFlow.Commons.MVVM.ViewModels;

namespace UpdaterProgressScreen.ViewModels {
    public class ErrorViewModel : ViewModelBase, IErrorViewModel {
        private string _errorMessage;

        public string ErrorMessage {
            get { return _errorMessage; }
            private set {
                _errorMessage = value;
                OnPropertyChanged(this.GetPropertyName(x => x.ErrorMessage));
            }
        }

        public event EventHandler ErrorAcknowledged;

        private void OnErrorAcknowledged() {
            EventHandler handler = ErrorAcknowledged;
            if (handler != null) {
                handler(this, EventArgs.Empty);
            }
        }

        public RelayCommand AcknowledgeErrorCommand {
            get {
                if (_acknowledgeErrorCommand == null)
                    _acknowledgeErrorCommand = new RelayCommand("", AcknowledgeError);

                return _acknowledgeErrorCommand;
            }
        }

        private RelayCommand _acknowledgeErrorCommand;

        private void AcknowledgeError() {
            OnErrorAcknowledged();
        }		

        public void LoadData(string errorMessage) {
            ErrorMessage = errorMessage;
        }
    }
}