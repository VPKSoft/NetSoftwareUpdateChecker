using System;
using Newtonsoft.Json;

namespace NetSoftwareUpdateChecker
{
    /// <summary>
    /// A class for one version entry to included in a JSON data containing the software update information.
    /// </summary>
    public class UpdateData
    {
        /// <summary>
        /// Gets or sets the name of the software.
        /// </summary>
        /// <value>The name of the software.</value>
        public string SoftwareName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the software version.
        /// </summary>
        /// <value>The software version.</value>
        public string SoftwareVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the software version string, i.e. "beta2".
        /// </summary>
        /// <value>The software version string.</value>
        public string? SoftwareVersionString { get; set; }

        /// <summary>
        /// Gets or sets the version title. 
        /// </summary>
        /// <value>The version title.</value>
        public string? VersionTitle { get; set; }

        /// <summary>
        /// Gets or sets the version changes.
        /// </summary>
        /// <value>The version changes.</value>
        public string VersionChanges { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the localized version changes.
        /// </summary>
        /// <value>The localized version changes.</value>
        public VersionChangeLocalized[]? VersionChangesLocalized { get; set; }

        /// <summary>
        /// Gets or sets the release date and time.
        /// </summary>
        /// <value>The release date and time.</value>
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// Gets or sets the download URL.
        /// </summary>
        /// <value>The download URL.</value>
        public string DownloadUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="DownloadUrl"/> is direct download.
        /// </summary>
        /// <value><c>true</c> if the <see cref="DownloadUrl"/> is direct download; otherwise, <c>false</c>.</value>
        public bool IsDirectDownload { get; set; }

        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>The copyright.</value>
        public string? Copyright { get; set; }

        /// <summary>
        /// Gets or sets the license identifier (SPDX).
        /// </summary>
        /// <value>The license identifier.</value>
        public string? LicenseIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the license text.
        /// </summary>
        /// <value>The license text.</value>
        public string? LicenseText { get; set; }

        /// <summary>
        /// Gets the version as a <see cref="Version"/>.
        /// </summary>
        /// <value>The version as a <see cref="Version"/>.</value>
        [JsonIgnore]
        public Version Version
        {
            get
            {
                try
                {
                    return System.Version.Parse(SoftwareVersion);
                }
                catch (Exception ex)
                {
                    UpdateChecker.ExceptionOccurred?.Invoke(this, new ExceptionEventArgs {Exception = ex});
                    return new Version();
                }
            }
        }
    }
}
