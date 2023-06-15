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
            base.PrintInfo();
            Console.WriteLine($"Artist: {Artist}");
        }
    }
}