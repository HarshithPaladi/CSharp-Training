namespace Delegates
{
    delegate void Print(string message);
    delegate int add(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            var D = new DelegateTest();
            DelegateForSum ds = D.Sum;

            // Multi Cast delegate - More than 1 method for a delegate
            ds += D.Difference;
            ds += D.Multiplication;

            Console.WriteLine(ds(20, 50));
            Console.WriteLine("------------------------------");
            Delegate[] arr = ds.GetInvocationList();

            foreach (DelegateForSum d in arr)
            {
                Console.WriteLine(d(1, 2));
            }
            foreach (DelegateForSum a in ds.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(12, 5));
            }
            Console.WriteLine("------------------------------");

            // To remove a method from delegate (ds -= Method;)
            ds -= D.Sum;
            Console.WriteLine(ds.DynamicInvoke(1, 5));
            Console.WriteLine("------------------------------");

            // Anonymous
            var a1 = new anonymous();
            MathOperations d1 = a1.add;
            MathOperations d2 = a1.sub;
            MathOperations d3 = a1.mul;
            MathOperations d4 = a1.div;
            MathOperations d5 = d1 + d2 + d3 + d4;
            Delegate[] array = d5.GetInvocationList();

            d5.Invoke(2, 3);
            d5 -= d1;
            d5.Invoke(5, 1);
            Console.WriteLine("------------------------------");

            DelegateForSum dAdd = new DelegateForSum(delegate (int a, int b) { return a + b; });
            Console.WriteLine(dAdd(10, 12));

            Print print = delegate (string msg) { Console.WriteLine(msg); };
            print.Invoke("Hello");
            Console.WriteLine("------------------------------");

            // LamdaExp
            add sum = (num1, num2) => num1 + num2; // => is lamda ??
            Console.WriteLine(sum.Invoke(12, 45));

            Print Msg = (str) => { Console.WriteLine(str); };
            Msg.Invoke("Hello from delegate lamda exp");

            var sumnd = (int num1, int num2) => num1 + num2;
            var subnd = (int num1, int num2) => num1 - num2;
            var mul = (int num1, int num2) => num1 * num2;
            Console.WriteLine(mul(2, 30));
            subnd += sumnd;
            foreach (Delegate a in subnd.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(2, 3));
            }
            Console.WriteLine("------------------------------");
            var runner = new LamdaExp();
            runner.Run();
            Console.WriteLine("-------------------------------------");
            runner.ARun();
            Console.WriteLine("-------------------------------------");
            runner.BRun();
            Console.WriteLine("-------------------------------------");
            var student = new Student();
            student.method();
            Console.WriteLine("-------------------------------------");
            runner.StatementLambda(12, 9);
            Console.WriteLine("-------------------------------------");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int count = nums.Count(n => n % 2 == 0);
            Console.WriteLine(count);
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("-------------------------------------");
            Func<int, int, int> Fn = (a, b) => a + b;
            Console.WriteLine(Fn(5, 5));

        }

    }
}