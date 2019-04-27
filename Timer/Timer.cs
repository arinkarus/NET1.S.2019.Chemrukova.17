using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Timer
{
    /// <summary>
    /// Timer class - instanse of this class is observable.
    /// </summary>
    public sealed class Timer
    {
        /// <summary>
        /// Inner timer.
        /// </summary>
        private System.Timers.Timer innerTimer;

        /// <summary>
        /// Time elapsed event.
        /// </summary>
        public event EventHandler<TimeElapsedEventArgs> TimeElapsed;

        /// <summary>
        /// Pass a message to all listeners. 
        /// </summary>
        /// <param name="time">Given time.</param>
        /// <param name="message">Given message</param>
        public void Pass(double time, string message)
        {
            innerTimer = new System.Timers.Timer(time);
            innerTimer.AutoReset = false;
            innerTimer.Elapsed += (obj, args) => OnTimeElapsed(message);
            innerTimer.Start();
        }

        private void OnTimeElapsed(string message)
        {
            var timeElapsed = TimeElapsed;
            innerTimer.Stop();
            innerTimer.Dispose();
            timeElapsed?.Invoke(this, new TimeElapsedEventArgs(message));
        }
    }
}
