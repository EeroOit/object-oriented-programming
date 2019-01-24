using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Price
{
    class ticket
    {
           public double price = 16;
        public double discount = 1;

        public ticket()
        { }

        public ticket( double price, double discount)
        {

            this.price = price;
            this.discount = discount;
        }

        public void AskData()
        {
            string str = Console.ReadLine();

            switch (str)

            {
                case "1":
                case "Aikuinen":
                    discount = 0.0;
                    break;

                case "2":
                case "Opiskelija":
                    discount = 0.45;
                    break;
                case "3":
                case "MTK Jäsen":
                    discount = 0.15;
                    break;
                case "4":
                case "Opiskelija+MTK":
                    discount = 0.6;
                    break;
                case "5":
                case "7-15vuotias":
                    discount = 0.50;
                    break;
                case "6":
                case "65 tai yli":
                    discount = 0.5;
                    break;
                case "7":
                case "Alle 7v":
                    discount = 1.0;
                    break;
                default:
                    Console.WriteLine("Väärä valinta. Valitse numeroista 1-7.");
                    Console.ReadLine(); //Pause;
                    break;
            }
        }

        public void PriceCalculation()
        {
            Console.WriteLine($"Lipunhintasi on  {price - price * discount} euroa.");

        }
    }
}

