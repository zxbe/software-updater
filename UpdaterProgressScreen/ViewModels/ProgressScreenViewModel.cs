using System;

using Com.QueoFlow.Commons;
using Com.QueoFlow.Commons.MVVM.ViewModels;

using UpdaterProgressScreen.DesignViewModels;

namespace UpdaterProgressScreen.ViewModels {
    public class ProgressScreenViewModel : ViewModelBase, IProgressScreenViewModel {
        private IDetailViewModel _detailViewModel;

        public event EventHandler AcknowledgeError;

        public IDetailViewModel DetailViewModel {
            get { return _detailViewModel; }
            set {
                _detailViewModel = value;
                OnPropertyChanged(this.GetPropertyName(x => x.DetailViewModel));
            }
        }

        public void ShowError(string errorMessage) {
            IErrorViewModel errorViewModel = new ErrorViewModel();
            errorViewModel.ErrorAcknowledged += ErrorViewModelErrorAcknowledged;
            errorViewModel.LoadData(errorMessage);
            DetailViewModel = errorViewModel;
        }

        public void SetProgressMessage(string message) {
            if (DetailViewModel is IProgressViewModel) {
                IProgressViewModel progressViewModel = (IProgressViewModel)DetailViewModel;
                progressViewModel.SetProgressMessage(message);
            }
        }

        public void SetProgress(int progress) {
            if (DetailViewModel is IProgressViewModel) {
                IProgressViewModel progressViewModel = (IProgressViewModel)DetailViewModel;
                progressViewModel.SetProgress(progress);
            }
        }

        public void ShowProgress() {
            IProgressViewModel progressViewModel = new ProgressViewModel();
            progressViewModel.ErrorAcknowledged += ProgressViewModelErrorAcknowledged;
            DetailViewModel = progressViewModel;

        }

        void ProgressViewModelErrorAcknowledged(object sender, EventArgs e) {
            OnAcknowledgeError();
        }

        public void UpdateErrorOccured() {
            if (DetailViewModel is IProgressViewModel) {
                IProgressViewModel progressViewModel = (IProgressViewModel)DetailViewModel;
                progressViewModel.IsErrorOnUpdate = true;
            }
        }

        void ErrorViewModelErrorAcknowledged(object sender, EventArgs e) {
            OnAcknowledgeError();
        }

        private void OnAcknowledgeError() {
            EventHandler handler = AcknowledgeError;
            if (handler != null) {
                handler(this, EventArgs.Empty);
            }
        }
    }
}