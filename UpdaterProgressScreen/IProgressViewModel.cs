using System.Collections.ObjectModel;

namespace UpdaterProgressScreen {
    public interface IProgressViewModel : IDetailViewModel {

        bool IsErrorOnUpdate { get; set; }

        ObservableCollection<string> Messages { get; }

        int Progress { get; }

        void SetProgress(int progress);

        void SetProgressMessage(string progressMessage);
    }
}