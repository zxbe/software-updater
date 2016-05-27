using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

using com.queomedia.updater.data;
using com.queomedia.updater.utilities;

using log4net;

// Exit codes:
// 1 - args failure
// 2 - copy failed. backup restored

namespace UpdaterUpdate {
    internal class Program {
        private static ILog log;

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

        private static void Exit(int exitcode) {
            Environment.Exit(exitcode);
        }

        private static void Main(string[] args) {
            #region Add logging

            log = LogManager.GetLogger(typeof(Program));
            log.Debug("Starting updater update.");

            #endregion

            #region Wait for SoftwareUpdater.exe

            log.Info("Waiting for software updater process.");
            bool wait = true;
            while (wait) {
                foreach (Process clsProcess in Process.GetProcesses()) {
                    wait = (clsProcess.ProcessName.Contains("SoftwareUpdater") || clsProcess.ProcessName.Contains("SoftwareUpdater.vshost"));
                    if (wait) {
                        break;
                    }
                }
                Thread.Sleep(500);
            }

            #endregion

            #region Confirm args

            string filelist = "", downloads = "", backup = "", basepath = "", gui = "";
            if (args.Length == 5) {
                if (!File.Exists(args[0])) {
                    log.Info("Error within filelist path: " + args[0]);
                    Exit(1);
                }
                filelist = args[0];

                if (!Directory.Exists(args[1])) {
                    log.Info("Error within download path: " + args[1]);
                    Exit(1);
                }
                downloads = args[1];

                if (!Directory.Exists(args[2])) {
                    log.Info("Error within backup path: " + args[2]);
                    Exit(1);
                }
                backup = args[2];

                if (!Directory.Exists(args[3])) {
                    log.Info("Error within basepath: " + args[3]);
                    Exit(1);
                }
                basepath = args[3];

                if (!args[4].Contains("gui")) {
                    log.Info("Error within gui selector: " + args[4]);
                    Exit(1);
                }
                gui = args[4];
            } else {
                log.Info("Wrong args count.");
                foreach (string arg in args) {
                    log.Info(arg);
                }
                Exit(1);
            }

            #endregion

            #region Copy files

            // get filelist
            List<UpdateFile> filestocopy = DeSerializer.Deserializer<List<UpdateFile>>(filelist);
            // copy file from download dir
            try {
                CopyDirectory(downloads, basepath, true);
                log.Info("Copy of new updater software successfully finished.");
            } catch (Exception ex) {
                CopyDirectory(backup, basepath, true);
                log.Info(ex.Message);
                Exit(2);
            }

            #endregion

            #region Get version information

            string versioninfpath = backup.Replace("\\Backup", "");
            VersionInformation inf = DeSerializer.Deserializer<VersionInformation>(versioninfpath + Path.DirectorySeparatorChar + "info.xml");

            #endregion

            #region Update local information

            LocalInformation local = DeSerializer.Deserializer<LocalInformation>(basepath + Path.DirectorySeparatorChar + "info.xml");
            local.CurrentVersion = inf.ResultsInVersion;
            DeSerializer.Serialize(local, basepath + Path.DirectorySeparatorChar + "info.xml");

            #endregion

            #region Delete filelist

            if (File.Exists(filelist)) {
                File.Delete(filelist);
            }

            #endregion

            #region Start software updater

            Process proc = new Process();
            if (gui == "/nogui") {
                Process.Start(
                        new StringBuilder().Append(basepath).Append(Path.DirectorySeparatorChar).Append("SoftwareUpdater.exe").ToString(),
                        "/nogui");
            } else {
                Process.Start(
                        new StringBuilder().Append(basepath).Append(Path.DirectorySeparatorChar).Append("SoftwareUpdater.exe").ToString());
            }

            #endregion

            // exit with 0 when succesfully finished
            Exit(0);
        }
    }
}