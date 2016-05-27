using UpdateServerManager2010.Interfaces;

namespace UpdateServerManager2010.Views.ServerGeneratorWizard.Controller
{
    public interface IServerWizardController: IBasicViewController
    {
        string NewServerPath { get; }
    }
}