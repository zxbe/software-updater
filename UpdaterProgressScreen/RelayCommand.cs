using System;
using System.Diagnostics;
using System.Windows.Input;

namespace UpdaterProgressScreen {
    /// <summary>
    ///     Klasse zum Binden von Commands des ViewModels an Elemente der View
    ///     Methoden werden im ViewModel mittels Methoden Delegate aufgerufen
    /// </summary>
    public class RelayCommand : ICommand {
        private readonly Func<bool> _canExecute;
        private readonly string _commandName;
        private readonly Action _execute;

        /// <summary>
        ///     Erzeugt einen RelayCommand mit einem Namen, einem Methoden Delegaten und einem Predicate Delegaten welche beide
        ///     einen Parameter übergeben.
        ///     Der Methoden Delegate stellt die Execute Methode des ICommand Interfaces dar.
        ///     Der Predicate Delegate stellt die CanExecute Methode dar.
        /// </summary>
        /// <param name="execute">Der Methoden Delegate für die Execute Methode</param>
        /// <param name="canExecute">Der Predicate Delegate für die CanExecute Methode</param>
        /// <param name="commandName">Der Name des Commands</param>
        public RelayCommand(string commandName, Action execute, Func<bool> canExecute = null)
                : this(execute, canExecute) {
            _commandName = commandName;
        }

        /// <summary>
        ///     Erzeugt einen RelayCommand mit einem Namen, einem Methoden Delegaten und einem Predicate Delegaten welche beide
        ///     einen Parameter übergeben.
        ///     Der Methoden Delegate stellt die Execute Methode des ICommand Interfaces dar.
        ///     Der Predicate Delegate stellt die CanExecute Methode dar.
        /// </summary>
        /// <param name="execute">Der Methoden Delegate für die Execute Methode</param>
        /// <param name="canExecute">Der Predicate Delegate für die CanExecute Methode</param>
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            if (execute == null) {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        ///     Wird gefuert wenn sich der CanExecute Status des Commands ändert.
        /// </summary>
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        ///     Der Name des Commands, kann für die Beschriftung von Button und MenuItems genutzt werden.
        /// </summary>
        public string CommandName {
            get { return _commandName; }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter) {
            return _canExecute == null || _canExecute();
        }
        
        /// <summary>
        ///     Für die Methode aus die an die als Methoden Delegate im Konstruktor übergebn wurde
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter) {
            _execute();
        }
        

    }
}