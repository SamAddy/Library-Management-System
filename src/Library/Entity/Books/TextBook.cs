using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class TextBook : Book, ICanBorrow, IPrintable
    {
        public int MaxAmountOfPrintablePages;

        public TextBook(string title, string author, string isbn, string publicationYear, int maxAmountOfPrintablePages, string id) : base(title, author, isbn, publicationYear, id)
        {   
            MaxAmountOfPrintablePages = maxAmountOfPrintablePages;
            CanBorrow = true;
            CanPrint = true;
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

        void ICanBorrow.Borrow()
        {
            if (CanBorrow)
            {
                Console.WriteLine($"Textbook '{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"TextBook '{Title}' cannot be borrowed.");
            }
        }

        void ICanBorrow.Return()
        {
            Console.WriteLine($"TextBook '{Title}' has been retruned.");
        }
    }
}