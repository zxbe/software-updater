using System.ComponentModel;

namespace Com.QueoFlow.Commons.MVVM.ViewModels {
    /// <summary>
    ///     Die Schnittstellenbeschreibung f�r ein ViewModel
    /// </summary>
    public interface IViewModelBase {
        /// <summary>
        ///     Wird gefeuert wenn ein Property des ViewModels sich �ndert.
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        ///     Liefert und setzt den Anzeigenamen des ViewModels meist f�r Fenster�berschriften verwendet.
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>
        ///     Gibt an ob das ViewModel verf�gbar ist. Default: TRUE.
        /// </summary>
        bool IsEnabled { get; set; }
        /// <summary>
        ///     Liefert oder setzt das ViewModel in den IsLoading Zustand, dabei wird ein <see cref="CursorEvent" /> ausgel�st.
        /// </summary>
        bool IsLoading { get; set; }

        /// <summary>
        ///     Invoked when this object is being removed from the application and will be subject to garbage collection.
        /// </summary>
        void Dispose();
    }
}