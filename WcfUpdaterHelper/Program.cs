using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WcfUpdaterHelper.WcfUpdaterService;

namespace WcfUpdaterHelper {
    static class Program {

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            UpdateWcfServiceClient client = new UpdateWcfServiceClient();
            client.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(5);
            string appToOpen = "";
            try {
                client.Open();
                appToOpen = client.DoUpdate(Application.StartupPath);
                client.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + CombineMessages(ex));
            }
            if (string.IsNullOrEmpty(appToOpen))
                return;

            if (!File.Exists(appToOpen))
                return;

            Process exe = new Process {StartInfo = {FileName = appToOpen}};
            exe.Start();
        }

        private static string CombineMessages(Exception exception)
        {
            string result = "";
            if (exception.InnerException != null)
                result = CombineMessages(exception.InnerException);
            return exception.Message + "\n" + result;
        }
    }
}
