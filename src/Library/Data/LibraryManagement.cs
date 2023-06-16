using Library.src.Library.Entity.Books;
using Library.src.Library.Entity.Persons;

namespace Library.src.Library.Data
{
    public class LibraryManagement
    {
        private BookService _bookService;
        private PersonService<Customer> _customerService;
        private PersonService<Librarian> _librarianService;

        public LibraryManagement()
        {
            _bookService = new BookService();
            _customerService = new PersonService<Customer>();
            _librarianService = new PersonService<Librarian>();
        }

        public bool AddBook(Book book, string librarianId)
        {
            Librarian librarian = _librarianService.GetById(librarianId);
            Book checkBook = _bookService.GetById(book.Id);
            if (librarian != null)
            {
                    _bookService.Add(book);
                    librarian.EditBook(book);
                    return true;
            }
            else
            {
                Console.WriteLine($"Only librarians can add a book.");
                return false;
            }
        }

        public bool EditBook(string bookId, string librarianId)
        {
            Librarian librarian = _librarianService.GetById(librarianId);
            Book book = _bookService.GetById(bookId);
            if (librarian != null && book != null)
            {
                    _bookService.Update(book);
                    librarian.EditBook(book);
                    return true;
            }
            else
            {
                Console.WriteLine("Book or Librarian not found.");
                return false;
            }
        }

        public bool RemoveBook(string bookId, string librarianId)
        {
            Librarian librarian = _librarianService.GetById(librarianId);
            Book book = _bookService.GetById(bookId);
            if (librarian != null && book != null)
            {
                _bookService.Delete(bookId);
                Console.WriteLine($"Book '{book.Title}' has been removed from the library.");
                return true;
            }
            else
            {
                Console.WriteLine("Book not found.");
                return false;
            }
        }

        public void BorrowBook(string bookId, string customerId)
        {
            Customer customer = _customerService.GetById(customerId);
            Book book = _bookService.GetById(bookId);
            if (customer != null && book != null && book.CanBorrow)
            {
                _bookService.Borrow(book);
                customer.BorrowBook(book);
            }
            else
            {
                Console.WriteLine("Customer or book not found");
            }
        }

        public void ReturnBook(string bookId, string customerId)
        {
            Customer customer = _customerService.GetById(customerId);
            Book book = _bookService.GetById(bookId);
            if (customer != null && book != null)
            {
                _bookService.Return(book);
                customer.ReturnBook(book);
            }
            else
            {
                Console.WriteLine("Customer or book not found.");
            }
        }

        public void AddPerson(Person person)
        {
            if (person is Customer)
            {
                _customerService.Add((Customer)person);
                Console.WriteLine($"Customer '{person.FullName}' has been added.");
            }
            else if (person is Librarian)
            {
                _librarianService.Add((Librarian)person);
                Console.WriteLine($"Librarian '{person.FullName}' has been added.");
            }
        }

        public void EditPerson(Person person)
        {
            if (person is Customer)
            {
                _customerService.Update((Customer)person);
            }
            else if (person is Librarian)
            {
                _librarianService.Update((Librarian)person);
            }
            Console.WriteLine($"{person.FullName}'s details have been updated.");
        }

        public bool RemoveCustomer(string customerId)
        {
            Customer customer = _customerService.GetById(customerId);
            if (customer != null)
            {
                _customerService.Delete(customerId);
                Console.WriteLine($"Customer '{customer.FullName}' has been removed.");
                return true;
            }
            Console.WriteLine($"Customer with id `{customerId}`cannot be found.");
            return false;
        }

        public bool RemoveLibrarian(string librarianId)
        {
            Librarian librarian = _librarianService.GetById(librarianId);
            if (librarian != null)
            {
                _customerService.Delete(librarianId);
                Console.WriteLine($"Librarian '{librarian.FullName}' has been removed.");
                return true;
            }
            Console.WriteLine($"Librarian with id `{librarianId}`cannot be found.");
            return false;
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