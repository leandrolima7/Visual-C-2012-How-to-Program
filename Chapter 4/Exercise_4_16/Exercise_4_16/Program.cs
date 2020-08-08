using System;

namespace Exercise_4_16
{
    public class Program
    {
        //Checks if the gender is valid
        private static string ValidMonth(string checkMonth, EntryVerification checkVer1)
        {
            while (!checkVer1.Numeric(checkMonth))
            {
                Console.Clear();
                Console.Write("You have entered " + checkMonth.ToUpper() + " as month of birth");
                Console.Write("\n" + "Month is a numeric entry!" + "\n" + "Month of Birth: ");
                checkMonth = Console.ReadLine();
            }

            return checkMonth;
        }

        //Main method
        public static void Main(string[] args)
        {
            //Creates an object of the class EntryVerification
            EntryVerification ver1 = new EntryVerification();
           
            // Local variables
            string name, surname, gender, month;
            int day, year;
            double weight, height;
            double[] heartRange = new double[2];

            //Prompting for name
            Console.Write("First Name: ");
            name = Console.ReadLine();

            //Prompting for surname
            Console.Write("Surname: ");
            surname = Console.ReadLine();

            //Prompting for gender
            Console.Write("Gender: ");
            gender = Console.ReadLine();

            //Checks if the gender is valid
            while (ver1.Gender(gender) == 1)
            {
                Console.Clear();
                Console.Write("First Name: " + name +" \n" + "Surname: " + surname);
                Console.Write("\n"+"Incorrect Gender"+"\n"+"Gender: ");
                gender = Console.ReadLine();
            }

            Console.Clear();

            //Prompting for month of birth
            Console.Write("first Month of Birth: ");
            month = Console.ReadLine();

            //Checks if the month is valid
            month = ValidMonth(month, ver1);

            //Prompting for day of birth
            Console.Write("Day of Birth: ");
            day = Convert.ToInt32(Console.ReadLine());

            //Prompting for year of birth
            Console.Write("Year of Birth: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Checks the consistence of the birth date informed by the user
            while (ver1.DateConsistence(year,Convert.ToInt32(month),day) != 0)
            {
                Console.Clear();

                int returnConsistence = ver1.DateConsistence(year, Convert.ToInt32(month), day);

                switch(returnConsistence)
                {
                    case 1: // Year of birth greater then current year
                        Console.WriteLine("You have entered " + Convert.ToString(year).ToUpper()+" as year of birth.");
                        Console.WriteLine("Year of birth gretaer then current year!");
                        Console.Write("Year of Birth: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:// Month of birth greater then 12 or smaller then 0
                        Console.WriteLine("You have entered " + Convert.ToString(month).ToUpper() + " as month of birth.");
                        Console.WriteLine("Inconsistent Month of birth!");
                        Console.Write("Month of Birth: ");
                        month = Console.ReadLine();

                        //Checks if the month is valid
                        month = ValidMonth(month, ver1);
                        break;

                    case 3:// Day of birth greater then 31 or smaller then 0
                        Console.WriteLine("You have entered " + Convert.ToString(day).ToUpper() + " as day of birth.");
                        Console.WriteLine("Inconsistent Day of birth!");
                        Console.Write("Day of Birth: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:// Month of birth greater then month's current year
                        Console.WriteLine("You have entered " + Convert.ToString(year).ToUpper() + " as year of birth.");
                        Console.WriteLine("You have entered " + Convert.ToString(month).ToUpper() + " as month of birth.");
                        Console.WriteLine("Current month/year is: " + DateTime.Today.Month+"/"+DateTime.Today.Year);
                        Console.WriteLine("Inconsistent Month of birth!");
                        Console.Write("Month of Birth: ");
                        month = Console.ReadLine();

                        //Checks if the month is valid
                        month = ValidMonth(month, ver1);
                        break;

                    case 5:// Day of birth greater then day's current month
                        Console.WriteLine("You have entered " + Convert.ToString(year).ToUpper() + " as year of birth.");
                        Console.WriteLine("You have entered " + Convert.ToString(month).ToUpper() + " as month of birth.");
                        Console.WriteLine("You have entered " + Convert.ToString(day).ToUpper() + " as day of birth.");
                        Console.WriteLine("Current day/month/year is: " + DateTime.Today.Day+"/"+ DateTime.Today.Month + "/" + DateTime.Today.Year);
                        Console.WriteLine("Inconsistent Day of birth!");
                        Console.Write("Day of Birth: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();
           
            Console.Write("Your Weight in Kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Your Height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            HealthProfile person1 = new HealthProfile(name, surname, gender, Convert.ToInt32(month), day, year, height, weight);

            Console.Clear();

            Console.Write("User Info" + "\n");

            Console.WriteLine("Name: " + person1.First_name + " " + person1.Last_name);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Date of birth: " + person1.DateBirth());
            Console.WriteLine("Height: " + person1.Height+ " Kg");
            Console.WriteLine("Weight: " + person1.Weight+ " m");
            Console.WriteLine("Age: " + person1.UserAge(year));
            Console.WriteLine("BMI: " + String.Format("{0:0.00}",person1.BMI()));
            Console.WriteLine("Maximum heart rate: " + person1.MaximumHeartRate(year));
            heartRange = person1.TargetHeartRaterange(year);
            Console.WriteLine("Target heart range" + "\n" + "\t"+ "Maximum: "+ heartRange[0]+"\n"+"\t"+"Minumim: "+ heartRange[1]);
        }
    }    
}
/*
Write an app that prompts for the person’s information, instantiates an object of
class HealthProfile for that person.

Displays the information from that object—including the
person’s first name, last name, gender.

date of birth, height and weight

then calculates and displays the person’s age in years, BMI, maximum heart rate and target-heart-rate range.It should also
display the “BMI values” chart from Exercise 3.31.
 */