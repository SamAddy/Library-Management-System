using Library.src.Library.Entity.Books;

namespace Library.src.Library.Data
{
    public class BookService : BaseService<Book>
    {
        public bool Borrow(Book book)
        {
            if (book.CanBorrow)
            {
                book.CanBorrow = false;
                Console.WriteLine($"Book '{book.Title}' has been borrowed.");
                return true;
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' cannot be borrowed.");
            }
            return false;
        }

        public void Return(Book book)
        {
            book.CanBorrow = true;
        }
    }
}