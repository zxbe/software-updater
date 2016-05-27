using System;
using System.Windows.Forms;

using Com.QueoMedia.Updater.Controller;
using Com.QueoMedia.Updater.Interfaces;

namespace com.queomedia.updater {
    internal static class Program {
        [STAThread]
        private static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool usegui = true;
            bool showProgress = false;

            /**
             * Check arguments.
             * /nogui - hides gui during update process.
             * /selectgui - shows a message box to select whether to show the gui or not.
             */
            if (args.Length > 0) {
                if (args[0] == "/nogui") {
                    usegui = false;
                } else if (args[0] == "/showProgress") {
                    usegui = false;
                    showProgress = true;
                }else if (args[0] == "/selectgui") {
                    if (MessageBox.Show("Gui benutzen ?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                        usegui = false;
                    }
                }
            }

            /**
             * Get main controller and start.
             */
            IMainUpdaterController mainController = new MainUpdaterController(usegui, showProgress);
            mainController.RequestExit += MainControllerRequestExit;
            mainController.Start();
            Application.Run();
        }

        private static void MainControllerRequestExit(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}