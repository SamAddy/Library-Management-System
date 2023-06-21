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
        Book updatedBook1 = new Comic("Comic 1 updated", "Author 1", "1234567890", "2022", "B001", "Comic Artist");
        Customer customer1 = new Customer("John", "Smith", "john.smith@mail.com", "12345pass", "customer-1");
        Customer customer2 = new Customer("Steve", "Huhhs", "steve.huhhs@mail.com", "password1", "customer-2");
        Librarian librarian = new Librarian("Mark", "Anthony", "mark.anthony@mail.com", "lib123", "librarian-1");
    
        library.AddPerson(customer1);
        library.AddPerson(customer2);
        library.AddPerson(librarian);
        library.AddBook(book1, librarian.Id);
        library.AddBook(book2, librarian.Id);
        library.EditBook(updatedBook1, librarian.Id);
        library.RemoveCustomer(customer2.Id);

        library.BorrowBook("B001", customer1.Id);
        library.BorrowBook("B002", customer1.Id);
        library.BorrowBook("B0029", customer2.Id);
        library.ReturnBook("B001", customer1.Id);
        Console.WriteLine();
        library.PrintBooks();
    }
}