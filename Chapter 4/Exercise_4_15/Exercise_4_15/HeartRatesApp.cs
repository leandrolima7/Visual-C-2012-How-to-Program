using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_4_15
{
    public class HeartRatesApp
    {
        public static void Main(string[] args)
        {
            string name, lastName;
            int birthyear, currentYear;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Year of Birth: ");
            birthyear = Convert.ToInt16(Console.ReadLine());

            Console.Write("Current Year: ");
            currentYear = Convert.ToInt16(Console.ReadLine());

            HeartRates heartRates = new HeartRates(name, lastName, birthyear, currentYear);

            Console.WriteLine(heartRates.Name + " " + heartRates.LastName + ". Year of birth: " + heartRates.YearBirth);

            Console.Write("Age: "+ heartRates.Age+"\n");
            Console.Write("Maximum heart rate: " + heartRates.MaximumHeartRate + "\n");
            Console.Write("Target heart rate range: " + heartRates.MinimumTargetRate + " - "+heartRates.MaximumTargetRate+"\n\n");
        }
    }
}

/*
Write an app that prompts for the person’s information, instantiates an object of class HeartRates and displays the information from that object—including the
person’s first name, last name and year of birth—then calculates and displays the person’s age in
(years), maximum heart rate and target-heart-rate range.
*/
