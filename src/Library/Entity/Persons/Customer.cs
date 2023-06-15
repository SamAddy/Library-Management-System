using Library.src.Library.Data;
using Library.src.Library.Entity.Books;

namespace Library.src.Library.Entity.Persons
{
    public class Customer : Person
    {
        private BookService _bookService;
        private List<Book> _borrowedbooks;
        public Customer(string firstName, string lastName, string emailAddress, string password, string id) : base(firstName, lastName, emailAddress, password, id)
        {
            _borrowedbooks = new ();
        }

        public void BorrowBook(Book book)
        {
            if (book.CanBorrow)
            {
                _borrowedbooks.Add(book);
                book.CanBorrow = false;
                Console.WriteLine($"Book '{book.Title}' has been borrowed by {FirstName} {LastName}.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' cannot be borrowed.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (_borrowedbooks.Contains(book))
            {
                book.CanBorrow = true;
                Console.WriteLine($"Book '{book.Title}' has been returned by {FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' not found.");
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}