using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Customer : ICustomer
    {
        public string name;
        public double purchases;

        public Customer()
        {
            this.name = string.Empty;
            this.purchases = 0;
        }

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public override string ToString()
        {
            return $"Customer: {this.name}\nPurchases: {this.purchases:c}\n";
        }

        public Object GetCustomer(string comparedName)
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

        public double GetBonus()
        {
            if (this.purchases < 1000)
            {
                double bonus = this.purchases * 0.02;
                return bonus;
            }
            else if (this.purchases >= 1000 && this.purchases >= 2000)
            {
                double bonus = this.purchases * 0.03;
                return bonus;
            }
            else
            {
                double bonus = this.purchases * 0.05;
                return bonus;
            }
        }
    }
}