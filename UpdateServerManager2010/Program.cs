using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UpdateServerManager2010.Views.Main.Controller;
using UpdateServerManager2010.Views.Main.Controller.Implementation;
using UpdateServerManager2010.Views.Main.Winform.Implementation;

namespace UpdateServerManager2010 {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            IMainViewController mainController = new MainViewController(new MainForm());
            Application.Run(mainController.GetAttachedForm().GetAsForm());
        }
    }
}
