using System;
using System.Collections.ObjectModel;

namespace UpdaterProgressScreen.DesignViewModels {
    public class ProgressDesignViewModel: IProgressViewModel {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="T:System.Object"/>-Klasse.
        /// </summary>
        public ProgressDesignViewModel() {
            Messages = new ObservableCollection<string>();
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");
            Messages.Add("blubber die blubb und noch bisserl text hinten dran .... evtl. auch bissl länger und dann noch mit einem"+Environment.NewLine+"Zeilenumbruch");

            Progress = 42;

            IsErrorOnUpdate = true;
        }

        public void SetProgressMessage(string progressMessage) {
        }

        public void SetProgress(int progress) {
        }

        public int Progress { get; private set; }

        public bool IsErrorOnUpdate { get; set; }

        public ObservableCollection<string> Messages { get; private set; }

        public event EventHandler ErrorAcknowledged;

        public RelayCommand AcknowledgeErrorCommand { get; private set; }
    }
}