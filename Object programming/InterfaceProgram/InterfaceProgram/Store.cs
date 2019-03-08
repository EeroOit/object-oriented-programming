using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Store : ICustomers, IProducts
    {
        public string name;
        public double revenue;
        List<Product> pList;
        List<Customer> cList;

        public Store()
        {
            name = string.Empty;
            revenue = 0;
            pList = new List<Product>();
            cList = new List<Customer>();
        }

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddProduct(Product prodName)
        {
            pList.Add(prodName);
        }

        public void AddCustomer(Customer customer)
        {
            cList.Add(customer);
        }

        public override string ToString()
        {
            return $"Name: {this.name}\nRevenue: {this.revenue}\nAmount of customers: {cList.Count}\nAmount of products: {pList.Count}";
        }

        public void PrintProduct()
        {
            Console.WriteLine($"There are {pList.Count} items in the store. The items are:");
            Console.WriteLine("------------------------------");
            foreach (Product product in pList)
            {
                Console.WriteLine($"{product.ToString()}");
            }
        }

        public void CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (Product product in pList)
            {
                totalValue = product.amount * product.price;
                totalValue++;
            }

            Console.WriteLine($"Total value of products: {totalValue}.");
            Console.WriteLine("------------------------------");
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"There are {cList.Count} customer  in the store. Customer List:");
            foreach (Customer customer in cList)
            {
                Console.WriteLine($"{customer.ToString()}");
            }
        }

        public void GetBonus()
        {
            double bonus = 0;
            foreach (Customer customer in cList)
            {
                if (customer.purchases < 1000)
                {
                    bonus = customer.purchases * 0.02;
                }
                else if (customer.purchases >= 1000 && customer.purchases >= 2000)
                {
                    bonus = customer.purchases * 0.03;
                }
                else
                {
                    bonus = customer.purchases * 0.05;
                }
                Console.WriteLine($"{customer.name} gets {bonus:c} of bonuses.");
            }
        }
    }
}