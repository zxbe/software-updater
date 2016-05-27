using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UpdateWcfService {
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IUpdateWcfService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IUpdateWcfService {

        [OperationContract]
        string DoUpdate(string infoXmlPath);
    }
}
