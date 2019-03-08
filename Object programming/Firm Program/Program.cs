using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista firmoista:");

            Firm FirstFirm = new Firm("Yritys A", "katu,",1234567, 10000,1000);
            Firm SecondFirm = new Firm(FirstFirm);

            SecondFirm.title = "Yritys B";
            SecondFirm.income = 2000;


            FirstFirm.Profitmargin();
            SecondFirm.Profitmargin();
        }
    }
}
