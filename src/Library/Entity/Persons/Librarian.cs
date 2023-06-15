using Library.src.Library.Entity.Books;

namespace Library.src.Library.Entity.Persons
{
    public class Librarian : Person
    {
        public Librarian(string firstName, string lastName, string emailAddress, string password, string id) : base(firstName, lastName, emailAddress, password, id)
        {

        }
        
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}