using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class Comic : Book, ICanBorrow
    {
        public string Artist { get; set; }

        public Comic(string title, string author, string isbn, string publicationYear, string id, string artist) : base(title, author, isbn, publicationYear, id)
        {
            Artist = artist;
            CanBorrow = true;
            CanPrint = false;
        }
        
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Artist: {Artist}");
        }

        void ICanBorrow.Borrow()
        {
            if (CanBorrow)
            {
                Console.WriteLine($"Comic Book '{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Comic Book '{Title}' cannot be borrowed.");
            }
        }

        void ICanBorrow.Return()
        {
           Console.WriteLine($"Comic Book '{Title}' has been retruned.");
        }
    }
}