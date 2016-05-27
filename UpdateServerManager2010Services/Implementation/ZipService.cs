using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace UpdateServerManager2010Services.Implementation {
    class ZipService : IZipService {
        #region Implementation of IZipService

        public bool IsFileInZip(string zipfile, string filename)
        {
            try
            {
                using (FileStream fs = new FileStream(zipfile, FileMode.Open, FileAccess.Read))
                {
                    using (ZipFile zf = new ZipFile(fs))
                    {
                        var ze = zf.GetEntry(filename);
                        if (ze != null)
                        {
                            return true;
                        }
                    }
                }
            }catch{}
            return false;
        }

        public string ExtractFileToFolder(string zipfile, string file, string destinationFolder)
        {
            string resultPath = string.Empty;

            using (FileStream fs = new FileStream(zipfile, FileMode.Open, FileAccess.Read)) {
                using (ZipFile zf = new ZipFile(fs)) {
                    ZipEntry entry = zf.GetEntry(file);
                    using (FileStream outputStream = new FileStream(destinationFolder + file, FileMode.Create, FileAccess.Write)) {
                        ReadWriteStream(zf.GetInputStream(entry), outputStream);
                    }
                    resultPath = destinationFolder + file;

                }
            }

            return resultPath;
        }

        public void ExtractZipToFolder(string zipfile, string folder)
        {
            FastZip zip = new FastZip();
            zip.ExtractZip(zipfile, folder, "");
        }

        private static void ReadWriteStream(Stream readStream, Stream writeStream) {
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            // write the required bytes
            while (bytesRead > 0) {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }

        #endregion
    }
}
