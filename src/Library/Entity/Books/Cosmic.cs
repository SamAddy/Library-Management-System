using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class Cosmic : Book, IBorrowable
    {
        public string Artist { get; set; }

        public Cosmic(string title, string author, string isbn, string publicationYear, string artist) : base(title, author, isbn, publicationYear)
        {
            Artist = artist;
            CanBorrow = true;
            CanPrint = false;
        }

        public override void Borrow()
        {
            base.Borrow();
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Can be borrowed: {(CanBorrow ? "Available" : "Not Available")}");
            Console.WriteLine($"Is Printable: {(CanPrint ? "Yes" : "No")}");
        }
    }
}