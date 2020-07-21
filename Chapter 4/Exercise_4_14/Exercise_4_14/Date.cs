using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4_14
{
    public class Date
    {
        public int Month { get; set; } //Property
        public int Day { get; set; } //Property
        public int Year { get; set; } //Property

        public Date(int iniMonth, int iniDay, int iniYear)
        {
            Month = iniMonth;
            Day = iniDay;
            Year = iniYear;
        }
        public void DisplayDate()
        {
            Console.WriteLine("The date is: " + Month + "/" + Day + "/" + Year);
        }
    }
}