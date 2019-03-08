using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
          

            

            Product a = new Product("NHL 18", 59.99, 8);
            Product b = new Product("Call of Duty 4", 39.99, 5);
            Product c = new Product("Fifa 14", 4.99, 20);

            List<Product> prodList = new List<Product>();
            
            prodList.Add(a );
            prodList.Add(b);
            prodList.Add(c);

            foreach (Product p in prodList)
            {
                if (p.GetProduct("NHL 18") != null)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine();


            foreach (Product p in prodList)
            {

                //Console.WriteLine($"{p.CalculateTotal():c}");
            }
           

            Console.WriteLine();
            Customer first = new Customer("Matti Meikäläinen", 10);
            Customer second = new Customer("Maija Manninen", 40);
            Customer third = new Customer("Arvo Aasikainen", 20);

      
            List<Customer> custList = new List<Customer>();
            custList.Add(first);
            custList.Add(second);
            custList.Add(third);
            Console.WriteLine();

            foreach (Customer cust in custList)
            {
                if (cust.GetCustomer("Matti Meikäläinen") != null)
                {
                    Console.WriteLine(cust.ToString());
                    Console.WriteLine("------------------------------");
                }
            }

            foreach (Customer cust in custList)
            {
                Console.WriteLine($"{cust.GetBonus():c}");
            }

            Store store = new Store();

            store.AddProduct(a);
            store.AddProduct(b);
            store.AddProduct(c);
            store.AddCustomer(first);
            store.AddCustomer(second);
            store.AddCustomer(third);

            store.PrintCustomers();
            Console.WriteLine();
            store.PrintProduct();
            Console.WriteLine();

            store.CalculateTotalValue();
            Console.WriteLine();
            store.GetBonus();
            Console.WriteLine();

            Console.WriteLine("Press enter to end the program..");
            Console.ReadLine();
        }
    }
}