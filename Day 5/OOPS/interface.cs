using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public interface Iparent
    {
        public void show();
        public void calculate(int age);
        public void display(string name)
        {
            Console.WriteLine(name);
        }    
    }
    public class child:Iparent
    {
        public void show()
        {
            Console.WriteLine("show meth in child");
        }
        public void calculate(int age)
        {
            Console.WriteLine(age);
        }
        public void display(string name)
        {
            Console.WriteLine(name);
        }
    }
}
