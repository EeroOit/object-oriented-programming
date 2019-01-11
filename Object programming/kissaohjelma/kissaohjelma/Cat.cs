using System;
using System.Collections.Generic;
using System.Text;

namespace kissaohjelma
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat()
        {
            this.weight = 1;
            Console.WriteLine($"kissan alustettu paino on {this.weight}");
        }
        public void IncreaseWeight(int value)
        {
            this.weight = this.weight + value;
            Console.WriteLine($"kissan {this.name} uusi paino on {this.weight}");
        }

        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"luotu kissa {this.name} jonka paino on {this.weight}");
        }

        public Cat (int weightValue)
        {
            this.weight = weightValue;
            //Console.WriteLine($"kissan paino on {this.weight}");
        }
        public void PrintWeight()
        {
            //Console.WriteLine($"kissan {this.name} paino on {this.weight}");

        }
    }
}
