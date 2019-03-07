using System;
using System.Globalization;

namespace VehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            Car car = new Car("car", "Mercedes", "2006", 15000, 2200, "automobile", 4);
            Truck truck = new Truck("Transport truck", "Scania", "2015", 150000, 4000, "truck", 2, 8000, 0.1);
            Car luxuryCar = new Car("luxury car", "Lexus", "2018", 250000, 3200, "automobile", 2);


            Console.WriteLine("Vehicle data");
            Console.WriteLine();
            Console.WriteLine(car.PrintData());
            Console.WriteLine();
            Console.WriteLine(luxuryCar.PrintData());
            Console.WriteLine("------------");


            Console.WriteLine(car.ToString());
            Console.WriteLine();
            Console.WriteLine(luxuryCar.ToString());
            Console.WriteLine("------------");


            if (car.Equals(luxuryCar))
            {
                Console.WriteLine($"The cars are the same.");
            }
            else
            {
                Console.WriteLine("The cars are different.");
            }
            Console.WriteLine("------------");

            Console.WriteLine(truck.PrintData());
            Console.WriteLine("------------");
            Console.WriteLine("");

            Console.WriteLine($"Truck's consumption is: {truck.CalculateConsumption()}.");
            Console.WriteLine();

            Console.WriteLine("Press enter to end the program...");
            Console.ReadLine();
        }
    }
}
