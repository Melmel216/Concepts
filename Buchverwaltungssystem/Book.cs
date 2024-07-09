using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchverwaltungssystem
{
    internal class Book
    {
        //Properties
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal int PublicationYear { get; set; }
        internal string ISBN { get; set; }


        //Konstruktor

        public Book(string title, string author, int publicationYear, string isbn)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            ISBN = isbn;
        }

        //Methoden
        internal string GetDescription()
        {
            return $"'{Title}' von {Author}, veröffentlicht im Jahr {PublicationYear} (ISBN: {ISBN})";
        }
    }
}
