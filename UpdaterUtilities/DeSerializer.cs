using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Com.QueoMedia.Updater.Data;

namespace Com.QueoMedia.Updater.Utilities {
    /// <summary>
    ///     DeSerializer. Serialize and deserialize classes to and from xml files.
    /// </summary>
    public class DeSerializer {
        /// <summary>
        ///     Deserialize class T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file">file filename from file to deserialize</param>
        /// <returns>T class of type T</returns>
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

        /// <summary>
        ///     Serialize class T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">data input data of type T</param>
        /// <param name="file">file filename to serialize to</param>
        /// <returns>true if finished without error</returns>
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

        /// <summary>
        ///     Seerialisiert in einen XML string.
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static string SerializeToString(LocalInformation local) {
            throw new NotImplementedException();
        }
    }
}