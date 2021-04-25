#region License
/*
MIT License

Copyright(c) 2021 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

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
