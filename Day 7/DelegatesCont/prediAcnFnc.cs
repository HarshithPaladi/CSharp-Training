using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCont
{
    internal class prediAcnFnc
    {
        public int num = 15;
        delegate void Printer();
        static void PrinterCorp()
        {
            Console.WriteLine("Hello");
        }
        public void prediAcnFncRun()
        {
            Printer p = PrinterCorp;
            p.Invoke();

            // Action type built-in delegate
            Action<string> ConsolingDelegate = (msg) => { Console.WriteLine("Message: " + msg); };
            ConsolingDelegate("From BuiltIn Delegate");

            Func<int, string, string, string> d3 = (a, b, c) => {
                string res = b + c;
                Console.WriteLine($"{a} - {res}");
                return res;
            };
            Func<int> d4 = () =>
            {
                return 10;
            };
            Func<prediAcnFnc> d5 = () =>
            {
                prediAcnFnc p1 = new prediAcnFnc();
                p1.num = 20;
                return p1;
            };

            List<string> list = new List<string>() { "Hi", "Hello", "aWElcome" };
            Func<List<string>, List<string>> list2 = (list) => {
                list.Sort();
                return list;
            };
            Console.WriteLine(d3(12, "Hi", "Hello"));
            Console.WriteLine(d4());
            var val = d5().num;
            Console.WriteLine(val);
            var val2 = list2(list);
            foreach (var item in val2)
            {
                Console.WriteLine(item);
            }

            // Only return boolean
            // only accepts 1 input parameter
            Predicate<int> pd = (a) => { return a > 5; };
            Console.WriteLine(pd(2));

            Func<int, int, bool> checker = (a, b) => { return a > b; };
            Console.WriteLine(checker(1, 9));

            List<int> lst = new List<int> { 10, 2, 30, 4 };
            Predicate<List<int>> checkIfGreaterThanFive = (lst) => lst.All(a => a > 5);
            Console.WriteLine(checkIfGreaterThanFive(lst));




        }
    }
}
