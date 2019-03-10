using System;

namespace ProductsRegister

{
    class Program
    {
        static void Main(string[] args)
        {
            ItemsList item = new ItemsList();
            FileManager fileManager = new FileManager();
            ConsoleKeyInfo cki;

            while(true)
            {
                cki = MainMenu();
                Console.WriteLine();
                switch (cki.Key)

                {
                    case ConsoleKey.F1:
                        Console.WriteLine(fileManager.ReadWords());
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine("List of product groups:");
                        Console.WriteLine("1 = Lajittelu ja säilytys");
                        Console.WriteLine("2 = Paperit ja lehtiöt");
                        Console.WriteLine("3 = Kynät");
                        Console.WriteLine("4 = Kortit ja kirjekuoret");
                        Console.WriteLine("---------------\nType respective number of the group you wish to inspect and press enter to continue.");
                        string groups = Console.ReadLine();
                       Console.WriteLine(fileManager.ProductGroups(groups));
                        break;

                    case ConsoleKey.F3:
                        fileManager.EditComment();
                       break;

                    case ConsoleKey.F4:
                        fileManager.OutOfStock();

                      break;

                    case ConsoleKey.F5:
                        Console.WriteLine("Exiting the program...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static ConsoleKeyInfo MainMenu()
        {
            Console.WriteLine("Product register");
            Console.WriteLine("--------------------------");
            Console.WriteLine("F1 = List all products in the register");
            Console.WriteLine("F2 = List products by their group");
            Console.WriteLine("F3 = Manage product comments.");
            Console.WriteLine("F4 = List products that are out of stock.");
            Console.WriteLine("F5 = Exit the program.");
            return Console.ReadKey();
        }
    }
}