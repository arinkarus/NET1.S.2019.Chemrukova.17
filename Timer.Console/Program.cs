using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Console
{
    class FirstListener
    {
        public void GetMessage(object sender, EventArgs args)
        {
            TimeElapsedEventArgs timeElapsedEventArgs = args as TimeElapsedEventArgs;
            System.Console.WriteLine($"First listener gets message: {timeElapsedEventArgs.Message}");
        }
    }

    class SecondListener
    {
        public void ProcessMessage(object sender, EventArgs args)
        {
            TimeElapsedEventArgs timeElapsedEventArgs = args as TimeElapsedEventArgs;
            System.Console.WriteLine($"Second listener gets message: {timeElapsedEventArgs.Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();
            var firstListener = new FirstListener();
            var secondListener = new SecondListener();
            timer.TimeElapsed += firstListener.GetMessage;
            timer.TimeElapsed += secondListener.ProcessMessage;
            timer.Pass(1000, "Hello world");
            timer.Pass(500, "Message");
            System.Console.ReadLine();
        }
    }
}
