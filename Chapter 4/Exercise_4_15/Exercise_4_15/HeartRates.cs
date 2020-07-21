using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4_15
{
    public class HeartRates
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearBirth { get; set; }
        public int CurrentYear { get; set; }

        private int age;

        private decimal maximumHeartRate, maximumTargetRate, minimumTargetRate;
        public int Age
        {
            get
            {
                age = CurrentYear - YearBirth;
                return age;
            }
        }

        public decimal MaximumHeartRate
        {
            get
            {
                maximumHeartRate = Convert.ToInt16(220) - Age;
                return Convert.ToInt16(maximumHeartRate);
            }
        }

        public decimal MaximumTargetRate
        {
            get
            {
                maximumTargetRate = MaximumHeartRate * Convert.ToDecimal(0.85);
                return Convert.ToInt16(maximumTargetRate);
            }
        }

        public decimal MinimumTargetRate
        {
            get
            {
                minimumTargetRate = MaximumHeartRate * Convert.ToDecimal(0.50);
                return Convert.ToInt16(minimumTargetRate);
            }
        }

        public HeartRates(string iniName, string iniLast, int biYear, int cuYear) // Constructor 
        {
            Name = iniName;
            LastName = iniLast;
            YearBirth = biYear;
            CurrentYear = cuYear;
        }

    }
}

   