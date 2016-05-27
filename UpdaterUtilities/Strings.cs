namespace Com.QueoMedia.Updater.Utilities {
    /**
     * Various predefined strings.
     * Various strings for transfer protocoll search, foldernames, filenames, errors and messages.
     */

    public class Strings {
        /// <summary>
        ///     Trennlinie
        /// </summary>
        public const string COMMON_SEPARATOR = "----------------------------------------------";
        /// <summary>
        ///     Trenner z.b. zwischen W�rtern
        /// </summary>
        public const string CommonMessageSeperator = " - ";

        /// <summary>
        ///     Fehler: abrufen der lokalen Versionsinformationen
        /// </summary>
        public const string ERROR_GET_LOCAL = "Fehler beim Abrufen der lokalen Versionsinformation";
        /// <summary>
        ///     Fehler: abrufen der Versions�bersicht
        /// </summary>
        public const string ERROR_GET_OVERVIEW = "Fehler beim Abrufen der Versions�bersicht";
        /// <summary>
        ///     Fehler: abrufen der entfernten Versionsinformationen
        /// </summary>
        public const string ERROR_GET_VERSIONS = "Fehler beim Abrufen einer entfernten Versionsinformation";
        /// <summary>
        ///     Datei lokale Informationen: info.xml
        /// </summary>
        public const string FILE_LOCAL_INFORMATION = "info.xml";
        /// <summary>
        ///     Datei serverseitige Versionsinformationen
        /// </summary>
        public const string FILE_OVERVIEW = "overview.xml";
        /// <summary>
        ///     Datei serverseitige Informationen
        /// </summary>
        public const string FILE_VERSION_INFORMATION = "info.xml";
        /// <summary>
        ///     Temp. Download Ordner
        /// </summary>
        public const string FOLDER_TEMP_DOWNLOAD = "Downloads";
        /// <summary>
        ///     Order der Updateinformationen
        /// </summary>
        public const string FOLDER_UPDATE_INFORMATION = "UpdateInformation";
        /// <summary>
        ///     Backupordner
        /// </summary>
        public const string FOLDER_VERSION_BACKUP = "Backup";
        /// <summary>
        ///     L�dt
        /// </summary>
        public const string LOADING = "- lade -";
        /// <summary>
        ///     Fehler: hinzuf�gen gehlgeschlagen
        /// </summary>
        public const string MESSAGE_ADDING_FAILED = "Hinzuf�gen fehlgeschlagen.";
        /// <summary>
        ///     F�ge Datei hinzu
        /// </summary>
        public const string MESSAGE_ADDING_FILE_TBC = "F�ge Datei hinzu: ";
        /// <summary>
        ///     Update �ber alle neueren Versionen
        /// </summary>
        public const string MESSAGE_APPLY_UPDATES = "Update �ber alle neueren Versionen.";
        /// <summary>
        ///     Abrufen der lokalen Versionsinformationen
        /// </summary>
        public const string MESSAGE_AQUIRE_LOCAL_INFORMATION = "Abrufen der lokalen Versionsinformation...";
        /// <summary>
        ///     Abrufen der entfernten Versionsinformationen
        /// </summary>
        public const string MESSAGE_AQUIRE_REMOTE_INFORMATION = "Abrufen einer entfernten Versionsinformation ...";
        /// <summary>
        ///     Abrufen der Versions�bersicht
        /// </summary>
        public const string MESSAGE_AQUIRE_REMOTE_OVERIEW = "Abrufen der Versions�bersicht ...";
        /// <summary>
        ///     Backup
        /// </summary>
        public const string MESSAGE_BACKUP_TBC = "Backup: ";

        /// <summary>
        /// Pr�fe temp. Download Ordner
        /// </summary>
        public const string MESSAGE_CHECKING_TEMP_DOWNLOAD_FOLDER = "Pr�fe tempor�ren Download Ordner ...";
        /// <summary>
        /// Pr�fe Verzeichnis der Versionsinformationen
        /// </summary>
        public const string MESSAGE_CHECKING_UPDATE_INFORMATION_FOLDER = "Pr�fe Verzeichniss f�r Versionsinformationen ...";
        /// <summary>
        /// Erzeuge Backup
        /// </summary>
        public const string MESSAGE_CREATING_BACKUP = "Erzeuge Backup ...";
        /// <summary>
        /// L�sche Backup
        /// </summary>
        public const string MESSAGE_DELETE_BACKUP = "L�sche Backup";
        /// <summary>
        /// L�sche Verzeichnis f�r Versionsinformationen
        /// </summary>
        public const string MESSAGE_DELETE_UPDATE_INFORMATION_FOLDER = "L�sche Verzeichniss f�r Versionsinformationen ...";
        /// <summary>
        /// L�schen fehlgechlagen
        /// </summary>
        public const string MESSAGE_DELETING_FAILED = "L�schen fehlgeschlagen.";
        /// <summary>
        /// L�sche Datei
        /// </summary>
        public const string MESSAGE_DELETING_FILE_TBC = "L�sche Datei: ";
        /// <summary>
        /// Download fehlgeschlagen
        /// </summary>
        public const string MESSAGE_DOWNLOAD_FAILED = "Download fehlgeschlagen.";
        /// <summary>
        /// Download abgeschlossen
        /// </summary>
        public const string MESSAGE_DOWNLOAD_FINISHED = "Download abgeschlossen.";
        /// <summary>
        /// Downloade
        /// </summary>
        public const string MESSAGE_DOWNLOADING_TBC = "Downloade: ";
        /// <summary>
        /// Beende Update
        /// </summary>
        public const string MESSAGE_END_UPDATE = "Beende Update ...";
        /// <summary>
        /// Entpacke ZIP
        /// </summary>
        public const string MESSAGE_EXTRACTING_ZIP = "Entpacke ZIP Archiv ...";
        /// <summary>
        /// Keine neueren Versionen gefunden
        /// </summary>
        public const string MESSAGE_NO_NEW_VERSION = "Keine neuere Version gefunden.";
        /// <summary>
        /// Stelle Backup wieder her
        /// </summary>
        public const string MESSAGE_RESTORING_BACKUP = "Stelle Backup wieder her ...";
        /// <summary>
        /// Starte Update
        /// </summary>
        public const string MESSAGE_START_UPDATE = "Starte Update ...";

        /// <summary>
        /// Update erfolgreich abgeschlossen
        /// </summary>
        public const string MESSAGE_UPDATE_COMPLETED_SUCCESSFULLY = "Update erfolgreich abgeschlossen.";
        /// <summary>
        /// Benutzeroberfl�che
        /// </summary>
        public const string MESSAGE_USE_GUI_TBC = "Benutzeroberfl�che: ";
        /// <summary>
        /// Arbeitsversion
        /// </summary>
        public const string MESSAGE_WORKING_VERSION_TBC = "Arbeitsversion: ";
        /// <summary>
        /// Keine �nderungen
        /// </summary>
        public const string NO_NEW_VERSION = "Keine �nderungen";
        /// <summary>
        /// 
        /// </summary>
        public const string SEARCHSTRING_HTTP = "://";
        /// <summary>
        /// 
        /// </summary>
        public const string SEARCHSTRING_HTTPS = "://";
        /// <summary>
        /// 
        /// </summary>
        public const string SEARCHSTRING_LOCAL = ":\\";
        /// <summary>
        /// 
        /// </summary>
        public const string STARTSTRING_HTTPS = "https://";
        /// <summary>
        /// 
        /// </summary>
        public const string STARTSTRING_LAN = "\\";
    }
}