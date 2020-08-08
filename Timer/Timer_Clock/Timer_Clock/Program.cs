using System;
using System.Timers;

namespace Timer_Clock
{
    public class Program
    {
        //Creating an instance of the Class Time
        private static Timer aTimer;
        public static void Main(string[] args)
        {
            // Create a timer.
            aTimer = new Timer();

            //One second interval.
            aTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();

        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime.TimeOfDay);
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime.ToLongTimeString());
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime.ToString("hh:mm:ss"));
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime.ToString("H:mm:ss"));
            Console.WriteLine("The Elapsed event was raised at " + e.SignalTime.Hour + ":" + e.SignalTime.Minute + ":" + e.SignalTime.Second);
        }
    }
}