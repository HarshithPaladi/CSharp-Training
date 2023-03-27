using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract public class abstraction
    {
        abstract public void method(int a, int b);
        public void normal_meth(int a, int b)
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine(a + b);
        }
    }
    public class MyClass : abstraction 
    {
        override public void method (int a, int b)
        {
            Console.WriteLine (a + b);
        }
    }
}
