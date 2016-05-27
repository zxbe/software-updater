using System;
using System.Windows.Forms;

using UpdateGenerationWizard2010.Views.Wizard.Controller;
using UpdateGenerationWizard2010.Views.Wizard.Controller.Implementation;
using UpdateGenerationWizard2010.Views.Wizard.Winform.Implementation;

namespace UpdateGenerationWizard2010 {
    internal static class Program {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUpdateGeneratorController genController = new UpdateGeneratorController(new UpdateGeneratorWizard());
            Application.Run(genController.GetAttachedForm().GetAsForm());
        }
    }
}