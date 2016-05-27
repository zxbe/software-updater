using System;
using System.Threading;
using Com.QueoMedia.Updater.Controller;
using Com.QueoMedia.Updater.Interfaces;

namespace UpdateWcfService {
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "UpdateWcfService" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    public class UpdateWcfService : IUpdateWcfService {
        #region Implementation of IUpdateWcfService
        bool _finishedSuccessfully = false;


        public string DoUpdate(string infoXmlPath)
        {
            
            IMainUpdaterController mainController = new MainUpdaterController(false, infoXmlPath);
            mainController.RequestExit += MainControllerRequestExit;
            mainController.Start();
            while (!_finishedSuccessfully)
            {
                Thread.Sleep(100);
            }
            mainController.RequestExit -= MainControllerRequestExit;
            return mainController.AppToStartAfterUpdate;
        }

        void MainControllerRequestExit(object sender, EventArgs e) {
            _finishedSuccessfully = true;
        }

        #endregion
    }
}
