using System;

namespace NetSoftwareUpdateChecker
{
    /// <summary>
    /// Event arguments for an event to report exceptions for a class library to the client software.
    /// Implements the <see cref="System.EventArgs" />
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class ExceptionEventArgs: EventArgs
    {
        /// <summary>
        /// Gets or sets the exception which occurred.
        /// </summary>
        /// <value>The exception which occurred.</value>
        public Exception Exception { get; set; } = new();
    }
}
