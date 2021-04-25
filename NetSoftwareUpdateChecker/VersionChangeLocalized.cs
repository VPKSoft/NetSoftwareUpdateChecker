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
