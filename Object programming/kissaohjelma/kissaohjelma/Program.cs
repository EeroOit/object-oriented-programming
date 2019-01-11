using System;

namespace kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tämä on kissaohjelma\n");

            Cat myFirstCat = new Cat("pilli", 1);
            myFirstCat.IncreaseWeight(7);
            myFirstCat.PrintWeight();
            //myFirstCat.weight = 5;
            Console.WriteLine("kissan  paino on {0}", myFirstCat.weight);

            Console.WriteLine("---------------------------------------------------\n");

            Cat mySecondCat = new Cat("pulla", 3);
            mySecondCat.IncreaseWeight(2);
            mySecondCat.PrintWeight();
            Console.WriteLine("kissan  paino on {0}", mySecondCat.weight);

            Console.Write("Press any key to continue....\n");
            Console.ReadKey();
        }
    }
}
