using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Oops_test
    { 
        public void method1()
        {
            var obj1 = new Priv_Oops();
            obj1.Method2();
            Console.WriteLine("From test class");
        }
        public class Priv_Oops
        {
            internal void Method2()
            {
                Console.WriteLine("From priv class");
            }
        }

    }
}
