using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Delegates
    {
        public delegate void DelegateFunc(int a);
        public void Test(int a, DelegateFunc delegateFunc)
        {
            delegateFunc(a);
        }
        public void Test2(string str, Func<string, string> delegateFunc)
        {
            Console.WriteLine(delegateFunc(str));
        }
        public void TestGenerics(int a, Action<int> delegateFunc)
        {
            delegateFunc(a);
        }
    }

    public class Obj
    {
        public void func1(int a)
        {
            Console.WriteLine("func1-" + a);
        }
        public void func2(int a)
        {
            Console.WriteLine("func2-" + a);
        }
        public string funcStr(string str)
        {
            Console.WriteLine("call 1");
            return str;
        }
    }
}
