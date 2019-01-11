using kirjaohjelma;
using System;

namespace kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjat ja hinnat:");
            Console.WriteLine("---------------------\n");

            Book newBook = new Book("Aapinen", "Mikael Agricola", "0001", 22.50);

            //Console.WriteLine("kirjan hinta on {0}", newBook.price);

            Book newBook2 = new Book("Peppi Pitkätossu", "Astrid Lindgren", "0002", 18.95);
            //Console.WriteLine("kirjan hinta on {0}", newBook2.price);

            newBook.CompareBooks(newBook2);
            Console.WriteLine(newBook2.CompareBooks(newBook));
                }
        }

        
    }

