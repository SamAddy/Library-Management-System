using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class Novel : Book, IBorrowable
    {
        public string Genre { get; set; }

        public Novel(string title, string author, string isbn, string publicationYear, string genre) : base(title, author, isbn, publicationYear)
        {
            Genre = genre;
            CanBorrow = true;
            CanPrint = false;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}