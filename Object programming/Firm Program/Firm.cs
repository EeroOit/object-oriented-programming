using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Firm

    {
        public string title;
        public string address;
        public int phone = 1;
        public int income=1;
        public int expense=1;
        

        public Firm()
        {
        }

        public Firm(string title, string address, int phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = outcome;
            this.expense = expense;
        }
      
        public Firm(Firm previousFirm)
        {
            title = previousFirm.title;
            address = previousFirm.address;
            phone = previousFirm.phone;
            income = previousFirm.income;
            expense = previousFirm.expense;
        }
            
        public void Profitmargin()
        {

            double profits = 100 * (income - expense) / expense;
            Console.WriteLine($"{title} voitto% on {profits}%.");

            if (profits >= 300)
            {
                Console.WriteLine($"Firmalla {title} menee hyvin.");
            }
            else if (profits >= 200 && profits <300)
            {
                Console.WriteLine($"Firmalla {title} menee tyydyttävästi.");
            }
            else if (profits >= 100 && profits < 200)
            {
                Console.WriteLine($"Firmalla {title} menee välttävästi.");
            }
            else
            {
                Console.WriteLine($"Firmalla {title} menee heikosti");
            }

        }
    }
    }
    

