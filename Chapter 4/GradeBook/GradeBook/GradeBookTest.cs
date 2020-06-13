using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook mygradeBook = new GradeBook();

            string courseName; //variable to store the course name

            Console.Write("Please, type the name of the course: ");
            courseName = Console.ReadLine();
            Console.WriteLine(); // Whites a blank line
            mygradeBook.DisplayMessage(courseName);
        }
    }
}
