using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Product : IProduct
    {
        public string name;
        public double price;
        public double amount;

        public Product()
        {
            this.name = string.Empty;
            this.price = 0;
            this.amount = 0;
        }

        public Product(string name, double price, double amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Product: {this.name}\nPrice: {this.price:c}\nAmount: {this.amount}";
        }

        public Object GetProduct(string comparedName)
        {
            if (name == comparedName)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double CalculateTotal()
        {
            double total = price * amount;
            return total;
        }

        public string PrintInfo()
        {
            return $"Name: {name}";
        }

    }
}