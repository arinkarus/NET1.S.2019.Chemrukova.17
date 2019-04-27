using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    /// <summary>
    /// Time elapsed event args.
    /// </summary>
    public class TimeElapsedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets message.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeElapsedEventArgs" /> class.
        /// </summary>
        /// <param name="message">Given message.</param>
        public TimeElapsedEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
