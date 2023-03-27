using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AccessSpecifiers
    {
         protected string name = "Harshith";
        protected internal void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
