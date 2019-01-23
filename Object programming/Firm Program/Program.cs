using System;

namespace firm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firm");

            firm data = new firm();
            data.AskData();

            data.Profitmargin();
        }
    }
}
