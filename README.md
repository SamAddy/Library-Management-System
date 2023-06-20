# Library Management System

The Library Management System is an application that allows you to manage a collection of books, customers, and librarians in a library setting. It provides functionality for adding, removing, editing, borrowing, and returning books, as well as managing customer and librarian information.

## Features

* Add new books to the library.
* Remove books from the library.
* Edit book details such as title, author, ISBN, etc.
* Allow customers to borrow and return books.
* Add new customers to the library.
* Remove customers from the library.
* Edit customer details such as name, email, etc.
* Add new librarians to the library.
* Remove librarians from the library.
* Edit librarian details such as name, email, etc.

## Technologies Used
* C# programming language
* .NET Framework

## Installation & Usage
1. Clone the repository :
```
   https://github.com/SamAddy/Library-Management-System.git
```
2. Navigate to the project directory
```
   cd Library-Management-System
```
3. Restore dependencies
```
   dotnet restore
```
4. Run the application 
```
   dotnet run
```

## Sample Output
```
   Library Management System
   Customer 'John Smith' has been added.
   Customer 'Steve Huhhs' has been added.
   Librarian 'Mark Anthony' has been added.
   Librarian 'Mark Anthony has edited the book 'Comic 1'
   Librarian 'Mark Anthony has edited the book 'Novel 1'
   Librarian 'Mark Anthony has edited the book 'Comic 1 updated'
   Customer 'Steve Huhhs' has been removed.
   Book 'Comic 1 updated' has been borrowed.
   Book 'Comic 1 updated' has been borrowed by John Smith.
   Customer or book not found
   Book 'Comic 1 updated' has been returned by John Smith.

   Books in the library:
   Title: Comic 1 updated
   Author: Author 1
   ISBN: 1234567890
   Publication Year: 2022
   Can be borrowed: Available
   Is Printable: No
   Artist: Comic Artist

   Title: Novel 1
   Author: Author 2
   ISBN: 9876543210
   Publication Year: 2021
   Can be borrowed: Available
   Is Printable: No
   Genre: Thriller
```