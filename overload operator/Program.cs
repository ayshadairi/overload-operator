using System;

namespace overload_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate two Employee objects and compare using overload operators
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "Rula",
                LastName = "Hussam"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "John",
                LastName = "Smith"
            };

            Console.WriteLine($"Employee 1 and Employee 2 are {(employee1 == employee2 ? "equal" : "not equal")}");

            employee2.Id = 1;

            Console.WriteLine($"Employee 1 and Employee 2 are {(employee1 == employee2 ? "equal" : "not equal")}");

            Console.ReadLine();
        }
    }
}
