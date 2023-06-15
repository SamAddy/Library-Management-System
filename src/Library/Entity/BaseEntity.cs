using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library.Entity
{
    public abstract class BaseEntity
    {
        public string Id { get; protected set; }
        public BaseEntity(string id)
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}