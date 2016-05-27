namespace Com.QueoMedia.Updater.Utilities {
    /// <summary>
    ///     Status des Downloaders
    /// </summary>
    public enum DownloaderState {
        /// <summary>
        ///     Kann auf Ziel nicht zugreifen
        /// </summary>
        ErrorDestinationNotAccessible,
        /// <summary>
        ///     Download fehlegschlagen
        /// </summary>
        ErrorDownloadFailed,
        /// <summary>
        ///     Donload l�uft
        /// </summary>
        Running,
        /// <summary>
        ///     Alles i.o.
        /// </summary>
        OK
    }
}