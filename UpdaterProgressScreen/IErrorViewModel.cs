using System;

namespace UpdaterProgressScreen {
    public interface IErrorViewModel : IDetailViewModel {

        string ErrorMessage { get; }

        void LoadData(string errorMessage);
    }
}