using System;

namespace Date_time
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Today;
            DateTime currentTime = DateTime.Now;
            DateTime currentUtc = DateTime.UtcNow;

            Console.WriteLine("\nToday");
            Console.WriteLine(currentDate);
            Console.WriteLine(currentDate.TimeOfDay);
            Console.WriteLine(currentDate.Day);
            Console.WriteLine(currentDate.Month);
            Console.WriteLine(currentDate.Year);

            Console.WriteLine("\nNow");
            Console.WriteLine(currentTime);
            Console.WriteLine(currentTime.TimeOfDay);
            Console.WriteLine(currentTime.Day);
            Console.WriteLine(currentTime.Month);
            Console.WriteLine(currentTime.Year);
            Console.WriteLine(currentTime.Hour);
            Console.WriteLine(currentTime.Minute);
            Console.WriteLine(currentTime.Second);

            Console.WriteLine("\nUTC");
            Console.WriteLine(currentUtc.TimeOfDay);
            Console.WriteLine(currentUtc.Day);
            Console.WriteLine(currentUtc.Month);
            Console.WriteLine(currentUtc.Year);
            Console.WriteLine(currentUtc.Hour);
            Console.WriteLine(currentUtc.Minute);
            Console.WriteLine(currentUtc.Second);

           
        }
    }
}
