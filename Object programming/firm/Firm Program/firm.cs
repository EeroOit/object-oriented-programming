using System;
using System.Collections.Generic;
using System.Text;

namespace firm
{
    class firm
    {
        public string title;
        public string address;
        public int phone = 1;
        public int outcome=1;
        public int expense=1;
        

        public firm()
        {
        }

        public firm(string title, string address, int phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.outcome = expense;
        }
        public void AskData()
        {
            Console.Write("Firman Nimi: ");
            title = Console.ReadLine();
            Console.Write("Tulot: ");
            string outcomevalue = Console.ReadLine();
            Console.Write("menot: ");
            string expensevalue = Console.ReadLine();

            int.TryParse(outcomevalue, out outcome);
            int.TryParse(expensevalue, out expense);
        }
            
        public void Profitmargin()
        {

            double profits = 100 * (outcome - expense) / expense;
            Console.WriteLine($"voitto% on {profits}");

            if (profits >= 300)
            {
                Console.WriteLine("Firmalla menee hyvin.");
            }
            else if (profits >= 200 && profits <300)
            {
                Console.WriteLine("Firmalla menee tyydyttävästi.");
            }
            else if (profits >= 100 && profits < 200)
            {
                Console.WriteLine("Firmalla menee välttävästi.");
            }
            else
            {
                Console.WriteLine("Firmalla menee heikosti");
            }

        }
    }
    }
    

