using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car
    {
        protected double engine;
        protected string type;
        protected int doors;

        public Car()
        {
            Console.WriteLine("Car constructor");
            this.engine = 1000;
            this.type = "wagon";
            this.doors = 4;
        }
        public Car(string make, string model, int year, int price, double engine, string type, int doors)
        { }
    }
}