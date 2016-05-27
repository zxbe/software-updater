using Com.QueoMedia.Updater.Data;

namespace UpdateServerManager2010Services
{
    public interface IZipUpdateFileService
    {
        bool FileIsUpdate(string filepath);
        VersionInformation GetVersionInformationFromZip(string zipfile);

        void ExtractUopdateZipToFolder(string zipfile, string folder);
    }
}