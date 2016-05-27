using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace com.queomedia.updater.utilities {
    public class DeSerializer {
        public static T Deserializer<T>(string file) {
            T result = default(T);
            try {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                TextReader txtReader = new StreamReader(file, Encoding.Default);
                result = (T)deserializer.Deserialize(txtReader);
                txtReader.Close();
            } catch {
            }
            return result;
        }

        public static bool Serialize<T>(T data, string file) {
            bool result = false;
            try {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextWriter txtWriter = new StreamWriter(file, false, Encoding.Default, 1024);
                serializer.Serialize(txtWriter, data);
                txtWriter.Close();
                result = true;
            } catch {
            }
            return result;
        }
    }
}