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

        public override void Borrow()
        {
            if (CanBorrow)
            {
                base.Borrow();
            }
            else 
            {
                Console.Write($"Comic '{Title}' cannot be borrowed.");
            }
        }
        
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Artist: {Artist}");
        }
    }
}