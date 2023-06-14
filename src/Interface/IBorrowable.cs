using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Interface
{
    public interface IBorrowable
    {
        void Borrow();
        void Return();
    }
}