using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace Com.QueoFlow.Commons.MVVM.ViewModels {
    /// <summary>
    ///   Die Basis-Klasse für alle ViewModels. Diese Klasse bietet die Methoden zum Exceptionhandling und für das PropertyChanged Event.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable, IViewModelBase {
        private bool _isLoading;
        private bool _isEnabled = true;

        /// <summary>
        ///   Liefert und setzt den Anzeigenamen des ViewModels meist für Fensterüberschriften verwendet.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        ///   Liefert oder setzt das ViewModel in den IsLoading Zustand, dabei wird ein <see cref="CursorEvent" /> ausgelöst.
        /// </summary>
        public bool IsLoading {
            get { return _isLoading; }
            set {
                if (value != _isLoading) {
                    _isLoading = value;
                }
                OnPropertyChanged(this.GetPropertyName(m => m.IsLoading));
            }
        }

        /// <summary>
        ///   Gibt an ob das ViewModel verfügbar ist. Default: TRUE.
        /// </summary>
        public bool IsEnabled {
            get { return _isEnabled; }
            set {
                if (_isEnabled != value) {
                    _isEnabled = value;
                    OnPropertyChanged(this.GetPropertyName(m => m.IsEnabled));
                }
            }
        }

        /// <summary>
        /// Setzt den übergeben Wert <param name="value"></param> auf das BackingField <param name="storage"></param> des Properties und löst das PropertyChangedEvent aus sofern sich der Wert geändert hat.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage">Das BackingField des Properties</param>
        /// <param name="value">Der zu setzende Wert</param>
        /// <param name="propertyName">Der Name des Properties</param>
        /// <returns>true, wenn sich das Property geändert hat</returns>
        protected bool SetProperty<T>(ref T storage, T value, String propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value)) {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        ///   Wird gefeuert wenn ein Property des ViewModels sich ändert.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///   Feuert das PropertyChanged Ereignis
        /// </summary>
        /// <param name="propertyName"> Das Property, dessen Name sich geändert hat </param>
        protected virtual void OnPropertyChanged(string propertyName) {
            //VerifyPropertyName(propertyName);
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        /// <summary>
        ///   Invoked when this object is being removed from the application and will be subject to garbage collection.
        /// </summary>
        public void Dispose() {
            OnDispose();
        }

        /// <summary>
        ///   Child classes can override this method to perform clean-up logic, such as removing event handlers.
        /// </summary>
        protected virtual void OnDispose() {
        }

#if DEBUG
        /// <summary>
        ///   Useful for ensuring that ViewModel objects are properly garbage collected.
        /// </summary>
        ~ViewModelBase() {
            string msg = string.Format("{0} ({1}) ({2}) Finalized", GetType().Name, DisplayName, GetHashCode());
            Debug.WriteLine(msg);
        }
#endif
    }
}