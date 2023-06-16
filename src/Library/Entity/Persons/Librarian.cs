using Library.src.Library.Entity.Books;

namespace Library.src.Library.Entity.Persons
{
    public class Librarian : Person
    {
        public Librarian(string firstName, string lastName, string emailAddress, string password, string id) : base(firstName, lastName, emailAddress, password, id)
        {

        }

        public void AddBook(Book book)
        {
            Console.WriteLine($"Librarian '{FullName} added the book '{book.Title}' to the library.");
        }

        public void EditBook(Book book)
        {
            Console.WriteLine($"Librarian '{FullName} has edited the book '{book.Title}'");
        }

        public void RemoveBook(Book book)
        {
            Console.WriteLine($"Librarian '{FullName} removed the book '{book.Title} from the library.'");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}