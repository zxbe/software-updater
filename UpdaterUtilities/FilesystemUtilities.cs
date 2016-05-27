using System.IO;

namespace Com.QueoMedia.Updater.Utilities {
    public class FilesystemUtilities {
        /// <summary>
        ///     Copy directory.
        ///     Recursively copies a directory to a given destination.
        /// </summary>
        /// <param name="source">source Path to source directory</param>
        /// <param name="destination">destination Path to copy to</param>
        /// <param name="overwrite">overwrite Sets if existing files in destination should be overwritten</param>
        /// <returns>true if copy successfully finished</returns>
        public static bool CopyDirectory(string source, string destination, bool overwrite) {
            try {
                // Create the destination folder if missing.
                if (!Directory.Exists(destination)) {
                    Directory.CreateDirectory(destination);
                }

                DirectoryInfo dirInfo = new DirectoryInfo(source);

                // Copy all files.
                foreach (FileInfo fileInfo in dirInfo.GetFiles()) {
                    fileInfo.CopyTo(Path.Combine(destination, fileInfo.Name), overwrite);
                }

                // Recursively copy all sub-directories.
                foreach (DirectoryInfo subDirectoryInfo in dirInfo.GetDirectories()) {
                    CopyDirectory(subDirectoryInfo.FullName, Path.Combine(destination, subDirectoryInfo.Name), overwrite);
                }
            } catch {
                return false;
            }
            return true;
        }
    }
}