using System;

namespace GradeBookPrCo
{
    public class GradeBookPrCo
    {
        public string CourseName { get; set; } //Property to get and set the course name for this Grade Book

        public GradeBookPrCo(string name) //Constructor
        {
            CourseName = name;
        }

        public void DisplayMessage() //This public void method displays a greating message
        {
            Console.Write("Welcome to the Grade Book of the {0} course!", CourseName);
        }
    }
}
