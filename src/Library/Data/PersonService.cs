using Library.src.Library.Entity.Persons;

namespace Library.src.Library.Data
{
    public class PersonService<T> : BaseService<T> where T : Person
    {
        
        public void Edit(T person)
        {
            Update(person);
        }
    }
}