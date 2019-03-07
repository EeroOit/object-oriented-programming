using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance
{
    abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected string modelByYear;
        protected double price;

        public Vehicle()
        {
            type = "";
            brand = "";
            modelByYear = "";
            price = 0;
        }

        public Vehicle(string type, string brand, string modelByYear, double price)
        {
            this.type = type;
            this.brand = brand;
            this.modelByYear = modelByYear;
            this.price = price;
        }
        public virtual string PrintData()
        {
            return $"Type: {this.type}\nBrand: {this.brand}\nModel: {this.modelByYear}\nPrice: {this.price:c}";
        }

        public override string ToString()
        {
            return ($"Type: {this.type}\nBrand: {this.brand}\nModel: {this.modelByYear}\nPrice: {this.price:c}");
        }
    }

    

      
}