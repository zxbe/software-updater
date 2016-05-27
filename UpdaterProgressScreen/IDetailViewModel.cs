using System;

namespace UpdaterProgressScreen {
    public interface IDetailViewModel {
         event EventHandler ErrorAcknowledged;

        RelayCommand AcknowledgeErrorCommand { get; }
    }
}