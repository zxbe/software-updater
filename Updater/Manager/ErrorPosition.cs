namespace Com.QueoMedia.Updater.Manager {
    /// <summary>
    ///     Stellen, an denen ein Fehler aufgetreten ist.
    /// </summary>
    public enum ErrorPosition {
        /// <summary>
        ///     lokale info.xml
        /// </summary>
        Localinformation,
        /// <summary>
        ///     overview.xml
        /// </summary>
        Overview,
        /// <summary>
        ///     info.xml serverseitig
        /// </summary>
        Remoteinformation
    }
}