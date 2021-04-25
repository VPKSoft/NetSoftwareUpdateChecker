namespace NetSoftwareUpdateChecker
{
    /// <summary>
    /// A class to localize version changes.
    /// </summary>
    public class VersionChangeLocalized
    {
        /// <summary>
        /// Gets or sets the locale. I.e. "en", "fi", etc.
        /// </summary>
        /// <value>The locale.</value>
        public string Locale { get; set; } = "en-US";

        /// <summary>
        /// Gets or sets the version changes.
        /// </summary>
        /// <value>The version changes.</value>
        public string VersionChanges { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version title. 
        /// </summary>
        /// <value>The version title.</value>
        public string? VersionTitle { get; set; }
    }
}
