using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
    class Author
    {
        public string name = "";
        public string dateOfBirth = "";
        public Book book;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public Book BookProperty
        {
            get
            {
                return book;
            }
            set
            {
                book = value;
            }
        }
        public string PrintAuthor()
        {
            return $"{Name} was born on {DateOfBirth}, and is the writer of {book.title}.";
        }
    }
}