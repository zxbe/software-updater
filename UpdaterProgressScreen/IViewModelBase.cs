using System.ComponentModel;

namespace Com.QueoFlow.Commons.MVVM.ViewModels {
    /// <summary>
    ///     Die Schnittstellenbeschreibung für ein ViewModel
    /// </summary>
    public interface IViewModelBase {
        /// <summary>
        ///     Wird gefeuert wenn ein Property des ViewModels sich ändert.
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        ///     Liefert und setzt den Anzeigenamen des ViewModels meist für Fensterüberschriften verwendet.
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>
        ///     Gibt an ob das ViewModel verfügbar ist. Default: TRUE.
        /// </summary>
        bool IsEnabled { get; set; }
        /// <summary>
        ///     Liefert oder setzt das ViewModel in den IsLoading Zustand, dabei wird ein <see cref="CursorEvent" /> ausgelöst.
        /// </summary>
        bool IsLoading { get; set; }

        /// <summary>
        ///     Invoked when this object is being removed from the application and will be subject to garbage collection.
        /// </summary>
        void Dispose();
    }
}