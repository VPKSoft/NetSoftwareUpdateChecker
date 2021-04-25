﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetSoftwareUpdateChecker
{
    /// <summary>
    /// A class to check application updates from RESTful endpoint or a JSON file in a WEB server.
    /// </summary>
    public class UpdateChecker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChecker"/> class.
        /// </summary>
        /// <param name="file">A value indicating whether the specified URL points to a file. Otherwise a RESTful endpoint is expected.</param>
        /// <param name="url">The URL to download the version data from.</param>
        public UpdateChecker(string url, bool file)
        {
            GetVersionDataFunc = async () =>
            {
                if (file)
                {
                    Stream stream;

                    if (File.Exists(url)) // test case..
                    {
                        stream = File.OpenRead(url);
                    }
                    else
                    {
                        var request = WebRequest.Create(url);
                        var response = await request.GetResponseAsync();
                        stream = response.GetResponseStream();
                    }

                    var bytes = new byte[BufferSize];

                    int length;

                    var memoryStream = new MemoryStream();

                    while ((length = await stream.ReadAsync(bytes)) > 0)
                    {
                        memoryStream.Write(bytes, 0, length);
                    }

                    var result =
                        JsonConvert.DeserializeObject<List<UpdateData>>(
                            Encoding.UTF8.GetString(memoryStream.ToArray()));

                    await stream.DisposeAsync();
                    return result?.ToArray() ?? Array.Empty<UpdateData>();
                }
                else
                {
                    var result = await HttpClient.GetFromJsonAsync<IEnumerable<UpdateData>>(url);
                    return (result ?? Array.Empty<UpdateData>()).ToArray();
                }
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChecker"/> class.
        /// </summary>
        /// <param name="getVersionDataFunc">The custom get version data function to retrieve the version data.</param>
        public UpdateChecker(Func<Task<UpdateData[]>> getVersionDataFunc)
        {
            GetVersionDataFunc = getVersionDataFunc;
        }

        /// <summary>
        /// Gets or sets the size of the buffer for stream data reading.
        /// </summary>
        /// <value>The size of the buffer for stream data reading.</value>
        public int BufferSize { get; set; } = ushort.MaxValue;

        /// <summary>
        /// An event which occurs if an exception occurs during the update check.
        /// </summary>
        public static EventHandler<ExceptionEventArgs>? ExceptionOccurred;

        /// <summary>
        /// Gets the software update data.
        /// </summary>
        /// <returns>The software update data.</returns>
        public async Task<UpdateData[]> GetUpdateData()
        {
            try
            {
                return await GetVersionDataFunc();
            }
            catch (Exception ex)
            {
                ExceptionOccurred?.Invoke(this, new ExceptionEventArgs {Exception = ex});
                return Array.Empty<UpdateData>();
            }
        }

        /// <summary>
        /// Gets the HTTP client to use to get JSON data for the class.
        /// </summary>
        /// <value>The HTTP client to use to get JSON data for the class.</value>
        private HttpClient HttpClient { get; } = new();

        /// <summary>
        /// Gets or sets the get version data fetch function.
        /// </summary>
        /// <value>The get version data fetch function.</value>
        public Func<Task<UpdateData[]>> GetVersionDataFunc { get; set; }
    }
}
