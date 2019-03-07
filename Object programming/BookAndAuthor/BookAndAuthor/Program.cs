using System;
using System.Globalization;
using Literature;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            Book firstBook = new Book("SUPERMARKET SURVIVAL", " Posti Olli ", "	Readme.fi", 21.95, "");
            Book secondBook = new Book("PUOLESSA TUNNISSA", "Väisänen Outi", " Readme.fi", 27.95, "");
            Book thirdBook = new Book("MAALLISET JÄÄNTET", " Leon Donna ", " Otava", 27.95, "");

            Author OlliP = new Author();
            Author OutiV = new Author();
            Author DonnaL = new Author();
         

            OlliP.Name = "Olli Posti";
            OlliP.DateOfBirth = "24.06.1979";
            OlliP.BookProperty = firstBook;
            OutiV.Name = "Outi Väisänen";
            OutiV.DateOfBirth = "1.03.1984";
            OutiV.BookProperty = secondBook;
            DonnaL.Name = "Donna Leon";
            DonnaL.DateOfBirth = "19.04.1956";
            DonnaL.BookProperty = thirdBook;
           
            Console.WriteLine("Search for a book by its name: ");
            string search = Console.ReadLine().ToUpper();

            if (search == firstBook.title)
            {
                Console.WriteLine(firstBook.SearchBook(search));
            }
            else if (search == secondBook.title)
            {
                Console.WriteLine(secondBook.SearchBook(search));
            }
            else if (search == thirdBook.title)
            {
                Console.WriteLine(thirdBook.SearchBook(search));
            }         
            else
            {
                Console.WriteLine("Book not found.");
            }
            Console.WriteLine("Move to next phase by pressing enter.");
            Console.ReadLine();

            Console.WriteLine("-------------------------");           
            Book.SwitchTheme();
            Console.WriteLine(firstBook.ToString());
            Console.WriteLine();
            Console.WriteLine(secondBook.ToString());
            Console.WriteLine();
            Console.WriteLine(thirdBook.ToString());
            Console.WriteLine();           
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Prices over 30 euros will get 10% discount.");
            Console.WriteLine($"{firstBook.title}: {firstBook.Price:c}");
            Console.WriteLine($"{secondBook.title}: {secondBook.Price:c}");
            Console.WriteLine($"{thirdBook.title}: {thirdBook.Price:c}");
        
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Book's author:");
            Console.WriteLine($"{firstBook.title}: {firstBook.Author}");
            Console.WriteLine($"{secondBook.title}: {secondBook.Author}");
            Console.WriteLine($"{thirdBook.title}: {thirdBook.Author}");
          
            Console.WriteLine("-------------------------");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Who are the authors?");
            Console.WriteLine();
            Console.WriteLine(OlliP.PrintAuthor());
            Console.WriteLine();
            Console.WriteLine(OutiV.PrintAuthor());
            Console.WriteLine();
            Console.WriteLine(DonnaL.PrintAuthor());
            Console.WriteLine();
           
            Console.WriteLine("Press enter to end the program...");
            Console.ReadLine();
        }
    }
}