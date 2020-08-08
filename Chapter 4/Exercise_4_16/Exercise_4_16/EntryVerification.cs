using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Exercise_4_16
{
    public class EntryVerification
    {
        private DateTime currentData =  DateTime.Today;
        public int Gender(string checkGender)
        {
            if (String.Compare(checkGender, "male", true) != 0 && String.Compare(checkGender, "female", true) != 0)
                return 1;
            else
                return 0;
        }

        public bool Numeric(string checkMonth)
        {
            bool isNumeric = true;

            foreach(char c in checkMonth)
            {
                if(!Char.IsNumber(c))
                {
                    isNumeric = false;
                    break;
                }
            }

            return isNumeric;
        }

        public int DateConsistence(int checkYear, int checkMonth, int checkDay)
        {
            int consistence = 0;

            if (checkYear > currentData.Year)
                consistence = 1;
            else if (checkMonth > 12 || checkMonth <= 0)
                consistence = 2;
            else if (checkDay > 31 || checkDay <= 0)
                consistence = 3;
            else if (checkYear == currentData.Year)
                if (checkMonth > currentData.Month)
                        consistence = 4;
                else if (checkMonth == currentData.Month)
                    if (checkDay > currentData.Day)
                        consistence = 5;

            return consistence;
        }


        
        public bool MonthRange(int checkMonth)
        {
            bool rangeOverflow = false;
            if (checkMonth > 12 || checkMonth <= 0)
                rangeOverflow = true;
            return rangeOverflow;
        }

        public int YearRange(int checkYear, int checkMonth, int checkDay)
        {
            int rangeOverflow = 0;

            if (checkYear == currentData.Year)
                if (checkMonth > currentData.Month)
                    rangeOverflow = 1;
                else if (checkMonth == currentData.Month)
                    if (checkDay > currentData.Day)
                        rangeOverflow = 1;
            else if(checkYear > currentData.Year || checkYear <= 0)
                rangeOverflow = 1;
          
            return rangeOverflow;
        }

    }
}
