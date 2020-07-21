using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Exercise_4_13
{
    public class Employee
    {
        private string name;
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string LastName { get; set; }    

        //constructor that initializes the values
        public Employee(string initName, string initLastName, decimal initSalary)
        {
            Name = initName;
            LastName = initLastName;
            Salary = initSalary;
        }
    }
}
