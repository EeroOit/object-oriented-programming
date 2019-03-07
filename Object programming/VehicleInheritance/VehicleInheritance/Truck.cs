using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance
{
    class Truck : Car
    {
        protected double weight;
        protected double consumption;

        public Truck()
        {
            weight = 0;
            consumption = 0;
        }

        public Truck(string type, string brand, string modelByYear, double price, int engine, string model, int numberOfDoors, Double weight, Double consumption)
            : base(type, brand, modelByYear, price, engine, model, numberOfDoors)
        {
            this.weight = weight;
            this.consumption = consumption;
        }

        public double CalculateConsumption()
        {
            double totalConsumption = this.weight * this.consumption;
            return totalConsumption;
        }
    }
}
