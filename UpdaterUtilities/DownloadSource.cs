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
        ///     HTTP �ber Proxy
        /// </summary>
        Httpproxy,
        /// <summary>
        ///     HTTPS
        /// </summary>
        Https,
        /// <summary>
        ///     HTTPS �ber Proxy
        /// </summary>
        Httpsproxy,
    }
}