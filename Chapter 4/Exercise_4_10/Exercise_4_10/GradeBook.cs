using System;

namespace Exercise_4_10
{
    public class GradeBook
    {
        private string courseName; // Course name

        public string CourseInstructor { get; set; } //Auto implemented Property to get the instructor's name

        public string CourseName // Property to acces the privte variable
        {
            get 
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public GradeBook (string initCourseName, string initInstName) // Class' constructor
        {
            courseName = initCourseName;
            CourseInstructor = initInstName;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to GradeBook of the class: " + courseName);
            Console.WriteLine("This course is presented by : " + CourseInstructor);
        }
    }
}
