using System;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees:");
            Console.WriteLine("---------------------------------");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("a", "Cleaner", 1000);
            employees[1] = new Employee("b", "Repairman", 1250);
            employees[2] = new Employee("c", "Waiter", 1500);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine(Employee.CompareSalary(employees[0], employees[1]));
            Console.WriteLine(Employee.CompareSalary(employees[1], employees[2]));
            Console.WriteLine(Employee.CompareSalary(employees[0], employees[2]));

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        } 
    }
}
