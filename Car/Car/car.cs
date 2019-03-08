using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        public string brand;
        public int speed = 100;

        public Car()
        {

        }

        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.Write("Auton nimi:");
            brand = Console.ReadLine();
            Console.Write("Nopeus: ");
            string speedValue = Console.ReadLine();


            int.TryParse(speedValue, out speed);
            /*
       {
           speed = 0;
       }
       */
        }
        public void ShowInfo()
        {
            {
                Console.WriteLine($"{brand}:n nopeus {speed}");
            }
        }

        public void Accelerate(string speedValue)
        {
            if (!int.TryParse(speedValue, out int iSpeed))
            {
                iSpeed = 0;
            }
            if (iSpeed > 0)
            {
                this.speed += iSpeed;
                Console.WriteLine($"Nopeutta lisättiin {iSpeed}. uusi nopeus on {this.speed} km/h\n");
            }
            else if (iSpeed == 0)
            {
                Console.WriteLine("ei muutosta");
            }
            else
            {
                Console.WriteLine("negatiivista muutosta ei sallita");
            }
        }
            public void Brake()
            {
                speed = 90 * speed / 100;
                Console.WriteLine($"Jarrutus, nopeutta hidastettiin 10 prosenttia, uusi nopeus on {speed} km/H");
           
            }
        }
    }



    

        





    



