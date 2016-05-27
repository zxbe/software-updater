namespace UpdateServerManager2010Services
{
    public interface IZipService
    {
        bool IsFileInZip(string zipfile, string filename);
        string ExtractFileToFolder(string zipfile, string file, string destinationFolder);
        void ExtractZipToFolder(string zipfile, string folder);
    }
}