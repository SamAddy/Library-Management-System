using Library.src.Interface;
using Library.src.Library.Data;
using Library.src.Library.Entity.Books;

namespace Library.src.Library.Entity.Persons
{
    public class Customer : Person
    {
        private List<Book> _borrowedbooks;
        public Customer(string firstName, string lastName, string emailAddress, string password, string id) : base(firstName, lastName, emailAddress, password, id)
        {
            _borrowedbooks = new ();
        }

        public void BorrowBook(Book book)
        {
            _borrowedbooks.Add(book);
            Console.WriteLine($"Book '{book.Title}' has been borrowed by {FullName}.");
        }

        public void ReturnBook(Book book)
        {
            _borrowedbooks.Remove(book);
            Console.WriteLine($"Book '{book.Title}' has been returned by {FullName}.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}