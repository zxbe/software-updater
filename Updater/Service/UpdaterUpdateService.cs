using System.IO;

using Com.QueoMedia.Updater.Data;

namespace Com.QueoMedia.Updater.Service {
    /**
     * Copies remote file to local for updater update.
     */

    internal class UpdaterUpdateService : BaseFileUpdaterService {
        /**
         * Add file.
         * @param version version currently working on
         * @param file information about file to add
         * @return update status
         */

        public UpdateStatus AddFile(string version, UpdateFile file) {
            // Get file from remote location.
            string localPath = base.CopyFileToLocal(version, file);
            if (localPath == "0") {
                return UpdateStatus.FAILED;
            }
            // Check if file exists afterwards.
            if (!File.Exists(localPath)) {
                return UpdateStatus.FAILED;
            }
            return UpdateStatus.OK;
        }
    }
}