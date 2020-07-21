using System;

namespace Exercise_4_13
{
    public class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Leandro", "Lima", 123M);
            Employee employee2 = new Employee("Jonathna","Nascimento", 77M);

            Console.WriteLine("Yearly salary of "+employee1.Name +" "+ employee1.LastName+ " is: "+12*employee1.Salary);
            Console.WriteLine("Yearly salary of " + employee2.Name + " " + employee2.LastName + " is: " + 12 * employee2.Salary);

            employee1.Salary = employee1.Salary * Convert.ToDecimal(1.1);
            employee2.Salary = employee2.Salary * Convert.ToDecimal(1.1);

            Console.WriteLine("New yearly salary of " + employee1.Name + " " + employee1.LastName + " is: " + 12 * employee1.Salary);
            Console.WriteLine("New yearly salary of " + employee2.Name + " " + employee2.LastName + " is: " + 12 * employee2.Salary);
        }
    }
}
