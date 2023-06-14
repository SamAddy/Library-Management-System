using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Interface
{
    public interface IPrintable
    {
        void PrintPages(int startPage, int endPage);
    }
}