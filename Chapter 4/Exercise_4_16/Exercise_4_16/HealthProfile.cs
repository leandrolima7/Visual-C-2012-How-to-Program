using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercise_4_16
{
    public class HealthProfile
    {
        private string firt_name, last_name, gender;

        private DateTime currentYear = DateTime.Today;
           
        public string First_name
        {
            get
            {
                return firt_name;
            }
            set
            {
                firt_name = value;
            }
        }
        
        public string Last_name
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int Month { set; get; }

        public int Day { get; set; }

        public int Year { get; set; }

        public double Height { set; get; }

        public double Weight { set; get; }

        public HealthProfile(string iniFN, string iniLN, string iniG, int iniM, int iniD, int iniY, double iniH, double iniW)
        {
            First_name = iniFN;
            Last_name = iniLN;
            Gender = iniG;
            Month = iniM;
            Day = iniD;
            Year = iniY;
            Height = iniH;
            Weight = iniW;
        }

        public int UserAge(int uYear) // This method returns a person's age
        {
            return currentYear.Year - uYear;
        }

        public int MaximumHeartRate(int uYear)
        {
            return 220 - UserAge(uYear);
        }

        public double[] TargetHeartRaterange(int uYear) //returns target-heart-rate range
        {
            double[] range = new double[2];
            double MaximumRate = Convert.ToDouble(MaximumHeartRate(uYear));
            range[0] = MaximumRate * 0.85; //Maximum rate
            range[1] = MaximumRate * 0.50; // Mininum rate

            return range;
        }

        public double BMI() // returns body mass index
        {
            return Weight / Math.Pow(Height, Height);
        }

        public string DateBirth()
        {
            string localdate = Month + "/" + Day + "/" + Year;
            return localdate;
        }
    }
}

/*
In this exercise, you’ll design a “starter” HealthProfile class for a person.The class attributes should include 
the person’s first name, last name, gender, date of birth(consisting of separate
attributes for the month, day and year of birth), height(in inches) and weight(in pounds). 
Your class should have a constructor that receives this data.
For each attribute provide a property with set and get accessors.

The class also should include methods that calculate and return the user’s age in years,
maximum heart rate and target-heart-rate range(see Exercise 4.15), and body mass index(BMI; see
Exercise 3.31). 
*/
