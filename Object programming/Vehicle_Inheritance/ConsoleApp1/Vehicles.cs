using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        string make;
        string model;
        int year;
        int price;



        public Vehicle(string make, string model, int year, int price)
        {
            Console.WriteLine("Vehicle Constructor");
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nMerkki: {this.make}\n" +
                              $"Malli: {this.model}\n" +
                              $"Vuosimalli: {this.year}\n" +
                              $"Hinta: {this.price}");

        }

      
        }
    }
