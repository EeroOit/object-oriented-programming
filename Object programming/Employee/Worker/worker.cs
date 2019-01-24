using System;
using System.Collections.Generic;
using System.Text;

namespace Worker
{
    
    class Employee
    {
        public string name;
        public string position;
        public int salary = 1;


        public Employee()
        {
        }

        public Employee(string name,  string position, int salary)
        {
            this.name = name;           
            this.position = position;
            this.salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Nimi: {this.name}\n" +
                             $"Tehtävä: {this.position}\n" +
                             $"Palkka: {this.salary.ToString()}\n");

        }

        public override string ToString()
        {
            return $"Employee: {name}\nposition {position}\nSalary:{salary:c}\n";
        }



        public static string CompareSalary(Employee firstEmployee, Employee secondEmployee)
        {
            if (firstEmployee.salary > secondEmployee.salary)
            {
                return $"{firstEmployee.name} has a higher salary than {secondEmployee}";
            }
            else if (firstEmployee.salary < secondEmployee.salary)
            {
                return $"{secondEmployee.name} has a higher salary than {firstEmployee.name}";
            }
            else
            {
                return $"{firstEmployee} and { secondEmployee} have an equal salary.";
            }
        }
    }
}