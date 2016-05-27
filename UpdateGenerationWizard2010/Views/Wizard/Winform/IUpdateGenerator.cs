using System;
using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;
using UpdateGenerationWizard2010.Data;
using UpdateGenerationWizard2010.Interfaces;

using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateGenerationWizard2010.Views.Wizard.Winform {
    public interface IUpdateGenerator : IBasicForm {
        event EventHandler Page1Activated;
        event EventHandler Page2Activated;
        event EventHandler Page3Activated;
        event EventHandler Page4Activated;
        event EventHandler Page5Activated;

        void EnablePage2(bool enable);
        void EnablePage3(bool enable);
        void EnablePage4(bool enable);
        void EnablePage5(bool enable);
        void EnableFinish(bool enable);

        VersionNumber AppliesTo { get; }

        event VersionNumberEventHandler ResultInVersionChanged;
        VersionNumber ResultsIn { get; set; }

        event EventHandler ItemAddedToFiles;
        IList<UpdateFileDto> UpdateFiles { get; }

        event StringEventHandler DestinationDirChanged;

        string FinalUpdateDestination { set; }


    }
}