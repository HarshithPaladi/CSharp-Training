using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCont
{
    internal class AsyncProg
    {
        public static async void FirstMethod()
        {
            Console.WriteLine("Method1 started");
            await Task.Delay(3000);
            Console.WriteLine("Method1 ended");
        }
        public async Task<int> returnNumber()
        {
            Thread.Sleep(2000);
            return 10;
        }
        public static async void SecondMethod()
        {
            Console.WriteLine("Method2 started");
            Console.WriteLine("Method2 ended");
        }
        public async Task<string> Method1()
        {
            Console.WriteLine("Hello Method1 started");
            Console.WriteLine("Message in method1");
            //string message
            Console.WriteLine(await Method2());
            Console.WriteLine("Hello Method1 ended");
            return "Completed Method1";
        }
        public async Task<string> Method2()
        {
            Console.WriteLine("Hello Method2 started");
            await Task.Delay(5000);
            string msg = "Message in method2";
            Console.WriteLine("Hello Method2 ended");
            return msg;
        }
        public async Task<int> Method3()
        {
            Console.WriteLine("Method3");
            return 4;
        }



        public static void AsyncProgRunAsync()
        {
            //Task<int> resNum = returnNumber();
            //FirstMethod();
            //await resNum;
            //Console.WriteLine($"Number = {resNum.Result}");
            //SecondMethod();
            //Console.WriteLine("+++++++++");

            //var test = new prediAcnFnc();
            //test.prediAcnFncRun();
            //Console.WriteLine("---------------------");
            //calculation.Start();

            var test1 = new AsyncProg();
            // AsyncProg.AsyncProgRunAsync();
            // here
            test1.Method1();
            Console.WriteLine("Method3 is starting...");
            int ans = test1.Method3().Result;
            Console.WriteLine("Ans is " + ans);
            //calculation.Stop();
            //Console.WriteLine("Elaspsed Time: " + calculation.ElapsedMilliseconds);
            Console.ReadLine();
            //Task t1 = test1.Method1();
            //Task t3 = test1.Method3();

        }
    }
    internal class Async2
    {
        async Task<int> a()
        {
            int number = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Executing method(a)");
                    number++;
                }
            });

            Console.WriteLine("In a");
            // await Task.Delay(3000);
            Console.WriteLine("End a");
            return number;
        }

        async Task b()
        {
            Console.WriteLine("In b");
            // await Task.Delay(5000);
            Console.WriteLine("End b");
        }

        async Task c(int number)
        {
            Console.WriteLine("Number from method(A): " + number);
            Console.WriteLine("In c");
            await Task.Delay(5000);
            Console.WriteLine("End c");
        }


        public async Task Main()
        {
            Async2 obj = new Async2();
            var task1 = obj.a();
            var task2 = obj.b();
            int number = await task1;
            var task3 = obj.c(number);
            // Task.WaitAll(task1,task2);
            Console.ReadKey();

        }
    }
}
