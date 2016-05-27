using System.IO;
using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services.Implementation {
    public class ZipUpdateFileService: IZipUpdateFileService {

        private readonly IZipService _zipService = new ZipService();
        private readonly IVersionInformationService _versionInfoService = new VersionInformationService();

        private const string InfoFile = "info.xml";

        #region Implementation of IZipUpdateFileService

        public bool FileIsUpdate(string filepath)
        {
            
            return _zipService.IsFileInZip(filepath, InfoFile);
        }

        public VersionInformation GetVersionInformationFromZip(string zipfile)
        {
            string extractedInfoXml = _zipService.ExtractFileToFolder(zipfile, InfoFile, Path.GetTempPath());
            return _versionInfoService.GetVersionInformationFromFile(extractedInfoXml);
        }

        public void ExtractUopdateZipToFolder(string zipfile, string folder)
        {
            _zipService.ExtractZipToFolder(zipfile, folder);
        }

        #endregion
    }
}
