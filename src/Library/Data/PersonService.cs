using Library.src.Library.Entity.Persons;

namespace Library.src.Library.Data
{
    public class PersonService : BaseService<Person>
    {
        public void Edit(Person person)
        {
            Update(person);
        }
    }
}