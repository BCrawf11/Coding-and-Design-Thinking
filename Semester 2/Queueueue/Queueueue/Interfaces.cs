using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueueue
{
    interface IClearable
    {
        void Clear();
    }

    interface IPrintable
    {
        void Print();
    }

    interface ICountable
    {
        int Count();
    }
}
