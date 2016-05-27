using System.Windows;
using System.Windows.Controls;

namespace UpdaterProgressScreen {
    public class DetailTemplateSelector : DataTemplateSelector {
        public DataTemplate ErrorTemplate { get; set; }

        public DataTemplate ProgressTemplate { get; set; }

        /// <summary>
        ///     Gibt beim Überschreiben in einer abgeleiteten Klasse ein <see cref="T:System.Windows.DataTemplate" />-Objekt auf
        ///     der Grundlage einer benutzerdefinierten Logik zurück.
        /// </summary>
        /// <returns>
        ///     Gibt eine <see cref="T:System.Windows.DataTemplate" /> oder null zurück. Der Standardwert ist null.
        /// </returns>
        /// <param name="item">Das Datenobjekt, für das die Vorlage ausgewählt werden soll.</param>
        /// <param name="container">Das datengebundene Objekt.</param>
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            if (item is IProgressViewModel) {
                return ProgressTemplate;
            } else if (item is IErrorViewModel) {
                return ErrorTemplate;
            }
            return null;
        }
    }
}