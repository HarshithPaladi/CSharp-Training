using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class oops2
    {
        public enum days { Monday, Tuesday, Wednesday}
        public void OverLoading(string name, string lastname, days Day)
        {
            Console.WriteLine($"{name} {lastname} - {Day}");
            Console.WriteLine();
        }
        public void OverLoading(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
