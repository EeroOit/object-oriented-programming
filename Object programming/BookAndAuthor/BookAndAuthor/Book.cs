using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
    class Book
    {
        public string title;
        public readonly string author;
        public string publisher;
        public double price; 
        public static string theme;

        public Book(string title, string author, string publisher, double price, string newTheme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            theme = newTheme;
        }

        public string SearchBook(string search)
        {
            return $"Book title: {title}\nAuthor: {author}\nPublisher: {publisher}\nPrice: {price:c}\nTheme: {theme}";
        }

        public static void SwitchTheme()
        {
            theme = "Uutuus kirja";
        }

        public override string ToString()
        {
            return $"Book title: {title}\nAuthor: {author}\nPublisher: {publisher}\nPrice: {price:c}\nTheme: {theme}";
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 30)
                {
                    price = value - (value * 0.1);
                }
                else
                {
                    price = value;
                }
            }
        }

        public string Author
        {
            get { return author; }
        }

    }
}