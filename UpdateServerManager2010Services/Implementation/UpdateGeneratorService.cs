using System.Collections.Generic;
using System.IO;
using Com.QueoMedia.Updater.Data;
using Com.QueoMedia.Updater.Utilities;
using ICSharpCode.SharpZipLib.Zip;

namespace UpdateServerManager2010Services.Implementation {
    public class UpdateGeneratorService: IUpdateGeneratorService {
        #region Implementation of IUpdateGeneratorService

        public string GenerateUpdate(string workFolder, string zipDestination, VersionNumber appliesTo, VersionNumber resultsIn, IList<UpdateFile> files)
        {
            string finalFile = workFolder + Path.DirectorySeparatorChar + resultsIn + ".zip";

            // check if zipDestination exists
            if (!Directory.Exists(zipDestination))
            {
                throw new DirectoryNotFoundException("zipDestination: " + zipDestination);
            }

            // regenerate local work folder
            if (Directory.Exists(workFolder))
                Directory.Delete(workFolder, true);
            Directory.CreateDirectory(workFolder);

            // copy files to  workFolder and generate folder structure
            foreach (UpdateFile file in files)
            {
                if (!Directory.Exists(workFolder + Path.DirectorySeparatorChar + file.DestinationFolder))
                    Directory.CreateDirectory(workFolder + Path.DirectorySeparatorChar + file.DestinationFolder);
                File.Copy(file.Name, workFolder + Path.DirectorySeparatorChar + file.DestinationFolder + Path.DirectorySeparatorChar + Path.GetFileName(file.Name));
                file.Name = Path.GetFileName(file.Name);
            }

            // generate info.xml
            VersionInformation info =new VersionInformation();
            info.AppliesToVersion = appliesTo;
            info.ResultsInVersion = resultsIn;
            info.Files = files as List<UpdateFile>;
            DeSerializer.Serialize(info, workFolder + Path.DirectorySeparatorChar + "info.xml");

            // zip that stuff and copy zip to zipDestination);))
            FastZip zip = new FastZip();
            zip.CreateZip(zipDestination + Path.DirectorySeparatorChar + Path.GetFileName(finalFile), workFolder, true, "");

            //File.Copy(finalFile, zipDestination + Path.DirectorySeparatorChar + Path.GetFileName(finalFile));

            if (Directory.Exists(workFolder))
                Directory.Delete(workFolder, true);

            return zipDestination + Path.DirectorySeparatorChar + Path.GetFileName(finalFile);
        }

        #endregion
    }
}
