using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Declaring delegate for Sum method
    delegate int DelegateForSum(int a, int b);
    public class DelegateTest
    {
        public int Sum(int a, int b)
        {
            //Console.WriteLine(a + b);
            return a + b;
        }
        public int Difference(int a, int b)
        {
            //Console.WriteLine(Math.Abs(a-b));
            return Math.Abs(a - b);
        }
        public int Multiplication(int a, int b)
        {
            //Console.WriteLine(a*b);
            return (a * b);
        }
    }
    
}
