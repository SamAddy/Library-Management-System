namespace Library.src.Library.Entity.Persons
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string EmailAddress { get; }
        public string Password { get; set; }

        public string FullName => $"{FirstName} {LastName}";
 
        public Person(string firstName, string lastName, string emailAddress, string password, string id) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            Id = id;
        }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {EmailAddress}");
        }
    }
}