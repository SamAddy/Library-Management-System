namespace Library.src.Library.Entity.Books
{
    public abstract class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private string ISBN { get; set; }
        public string PublicationYear { get; set; }
        public bool CanBorrow { get; set; }
        public bool CanPrint { get; set; }

        public Book(string title, string author, string isbn, string publicationYear, string id) : base(id)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            Id = id;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Can be borrowed: {(CanBorrow ? "Available" : "Not Available")}");
            Console.WriteLine($"Is Printable: {(CanPrint ? "Yes" : "No")}");
        }
    }
}