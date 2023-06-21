using Library.src.Interface;

namespace Library.src.Library.Entity.Books
{
    public class Novel : Book, ICanBorrow
    {
        public string Genre { get; set; }

        public Novel(string title, string author, string isbn, string publicationYear, string id, string genre) : base(title, author, isbn, publicationYear, id)
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

        void ICanBorrow.Borrow()
        {
            if (CanBorrow)
            {
                Console.WriteLine($"Novel '{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Novel '{Title}' cannot be borrowed.");
            }
        }

        void ICanBorrow.Return()
        {
            Console.WriteLine($"Novel '{Title}' has been retruned.");
        }
    }
}