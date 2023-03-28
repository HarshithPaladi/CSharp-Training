using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void MathOperations(int a, int b);
    public class anonymous
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }


    }
}
