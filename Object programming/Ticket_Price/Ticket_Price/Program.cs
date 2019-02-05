using System;

namespace Ticket_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää lipun hinnan, normaalihinta on 16 euroa.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Valitse alla olevista vaihtoehdoista:");
            Console.WriteLine(" 1= Aikuinen 2= Opiskelija 3= MTK Jäsen 4= Opiskelija+MTK 5= 7-15vuotias 6= 65 tai yli 7= Alle 7v ");
            Console.Write("Syötä valintasi: ");
            

            Ticket price = new Ticket();
            price.AskData();
            price.PriceCalculation();

            Console.WriteLine("--------------------------------");
            Console.Write("Paina mitä tahansa jatkaaksesi...");
            Console.ReadKey();
        }
    }
}
