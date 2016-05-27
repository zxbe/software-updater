using System;
using System.Collections.Generic;
using Com.QueoMedia.Updater.Data;
using UpdateServerManager2010.Interfaces;
using UpdateServerManager2010.CommonEventHandlers;

namespace UpdateServerManager2010.Views.ServerGeneratorWizard.Winform
{
    public interface IServerWizard: IBasicForm
    {
        event StringEventHandler Page1SelectedFolderChanged;
        event StringEventHandler Page1ServernameChanged;

        event StringEventHandler Page2ServerpathChanged;

        string Page1Executable { get; }

        string Page2Serverpath { set; }
        string Page2SecurityUser { get; }
        string Page2SecurityPwd { get; }
        string Page2ProxyUrl { get; }
        string Page2ProxyPort{ get; }
        string Page2ProxyUser { get; }
        string Page2ProxyPwd { get; }

        string Page3InfoXmlContent { set; }

        void Page2EnableSecuritySettings(bool enable);

        void EnablePage2(bool enable);
        void EnableFinish(bool enable);

        event EventHandler Page1Activated;
        event EventHandler Page2Activated;
        event EventHandler Page3Activated;

        event EventHandler CreationCanceled;

        void VoidShowError(string error);
    }
}