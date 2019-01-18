using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autot");

            Car car = new Car();
            car.AskData();
            car.ShowInfo();
            Console.WriteLine($"Anna km/h arvo jolla  nopeutta lisätään.");
            car.Accelerate(Console.ReadLine());
            car.Brake();
            Console.WriteLine("\n------------\n");

            Car Secondcar = new Car();
            car.AskData();
            car.ShowInfo();
            Console.WriteLine($"Anna km/h arvo jolla  nopeutta lisätään.");
            car.Accelerate(Console.ReadLine());
            car.Brake();
            Console.WriteLine("\n------------\n");




        }
    }
}
