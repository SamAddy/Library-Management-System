using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class TextBook : Book, IBorrowable, IPrintable
    {
        public int MaxAmountOfPrintablePages;

        public TextBook(string title, string author, string isbn, string publicationYear, int maxAmountOfPrintablePages) : base(title, author, isbn, publicationYear)
        {   
            MaxAmountOfPrintablePages = maxAmountOfPrintablePages;
            CanBorrow = true;
            CanPrint = true;
        }

        public override void Borrow()
        {
            if (CanBorrow)
            {
                base.Borrow();
            }
            else
            {
                Console.WriteLine($"Novel '{Title}' cannot be borrowed.");
            }
        }

        public void PrintPages(int startPage, int endPage)
        {
            if (endPage > MaxAmountOfPrintablePages)
            {
                Console.WriteLine($"Please note that you cannot print pages {startPage} - {endPage}. Maximum printable pages exceeded.");
            }
            else
            {
                Console.WriteLine($"Printing pages {startPage} - {endPage} of `{Title}`");
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Maximum printable pages: {MaxAmountOfPrintablePages}");
        }
    }
}