using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Generics
    {
        public T TestCall <T> (T a)
        {
            return a;
        }
        public T TestCall <T> (T a, T b)
        {
            T t = a;
            return t;
        }
    }
}
