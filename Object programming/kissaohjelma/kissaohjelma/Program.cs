using System;

namespace kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tämä on kissaohjelma");

            Cat myFirstCat = new Cat("pilli", 1);
            myFirstCat.PrintWeight();
            //myFirstCat.weight = 5;
            //Console.WriteLine("kissan paino on muutettu {0}", myFirstCat.weight);

            Cat mySecondCat = new Cat("pulla", 3);
            mySecondCat.PrintWeight();

            Console.Write("Press any key to continue....\n");
            Console.ReadKey();
        }
    }
}
