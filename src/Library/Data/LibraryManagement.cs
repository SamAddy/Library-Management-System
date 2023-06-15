using Library.src.Library.Entity.Books;
using Library.src.Library.Entity.Persons;

namespace Library.src.Library.Data
{
    public class LibraryManagement
    {
        private BookService _bookService;
        private PersonService _personService;

        public LibraryManagement()
        {
            _bookService = new BookService();
            _personService = new PersonService();
        }

        public void AddBook(Book book)
        {
            _bookService.Add(book);
        }

        public bool RemoveBook(string bookId)
        {
            return _bookService.Delete(bookId);
        }

        public void BorrowBook(string bookId, Customer customer)
        {
            Book book = _bookService.GetById(bookId);
            if (book != null && book.CanBorrow)
            {
                // _bookService.Borrow(book);
                customer.BorrowBook(book);
                customer.ReturnBook(book);
            }
            else
            {
                _bookService.Borrow(book);
            }
        }

        public void ReturnBook(string bookId, Customer customer)
        {
            Book book = _bookService.GetById(bookId);
            if (book != null)
            {
                _bookService.Return(book);
                customer.ReturnBook(book);
            }
        }

        public void AddPerson(Person person)
        {
            _personService.Add(person);
        }

        public bool RemovePerson(string personId)
        {
            return _personService.Delete(personId);
        }

        public void EditPerson(Person person)
        {
            _personService.Update(person);
        }

        public void PrintBooks()
        {
            List<Book> books = _bookService.GetAll();
            Console.WriteLine("Books in the library:");
            foreach (Book book in books)
            {
                book.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}