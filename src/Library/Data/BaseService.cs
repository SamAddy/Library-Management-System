using System.Reflection;
using Library.src.Library.Entity;

namespace Library.src.Library.Data
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        protected HashSet<T> collection;

        public BaseService()
        {
            collection = new HashSet<T>();
        }

        public List<T> GetAll()
        {
            return collection.ToList();
        }

        public void Add(T item)
        {
            collection.Add(item);
        }

        public bool Update(T item)
        {
            T itemToUpdate = GetById(item.Id);
            if (itemToUpdate != null)
            {
                Type itemType = typeof(T);
                PropertyInfo[] properties = itemType.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    object newValue = property.GetValue(item);
                    property.SetValue(itemToUpdate, newValue);
                }
                return true;
            }
            return false;
        }

        public T GetById(string id)
        {
            return collection.FirstOrDefault(item => item.Id == id);
        }

        public bool Delete(string id)
        {
            T item = GetById(id);
            if (item != null)
            {
                return collection.Remove(item);
            }
            return false;
        }
    }
}