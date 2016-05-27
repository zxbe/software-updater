using System;
using System.Collections.Generic;
using System.Drawing;
using Com.QueoMedia.Updater.Data;
using UpdateServerManager2010.CommonEventHandlers;
using UpdateServerManager2010.Interfaces;

namespace UpdateServerManager2010.Views.ZipImportWizard.Winform
{
    public interface IZipWizard: IBasicForm
    {
        void SetFileStatus(string message, Color textColor);
        event StringEventHandler Page1SelectedFileChanged;

        VersionNumber AppliesToVersion { set; }
        VersionNumber ResultsInVersion { set; }
        IList<string> FilesInZip { set; }

        void Page3AddValidationLine(string message);
        void Page4AddOperationLine(string message);
        void Page4SetMeterValue(int value);

        void EnablePage2(bool enable);
        void EnablePage3(bool enable);
        void EnablePage4(bool enable);
        void EnableFinish(bool enable);

        event EventHandler Page1Activated;
        event EventHandler Page2Activated;
        event EventHandler Page3Activated;
        event EventHandler Page4Activated;
    }
}