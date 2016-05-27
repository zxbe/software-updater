using Com.QueoMedia.Updater.Data;

namespace UpdateGenerationWizard2010.Data {
    public class UpdateFileDto {

        private const string OpAdd = "Hinzufügen";
        private const string OpDel = "Entfernen";
        private const string TypeFile = "Datei";
        private const string TypeZip = "ZIP";


        private string _directory;
        private string _file;
        private string _operation;
        private string _updateType;

        public UpdateFileDto() { }

        public UpdateFileDto(UpdateFile updateFile) {
            _directory = updateFile.DestinationFolder;
            _file = updateFile.Name;
            _operation = DecodeUpdateOperation(updateFile.UpdateOperation);
            _updateType = DecodeUpdateType(updateFile.UpdateType);
        }

        private static string DecodeUpdateType(UpdateType updateType) {
            switch (updateType) {
                case Com.QueoMedia.Updater.Data.UpdateType.FILE:
                    return TypeFile;
                case Com.QueoMedia.Updater.Data.UpdateType.ZIP:
                    return TypeZip;
                default:
                    return TypeFile;
            }
        }

        private static string DecodeUpdateOperation(UpdateOperation updateOperation) {
            switch (updateOperation) {
                case UpdateOperation.ADD:
                    return OpAdd;
                case UpdateOperation.DEL:
                    return OpDel;
                default:
                    return OpAdd;
            }
        }

        public string Directory {
            get { return _directory; }
            set { _directory = value; }
        }

        public string File {
            get { return _file; }
            set { _file = value; }
        }

        public string Operation {
            get { return _operation; }
            set { _operation = value; }
        }

        public string UpdateType {
            get { return _updateType; }
            set { _updateType = value; }
        }

        public UpdateFile GenerateObject() {
            UpdateFile updateFile = new UpdateFile();
            updateFile.DestinationFolder = _directory;
            updateFile.Name = _file;
            updateFile.UpdateOperation = GetUpdateOperation();
            updateFile.UpdateType = GetUpdateType();
            return updateFile;
        }

        private UpdateType GetUpdateType() {
            switch (_updateType) {
                case TypeFile:
                    return Com.QueoMedia.Updater.Data.UpdateType.FILE;
                case TypeZip:
                    return Com.QueoMedia.Updater.Data.UpdateType.ZIP;
                default:
                    return Com.QueoMedia.Updater.Data.UpdateType.FILE;
            }
        }

        private UpdateOperation GetUpdateOperation() {
            switch (_operation) {
                case OpAdd:
                    return UpdateOperation.ADD;
                case OpDel:
                    return UpdateOperation.DEL;
                default:
                    return UpdateOperation.ADD;
            }
        }
    }
}
