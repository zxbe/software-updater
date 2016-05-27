namespace Com.QueoMedia.Updater.Utilities {
    /// <summary>
    ///     Quellen des Downloaders
    /// </summary>
    public enum DownloadSource {
        /// <summary>
        ///     Lokal
        /// </summary>
        Local,
        /// <summary>
        ///     Netzwerkfreigabe
        /// </summary>
        Network,
        /// <summary>
        ///     HTTP
        /// </summary>
        Http,
        /// <summary>
        ///     HTTP über Proxy
        /// </summary>
        Httpproxy,
        /// <summary>
        ///     HTTPS
        /// </summary>
        Https,
        /// <summary>
        ///     HTTPS über Proxy
        /// </summary>
        Httpsproxy,
    }
}