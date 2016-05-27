using System;
using System.Collections.ObjectModel;
using System.Windows;

using Com.QueoFlow.Commons;
using Com.QueoFlow.Commons.MVVM.ViewModels;

namespace UpdaterProgressScreen.ViewModels {
    public class ProgressViewModel : ViewModelBase, IProgressViewModel {
        private RelayCommand _acknowledgeErrorCommand;
        private bool _isErrorOnUpdate;
        private ObservableCollection<string> _messages = new ObservableCollection<string>();
        private int _progress;

        public event EventHandler ErrorAcknowledged;

        public RelayCommand AcknowledgeErrorCommand {
            get {
                if (_acknowledgeErrorCommand == null) {
                    _acknowledgeErrorCommand = new RelayCommand("", AcknowledgeError);
                }

                return _acknowledgeErrorCommand;
            }
        }

        public bool IsErrorOnUpdate {
            get { return _isErrorOnUpdate; }
            set {
                _isErrorOnUpdate = value;
                OnPropertyChanged(this.GetPropertyName(x => x.IsErrorOnUpdate));
            }
        }

        public ObservableCollection<string> Messages {
            get { return _messages; }
            private set {
                _messages = value;
                OnPropertyChanged(this.GetPropertyName(x => x.Messages));
            }
        }
        public int Progress {
            get { return _progress; }
            private set {
                _progress = value;
                OnPropertyChanged(this.GetPropertyName(x => Progress));
            }
        }

        public void SetProgress(int progress) {
            Progress = progress;
        }

        public void SetProgressMessage(string progressMessage) {
            Messages.Insert(0, progressMessage);
        }

        private void AcknowledgeError() {
            Clipboard.SetText(string.Join(Environment.NewLine, Messages));
            OnErrorAcknowledged();
        }

        private void OnErrorAcknowledged() {
            EventHandler handler = ErrorAcknowledged;
            if (handler != null) {
                handler(this, EventArgs.Empty);
            }
        }
    }
}