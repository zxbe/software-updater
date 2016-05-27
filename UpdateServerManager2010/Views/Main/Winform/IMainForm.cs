using System;
using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;
using UpdateServerManager2010.CommonEventHandlers;
using UpdateServerManager2010.Interfaces;

namespace UpdateServerManager2010.Views.Main.Winform {
    public interface IMainForm : IBasicForm {
        void ShowError(string error);

        event StringEventHandler ServerFolderSelected;

        string SelectedServer { set; }

        IList<VersionNumber> AvailableVersions { set; }

        void ShowInformation(string infromation);

        VersionNumber AppliesToVersion { set; }
        VersionNumber CreatesVersion { set; }

        IList<string> ChangedFiles { set; }
        IList<string> DeletedFiles { set; }

        event VersionNumberEventHandler VersionNumberSelectionChanged;

        event EventHandler RequestZipImport;
        event EventHandler RequestNewServerWizard;

        void EnableServerRelevantElements(bool enable);
    }
}