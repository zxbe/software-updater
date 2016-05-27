using System.Text;

namespace com.queomedia.updater.data {
    public class VersionNumber {
        private string build;
        private string major;
        private string minor;
        private string revision;

        public VersionNumber() {
        }

        public VersionNumber(string number) {
            string[] splited = number.Split('.');
            if (splited.Length == 4) {
                Prefill(splited[0], splited[1], splited[2], splited[3]);
            }
        }

        public string Build {
            get { return build; }
            set { build = value; }
        }

        public string Major {
            get { return major; }
            set { major = value; }
        }

        public string Minor {
            get { return minor; }
            set { minor = value; }
        }

        public string Revision {
            get { return revision; }
            set { revision = value; }
        }

        public void Prefill(string major, string minor, string build, string revision) {
            this.major = major;
            this.minor = minor;
            this.build = build;
            this.revision = revision;
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            builder.Append(major).Append(".");
            builder.Append(minor).Append(".");
            builder.Append(build).Append(".");
            builder.Append(revision);
            return builder.ToString();
        }
    }
}