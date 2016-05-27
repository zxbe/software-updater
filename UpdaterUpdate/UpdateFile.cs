namespace UpdaterUpdate {
    public enum UpdateOperation {
        ADD,
        DEL
    }

    public enum UpdateType {
        MSP,
        SQL,
        ZIP,
        FILE,
        UPDATER
    }

    public class UpdateFile {
        private string destinationFolder;
        private string name;
        private UpdateOperation updateOperation;
        private UpdateType updateType;

        public string DestinationFolder {
            get { return destinationFolder; }
            set { destinationFolder = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public UpdateOperation UpdateOperation {
            get { return updateOperation; }
            set { updateOperation = value; }
        }
        public UpdateType UpdateType {
            get { return updateType; }
            set { updateType = value; }
        }

        public override string ToString() {
            return name + " -> " + destinationFolder;
        }
    }
}