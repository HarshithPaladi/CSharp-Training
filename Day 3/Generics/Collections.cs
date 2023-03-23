using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Collections
    {
        public static void Main(string[] args)
        {
            var ListDemo = new List<string>() { "new","oraanges"};
            ListDemo.Add("Hello");
            ListDemo.Add("Hello2");
            ListDemo.Add("Hello1");

            foreach (var item in ListDemo)
            {
                Console.WriteLine(item);
            }
            ListDemo.Remove("Hello1");
            foreach (var item in ListDemo)
            { Console.WriteLine(item); }
        }
    }
}
