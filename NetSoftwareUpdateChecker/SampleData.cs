using System;
using System.Diagnostics.CodeAnalysis;

namespace NetSoftwareUpdateChecker
{
    /// <summary>
    /// A class to provide simple sample data for the <see cref="UpdateData"/> class.
    /// </summary>
    public class SampleDataProvider
    {
        /// <summary>
        /// Gets the sample data.
        /// </summary>
        /// <value>The sample data.</value>
        [SuppressMessage("ReSharper", "StringLiteralTypo")] // this method contains Finnish text..
        public static UpdateData[] SampleData =>
            new[]
            {
                new UpdateData
                {
                    SoftwareName = "Test Application", SoftwareVersion = "1.0.1",
                    SoftwareVersionString = "beta",
                    VersionChanges = "* fix bug no. #1\n* update dependencies",
                    ReleaseTime = DateTime.UtcNow,
                    VersionTitle = "Bug fixes and maintenance",
                    DownloadUrl = "https://www.vpksoft.net",
                    IsDirectDownload = false,
                    LicenseIdentifier = "MIT",
                    VersionChangesLocalized = new[]
                    {
                        new VersionChangeLocalized
                        {
                            Locale = "fi",
                            VersionTitle = "Bugikorjauksia ja ylläpitoa",
                            VersionChanges = "* korjattu bugi nro. #1\n* päivitettty riippuvuudet",
                        },
                        new VersionChangeLocalized
                        {
                            VersionTitle = "Bug fixes and maintenance",
                            Locale = "en-US",
                            VersionChanges = "* fix bug no. #1\n* update dependencies",
                        }
                    }
                }
            };
    }
}
