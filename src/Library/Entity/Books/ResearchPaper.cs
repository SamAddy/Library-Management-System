using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class ResearchPaper : Book, IPrintable
    {
        public int MaxAmountOfPrintablePages;

        public ResearchPaper(string title, string author, string isbn, string publicationYear, int maxAmountOfPrintablePages, string id) : base(title, author, isbn, publicationYear, id)
        {
            CanBorrow = false;
            CanPrint = true;
            MaxAmountOfPrintablePages = maxAmountOfPrintablePages;
            
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