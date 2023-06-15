using Library.src.Library.Data;
using Library.src.Library.Entity.Books;
using Library.src.Library.Entity.Persons;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Library Management System");
        
        LibraryManagement library = new LibraryManagement();

        Book book1 = new Comic("Comic 1", "Author 1", "1234567890", "2022", "B001", "Comic Artist");
        Book book2 = new Novel("Novel 1", "Author 2", "9876543210", "2021", "B002", "Thriller");
        Customer customer1 = new Customer("John", "Smith", "john.smith@mail.com", "12345pass", "customer-1");
        Customer customer2 = new Customer("Steve", "Huhhs", "steve.huhhs@mail.com", "password1", "customer-2");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddPerson(customer1);
        library.AddPerson(customer2);

        library.BorrowBook("B001", customer1);
        library.BorrowBook("B0029", customer2);
        Console.WriteLine();
        library.PrintBooks();
    }
}