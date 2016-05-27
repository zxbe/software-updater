using Com.QueoMedia.Updater.Service;

namespace Com.QueoMedia.Updater.Interfaces {
    /**
     * Interface for UpdateService
     */

    internal interface IUpdateService {
        event UpdateService.StatusMessageChangedHandler StatusMessageChanged;

        void DeleteLocalInformations();

        void ReportStatus(string message);

        UpdateStatus StartUpdate();
    }
}