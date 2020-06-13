using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookPrCo
{
    public class GradeBookPrCoTest
    {
        static void Main(string[] args)
        {
            GradeBookPrCo courseName1 = new GradeBookPrCo("Math");
            GradeBookPrCo courseName2 = new GradeBookPrCo("Portuguese");

            Console.WriteLine("Welcome to the Grade Book of the {0} course!", courseName1.CourseName);
            Console.WriteLine("Welcome to the Grade Book of the {0} course!", courseName2.CourseName);

            Console.WriteLine();

            Console.Write("Please, reasign the name of the first course: ");
            courseName1.CourseName = Console.ReadLine(); // Call the property to assign the name of the course 1

            Console.WriteLine();

            Console.Write("Please, reasign the name of the second course: ");
            courseName2.CourseName = Console.ReadLine(); // Call the property to assign the name of the course 2

            Console.WriteLine();

            courseName1.DisplayMessage();

            Console.WriteLine();
            Console.WriteLine();

            courseName2.DisplayMessage();
        }
    }
}
